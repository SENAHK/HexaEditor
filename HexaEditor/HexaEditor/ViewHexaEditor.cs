using System;
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
    public partial class ViewHexaEditor : Form
    {
        private ModelHexaEditor _model;
        private int _selectedCase = 0;
        private const int ARRAY_WIDTH = 16;
        private ulong page = 0;
        private bool focus = true; //true => Focus pbhexa | false => Focus phASCII
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
                RefreshOutput();
            }
        }

        private void ViewHexaEditor_Load(object sender, EventArgs e)
        {
            //RefreshOutput();
        }

        public void RefreshOutput()
        {
            // Values to show (page)
            string[] values = Model.getPageContent();

            // Show in the picturebox
            pbxOutput.Image = Model.GenerateDrawnValues(Model.getPageContent(), pbxOutput.Width, pbxOutput.Height);
            pbxOutput.Invalidate();


            pbxAscii.Image = Model.generateDrawnValuesAsAscii(Model.getASCIIpage(), pbxAscii.Width, pbxAscii.Height);
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
                selectCase(this.Model.Cases, Model.getPageContent(), e);
            }
        }

        /// <summary>
        /// Paint the selection cursor in the ascii picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAscii_Paint(object sender, PaintEventArgs e)
        {
            //string[] values = Model.getASCIIpage();
            //for (int i = 0; i < values.Length; i++)
            //{
            //    values[i] = Model.getASCII((ulong)i).ToString();
            //}
            if (Model.IsInit)
            {
                selectCase(this.Model.CasesASCII, Model.getASCIIpage(), e);
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
            if (SelectedCase < 0 || SelectedCase > 511)
            {
                SelectedCase = t_selectedCase;
            }
            RefreshLabels();
            // Refresh pbx
            pbxOutput.Invalidate();
            pbxAscii.Invalidate();
        }

        public void RefreshLabels()
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



    }
}
