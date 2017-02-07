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
            


        }


        public void WriteInPictureBox(PictureBox pbx, string[] values)
        {
            Bitmap DrawArea = new Bitmap(pbx.Size.Width, pbx.Size.Height);
            Graphics g = Graphics.FromImage(DrawArea);

            // Largeur du tableau
            int valuesX = 16;

            int valuesY = values.Length > 16 ? values.Length / 16 : 1;

            int width = pbx.Size.Width / valuesX;
            int height = pbx.Size.Height / valuesY;

            string output = "";
            for (int y = 0; y < valuesY; y++)
            {
                for (int x = 0; x < valuesX; x++)
                {
                    // En-tête
                    if (y == 0)
                    {
                        if (x == 0)
                            output = "Offset";
                        else
                            output = String.Format("{0:X}", x);

                    }
                    else
                    {
                        if (x == 0)
                        {
                            output = String.Format("{0:X}", y);
                        }
                        else
                        {
                            output = values[y + x];
                            Rectangle rect = new Rectangle(x * width, y * height, width, height);
                            g.DrawString(output, new Font("Courier New", 16), Brushes.Black, rect);
                        }
                    }
                }
            }
            pbx.Image = DrawArea;
            g.Dispose();
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

        private void pbxOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
