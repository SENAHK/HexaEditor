﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexaEditor
{
    /*
     * BUG
     * Il faut revoir la génération du tableau, car en réinjectant les donnnées dans le reader
     * on le fait avec la taille du tableau. Il faudrait revoir la génération dans la textbox
     * pour faire en sorte qu'elle conserve le ratio de largeur et de hauteur mais s'arrête à 
     * la fin tu tableau (qu'on ne force pas à avoir la taille de la page)
     * 
     *  ++ J'ai besoin d'une variable avec la position du curseur pour modifier l'interieur des cases
     */ 

    public partial class ViewHexaEditor : Form
    {
        private ModelHexaEditor _model;
        private int _selectedCase = 0;
        private const int ARRAY_WIDTH = 16;
        private ulong page = 0;
        private bool focus = true; //true => Focus pbHexa | false => Focus pbASCII

        private string[] values;
        private string[] asciiValues;

        public int SelectedCase
        {
            get { return _selectedCase; }
            set { _selectedCase = value; }
        }

        public ModelHexaEditor Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public ViewHexaEditor()
        {
            InitializeComponent();
            Model = new ModelHexaEditor();
            
            this.MouseWheel += ViewHexaEditor_MouseWheel;
        }

        /// <summary>
        /// Scroll => commande le changement de page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ViewHexaEditor_MouseWheel(object sender, MouseEventArgs e)
        {
            if (this.Model.IsInit)
            {
                // Down
                if (e.Delta < 0)
                {
                    this.Model.nextPage();
                }
                else
                {
                    this.Model.previousPage();
                }
                this.LoadPages();
                RefreshOutput();
            }
        }

        /// <summary>
        /// Load de la form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewHexaEditor_Load(object sender, EventArgs e)
        {
            //RefreshOutput();
        }

        /// <summary>
        /// Charge les pages référencée par le paramètre page du model
        /// </summary>
        public void LoadPages()
        {
            // Values to show (page)
            this.values = Model.getPageContent();
            this.asciiValues = Model.getASCIIpage();
        }

        /// <summary>
        /// Met à jour le contenu des tableaux en fonction du paramètre value
        /// </summary>
        public void RefreshOutput()
        {
            // Show in the picturebox
            pbxOutput.Image = Model.GenerateDrawnValues(this.values, pbxOutput.Width, pbxOutput.Height);
            pbxOutput.Invalidate();


            pbxAscii.Image = Model.generateDrawnValuesAsAscii(this.asciiValues, pbxAscii.Width, pbxAscii.Height);
            pbxAscii.Invalidate();
        }

        /// <summary>
        /// Paint the selection cursor in the hexa picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxOutput_Paint(object sender, PaintEventArgs e)
        {
            if (Model.IsInit)
            {
                selectCase(this.Model.Cases, this.values, e);
            }
        }

        /// <summary>
        /// Paint the selection cursor in the ascii picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAscii_Paint(object sender, PaintEventArgs e)
        {
            if (Model.IsInit)
            {
                selectCase(this.Model.CasesASCII, this.asciiValues, e);
            }
        }

        /// <summary>
        /// Select the case by painting it
        /// </summary>
        /// <param name="rectanglesToFill"></param>
        /// <param name="values"></param>
        /// <param name="e"></param>
        public void selectCase(List<Rectangle> rectanglesToFill, string[] values, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Blue, rectanglesToFill[SelectedCase]);
            g.DrawString(values[SelectedCase], new Font("Tahoma", 8), Brushes.White, rectanglesToFill[SelectedCase]);
        }

        /// <summary>
        /// Controls of the cursor: Arrow keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewHexaEditor_KeyDown(object sender, KeyEventArgs e)
        {
            int t_selectedCase = SelectedCase;

            switch (e.KeyData)
            {
                case Keys.Right:
                    SelectedCase += 1;
                    break;
                case Keys.Down:
                    SelectedCase += 16;
                    break;
                case Keys.Up:
                    SelectedCase -= 16;
                    break;
                case Keys.Left:
                    SelectedCase -= 1;
                    break;

                default:
                    break;
            }

            // If the cell is out of range
            if (SelectedCase < 0 || SelectedCase > values.Length)
            {
                SelectedCase = t_selectedCase;
            }
            RefreshLabels();
            // Refresh pbx
            pbxOutput.Invalidate();
            pbxAscii.Invalidate();
        }

        /// <summary>
        /// Mets à jour les labels d'information
        /// </summary>
        public void RefreshLabels()
        {
            lblFileName.Text = Model.FileInfos["Name"];
            lblFileSize.Text = Model.FileInfos["Length"] + " octets";
            lblCreationDate.Text = Model.FileInfos["CreationDate"];
            lblModificationDate.Text = Model.FileInfos["ModificationDate"];
            lblFileLastAccess.Text = Model.FileInfos["LastAccess"];
            lblChar.Text = Model.getASCII((ulong)SelectedCase).ToString();
            lblBin.Text = Model.getBinary((ulong)SelectedCase);
            lblOctal.Text = Model.getOctal((ulong)SelectedCase);
            lbl8s.Text = Model.getSByte((ulong)SelectedCase);
            lbl8ns.Text = Model.getByte((ulong)SelectedCase);
            lbl16s.Text = Model.getInt16((ulong)SelectedCase);
            lbl16ns.Text = Model.getUint16((ulong)SelectedCase);
            lbl32s.Text = Model.getInt32((ulong)SelectedCase);
            //lbl32ns.Text = Model.get((ulong)SelectedCase);
            lbl64.Text = Model.getInt64((ulong)SelectedCase);
            lblDouble.Text = Model.getDouble((ulong)SelectedCase);
            lblFloat.Text = Model.getFloat((ulong)SelectedCase);

        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdOpenFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Model.initReader(ofdOpenFile.FileName);
                this.LoadPages();
                RefreshOutput();
            }
        }

        private void tbcData_KeyDown(object sender, KeyEventArgs e)
        {
            // Remove the default behaviour that allows navigating in the tabs with the arrow keys
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                e.Handled = true;
            // 
            ViewHexaEditor_KeyDown(sender, e);
        }

        /// <summary>
        /// Onglet save du menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            this.Model.setPage(this.values);
            this.Model.saveFIle();
        }

        /// <summary>
        /// Click sur le tableau des Hexadécimaux => met le focus dessus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxOutput_Click(object sender, EventArgs e)
        {
            this.focus = true;
        }

        /// <summary>
        /// Cick sur le tableau des ascii  => met le focus dessus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAscii_Click(object sender, EventArgs e)
        {
            this.focus = false;
        }

        /// <summary>
        /// Filtre les caractères en fonction du focus de l'utilisateur sur l'un des tableaux
        /// Renvoie à l'une des fonctions d'écriture si les caractères sont valides
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewHexaEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (focus)
            {
                e.KeyChar = Convert.ToChar(e.ToString().ToUpper());
                if (char.IsNumber(e.KeyChar) || e.KeyChar == 'A' || e.KeyChar == 'B' || e.KeyChar == 'C' || e.KeyChar == 'D' || e.KeyChar == 'F')
                {
                    WriteFromHexa(e.KeyChar);
                }
            }
            else
            {
                WriteFromAscii(e.KeyChar);
            }
        }

        /// <summary>
        /// écris la valeur en l'état dans le tableau ascii et la convertit en hexadécimal pour l'écrire dans le tableau des hexa
        /// </summary>
        /// <param name="value">caractère ascii</param>
        public void WriteFromAscii(char value)
        {
            int height = 1; //Temporaire
            int width = 1; //Temporaire

            int position = height * ARRAY_WIDTH + width;

            this.asciiValues[position] = value.ToString();

            string hexa = Convert.ToString(Convert.ToByte(value), 16);
            this.values[position] = hexa;

            RefreshOutput();
        }
        /// <summary>
        /// écris la valeur en l'état, en concaténé ou en remplacement selon le nombre de caractères présents dans la case hexa
        /// converti la valeur donnée par l'opération précédente en ascii pour l'écrire dans le tableau correspondant
        /// </summary>
        /// <param name="value"></param>
        public void WriteFromHexa(char value)
        {
            int height = 1; //Temporaire
            int width = 1; //Temporaire

            int position = height * ARRAY_WIDTH + width;
            string reff = this.values[position];

            if (reff.Length == 1)
            {
                this.values[position] = reff + value;
            }
            else
            {
                this.values[position] = value.ToString();
            }

            byte numericVal = Convert.ToByte(Convert.ToInt32(this.values[position], 16));
            this.asciiValues[position] = ((char)numericVal).ToString();

            RefreshOutput();
        }
    }
}
