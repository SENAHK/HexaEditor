using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private int _selectedCase;
        private const int ARRAY_WIDTH = 16;
        private bool focus; //true => Focus pbHexa | false => Focus pbASCII
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
            this.SelectedCase = 0;
            this.focus = true;
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
                this.Model.setPage(this.values);

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
            this.Select();

            // Priority to the form when a key event is triggered
            this.KeyPreview = true;
        }
        /// <summary>
        /// Charge les pages référencée par le paramètre page du model
        /// </summary>
        public void LoadPages()
        {
            // Le modèle a été initialisé
            if (this.Model.IsInit)
            {
                // Values to show (page)
                this.values = Model.getPageContent();
                this.asciiValues = Model.getASCIIpage();
                RefreshOutput();
                RefreshLabels();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Ce fichier est vide, impossible d'afficher son contenu", "Erreur de lecture", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dr == DialogResult.OK)
                    tsmiOpen.PerformClick();
            }
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
            Debug.Print(SelectedCase.ToString());
            string c = values[SelectedCase];
            Brush b = Brushes.White;
            if (this.Model.CharIsNotPrintable(c))
            {
                c = ".";
                b = Brushes.DimGray;
            }
            g.FillRectangle(Brushes.Blue, rectanglesToFill[SelectedCase]);
            g.DrawString(c, new Font("Tahoma", 8), b, rectanglesToFill[SelectedCase]);
        }
        /// <summary>
        /// Controls of the cursor: Arrow keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewHexaEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.values != null)
            {

                int t_selectedCase = SelectedCase;
                bool move = false;
                switch (e.KeyData)
                {
                    case Keys.Right:
                        if (SelectedCase + 1 < values.Length)
                        {
                            t_selectedCase += 1;
                            move = true;
                        }
                        break;
                    case Keys.Down:
                        if (SelectedCase + 16 < values.Length)
                        {
                            t_selectedCase += 16;
                            move = true;
                        }
                        break;
                    case Keys.Up:
                        if (SelectedCase - 16 >= 0)
                        {
                            t_selectedCase -= 16;
                            move = true;
                        }
                        break;
                    case Keys.Left:
                        if (SelectedCase - 1 >= 0)
                        {
                            t_selectedCase -= 1;
                            move = true;
                        }
                        break;
                    default:
                        break;
                }

                if (move)
                {
                    completeSelectedCase();
                    this.SelectedCase = t_selectedCase;
                    // Refresh pbx
                    RefreshOutput();
                    RefreshLabels();
                }

                Debug.Print(SelectedCase.ToString());
            }

        }
        /// <summary>
        /// Ne marche pas
        /// </summary>
        /// <param name="thisCase"></param>
        private void completeSelectedCase()
        {
            //MessageBox.Show(this.values[thisCase].Length.ToString());
            if (this.values[this.SelectedCase].Length < 2)
            {
                this.values[this.SelectedCase] = '0' + this.values[this.SelectedCase];
            }
        }
        /// <summary>
        /// Mets à jour les labels d'information
        /// </summary>
        public void RefreshLabels()
        {
            // Case dans le tableau
            ulong theCase = this.Model.getCaseByPage((ulong)this.SelectedCase);

            lblPage.Text = String.Format("Page {0} sur {1}", this.Model.Page + 1, this.Model.TotalPages + 1);
            lblFileName.Text = Model.FileInfos["Name"];
            lblFileSize.Text = Model.FileInfos["Length"] + " octets";
            lblCreationDate.Text = Model.FileInfos["CreationDate"];
            lblModificationDate.Text = Model.FileInfos["ModificationDate"];
            lblFileLastAccess.Text = Model.FileInfos["LastAccess"];
            string valueToProcess = this.values[this.SelectedCase];
            List<string> valuesToProcess = new List<string>(); 

            lblBin.Text = Model.getBinary(valueToProcess);
            lblOctal.Text = Model.getOctal(valueToProcess);

            // 8
            lbl8s.Text = Model.getSByte(valueToProcess);
            lbl8ns.Text = Model.getByte(valueToProcess);

            // 16
            for (int i = SelectedCase; i < values.Length && i < SelectedCase+2; i++)
            {
                valuesToProcess.Add(this.values[i]);
            }
            lbl16s.Text = Model.getInt16(valuesToProcess, this.SelectedCase);
            lbl16ns.Text = Model.getUint16(valuesToProcess, this.SelectedCase);

            //32
            for (int i = SelectedCase+2; i < values.Length && i < SelectedCase+4; i++)
            {
                valuesToProcess.Add(this.values[i]);
            }
            lbl32s.Text = Model.getInt32(valuesToProcess, this.SelectedCase);
            lbl32ns.Text = Model.getUInt32(valuesToProcess, this.SelectedCase);
            //lbl32ns.Text = Model.get((ulong)SelectedCase);

            // 64 +
            for (int i = SelectedCase + 4; i < values.Length && i < SelectedCase + 8; i++)
            {
                valuesToProcess.Add(this.values[i]);
            }
            lbl64.Text = Model.getInt64(valuesToProcess, this.SelectedCase);
            lblDouble.Text = Model.getDouble(valuesToProcess, this.SelectedCase);
            lblFloat.Text = Model.getFloat(valuesToProcess, this.SelectedCase);

            // Ascii value
            string c = Model.getASCII(valueToProcess).ToString();
            lblChar.Text = this.Model.CharIsNotPrintable(c) ? " " : c;

        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            ofdOpenFile.FileName = "";
            DialogResult dr = ofdOpenFile.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.Model.initReader(ofdOpenFile.FileName);
                this.SelectedCase = 0;
                this.LoadPages();
            }
        }
        private void tbcData_KeyDown(object sender, KeyEventArgs e)
        {
            // Remove the default behaviour that allows navigating in the tabs with the arrow keys
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
                e.Handled = true;
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
            if (Model.IsInit)
            {
                if (focus)
                {
                    e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
                    if (char.IsNumber(e.KeyChar) || e.KeyChar == 'A' || e.KeyChar == 'B' || e.KeyChar == 'C' || e.KeyChar == 'D' || e.KeyChar == 'F')
                    {
                        WriteFromHexa(e.KeyChar);
                    }
                }
                else
                {
                    WriteFromAscii(e.KeyChar, true);
                }
            }
        }
        /// <summary>
        /// écris la valeur en l'état dans le tableau ascii et la convertit en hexadécimal pour l'écrire dans le tableau des hexa
        /// </summary>
        /// <param name="value">caractère ascii</param>
        public void WriteFromAscii(char value, bool saveState)
        {
            if (saveState)
            {
                this.Model.addState(Convert.ToChar(this.asciiValues[this.SelectedCase]), this.SelectedCase);

            }
            this.asciiValues[this.SelectedCase] = value.ToString();

            string hexa = Convert.ToString(Convert.ToByte(value), 16);
            this.values[this.SelectedCase] = hexa.ToUpper();

            RefreshOutput();
        }
        /// <summary>
        /// écris la valeur en l'état, en concaténé ou en remplacement selon le nombre de caractères présents dans la case hexa
        /// converti la valeur donnée par l'opération précédente en ascii pour l'écrire dans le tableau correspondant
        /// </summary>
        /// <param name="value"></param>
        public void WriteFromHexa(char value)
        {

            this.Model.addState(Convert.ToChar(this.asciiValues[this.SelectedCase]), this.SelectedCase);

            string reff = this.values[this.SelectedCase];

            if (reff.Length == 1)
            {
                this.values[this.SelectedCase] = reff + value;
            }
            else
            {
                this.values[this.SelectedCase] = value.ToString();
            }

            byte numericVal = Convert.ToByte(Convert.ToInt32(this.values[this.SelectedCase], 16));
            this.asciiValues[this.SelectedCase] = ((char)numericVal).ToString();



            RefreshOutput();
        }
        /// <summary>
        /// Anulle la dernière action et redirige l'affichage sur l'emplacement de cette action
        /// </summary>
        public void undo()
        {
            if (this.Model.IsInit)
            {
                string result = Model.undo();
                int cursor;
                if (int.TryParse(result, out cursor))
                {
                    if (cursor != -1)
                    {
                        this.values = Model.getPageContent();
                        this.asciiValues = Model.getASCIIpage();
                        this.SelectedCase = cursor;
                        this.RefreshOutput();
                        this.RefreshLabels();
                    }
                }
                else
                {
                    byte stateValue = Convert.ToByte(result[0]);
                    char[] tmpID = new char[result.Length - 1];
                    Array.Copy(result.ToCharArray(), 1, tmpID, 0, result.Length - 1);
                    int stateID = Convert.ToInt32(new string(tmpID));

                    this.SelectedCase = stateID;
                    this.WriteFromAscii(Convert.ToChar(stateValue), false);
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.undo();
        }
    }
}
