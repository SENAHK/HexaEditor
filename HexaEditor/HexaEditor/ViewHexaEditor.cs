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

        private const int ARRAY_WIDTH = 16;

        public ViewHexaEditor()
        {
            InitializeComponent();
            Model = new ModelHexaEditor();
        }

        private void ViewHexaEditor_Load(object sender, EventArgs e)
        {

            Model.initReader(@"C:\Users\ramusim_info\Desktop\sample.dll");
            string[] values = Model.getPageContent(1);
            WriteInPictureBox(pbxOutput, values);
        }

        /// <summary>
        /// Affiche les éléments d'un tableau string dans un picturebox
        /// </summary>
        /// <param name="pbx"></param>
        /// <param name="values"></param>
        public void WriteInPictureBox(PictureBox pbx, string[] values)
        {
            Bitmap DrawArea = new Bitmap(pbx.Size.Width, pbx.Size.Height);
            Graphics g = Graphics.FromImage(DrawArea);

            // Largeur du tableau fixe à 16
            int valuesX = ARRAY_WIDTH;

            // Hauteur du tableau: si plus grand que 16 (càd une ligne), divisé par 16
            int valuesY = values.Length > 16 ? values.Length / 16 : 1;

            // Largeur et hauteur des rectangles
            int width = pbx.Size.Width / valuesX;
            int height = pbx.Size.Height / valuesY;

            string output = "";

            for (int y = 0; y < valuesY; y++)
            {
                for (int x = 0; x < valuesX; x++)
                {
                    // En-tête de colonnes
                    if (y == 0)
                    {
                        if (x == 0)
                            output = "";
                        else
                            output = "0" + String.Format("{0:X}", x);
                    }
                    else
                    {
                        // Titres de lignes
                        if (x == 0)
                        {
                            output = String.Format("{0:X}", y);
                        }
                        else
                        {
                            // Valeurs à afficher
                            output = values[y + x];
                        }
                    }

                    Rectangle rect = new Rectangle(x * width, y * height, width * 2, height * 2);
                    // Afficher les éléments du tableau dans une surface de dessin
                    Brush brush = x == 0 || y == 0 ? Brushes.Blue : Brushes.Black;
                    g.DrawString(output, new Font("Courier New", 8), brush, rect);
                }
            }
            // Affichage dans la pictureBox
            pbx.Image = DrawArea;
            g.Dispose();
        }

        private void pbxOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
