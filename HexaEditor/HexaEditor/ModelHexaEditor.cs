using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexaEditor
{
    public class ModelHexaEditor
    {
        private Reader fileReader;
        public ulong page;
        private static const ulong PAGECAPACITY = 16 * 32;

        public ModelHexaEditor()
        {

        }

        public void WriteInPictureBox(PictureBox pbx, string[,] values)
        {
            Bitmap DrawArea = new Bitmap(pbx.Size.Width, pbx.Size.Height);
            Graphics g = Graphics.FromImage(DrawArea);

            int valuesX = values.GetLength(1);
            int valuesY = values.GetLength(0);

            int width = pbx.Size.Width / valuesX;
            int height = pbx.Size.Height / valuesY;

            string output = "";

            for (int y = 0; y < valuesY; y++)
            {
                for (int x = 0; x < valuesX; x++)
                {
                    output = values[y, x];
                    
                    Rectangle rect = new Rectangle(x * width, y * height, width, height);
                    g.DrawString(output, new Font("Courier New", 16), Brushes.Black, rect);
                }
            }
            pbx.Image = DrawArea;
            g.Dispose();
        }
        /// <summary>
        /// Donne un tableau du nombre de valeur correspondant à la constante PAGECAPACITY, en fonction de la variable page
        /// </summary>
        /// <returns></returns>
        public string[] getPageContent()
        {
            string[] values = new string[PAGECAPACITY];
            ulong start = PAGECAPACITY * page;
            ulong stop = start + PAGECAPACITY;
            int count = 0;


            for (ulong i = start; i < stop; i++)
            {
                values[count] = fileReader.getHexa(i);

                count++;                 
            }

            return values;
        }
    }
}
