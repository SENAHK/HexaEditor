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
        private const ulong PAGECAPACITY = 16 * 32;

        public ModelHexaEditor()
        {

        }       

        public void initReader(string path)
        {
            this.fileReader = new Reader(path);
        }

        /// <summary>
        /// Donne un tableau du nombre de valeur correspondant à la constante PAGECAPACITY, en fonction de la variable page
        /// </summary>
        /// <returns></returns>
        public string[] getPageContent(ulong page)
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

        /// <summary>
        /// Création d'une image bitmap contenant les valeurs passé en paramètres
        /// </summary>
        /// <param name="values">Tableau de string de valeurs</param>
        /// <param name="imageWidth">Largeur de l'image</param>
        /// <param name="imageHeight">Hauteur de l'image</param>
        /// <returns></returns>
        public Bitmap GenerateDrawnValues(string[] values, int imageWidth, int imageHeight)
        {
            Bitmap DrawArea = new Bitmap(imageWidth, imageHeight);
            Graphics g = Graphics.FromImage(DrawArea);

            // Largeur du tableau fixe à 16
            int valuesX = 16;

            // Hauteur du tableau: si plus grand que 16 (càd une ligne), divisé par 16
            int valuesY = values.Length > 16 ? values.Length / 16 : 1;

            // Largeur et hauteur des rectangles
            int width = imageWidth / valuesX;
            int height = imageHeight / valuesY;

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
            return DrawArea;
        }
    }
}
