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

        public ModelHexaEditor Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public ViewHexaEditor()
        {
            InitializeComponent();
            Model = new ModelHexaEditor();
        }

        private void ViewHexaEditor_Load(object sender, EventArgs e)
        {
            //string[,] chaines = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };
            string[,] chaines = new string[4, 17];
            Model.WriteInPictureBox(pbxOutput, chaines);


        }
        public void generateRandomHexValues(string[,] values)
        {
            Random rnd = new Random();
            string hexOutput = "";
            int num;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 17; x++)
                {
                    if (y == 0)
                    {
                        hexOutput = String.Format("{0:X}", x);
                    }
                    else
                    {
                        num = rnd.Next(0, 17);
                        hexOutput = String.Format("{0:X}", num);
                    }
                    values[y, x] = hexOutput;
                }
            }
        }
    }
}
