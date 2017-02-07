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
                    if (x == 0)
                    {
                        output = 
                    }else{
                    output = values[y, x];
                    }
                    Rectangle rect = new Rectangle(x * width, y * height, width, height);
                    g.DrawString(output, new Font("Courier New", 16), Brushes.Black, rect);
                }
            }
            pbx.Image = DrawArea;
            g.Dispose();
        }
    }
}
