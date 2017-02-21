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

        /// CONVERTING FUNCTIONS \\\
        
        /// <summary>
        /// Retourne la valeur d'un entier non signé de 8 bit
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getByte(ulong position)
        {
            return fileReader.GetValue(position).ToString();
        }

        /// <summary>
        /// Retourne la valeur d'un entier signé de 8 bits
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getSByte(ulong position)
        {
            return ((sbyte)fileReader.GetValue(position)).ToString();
        }
        /// <summary>
        /// Retourne la valeur d'un entier non signé de 16 bits
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getInt16(ulong position)
        {
            string binary = Convert.ToString(fileReader.GetValue(position), 2).PadLeft(8, '0');
            string binary16 = binary + "00000000";
            return (Convert.ToUInt16(binary16, 2)).ToString();
        }
        /// <summary>
        /// Retourne la valeur d'un entier non signé de 16 bits
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getUint16(ulong position)
        {
            string binary = Convert.ToString(fileReader.GetValue(position), 2).PadLeft(8, '0');
            string binary16 = binary + "00000000";
            return (Convert.ToUInt16(binary16, 2)).ToString();
        }

        /// <summary>
        /// Retourne la valeur d'un entier signé de 23 bits
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getInt32(ulong position)
        {
            string binary = Convert.ToString(fileReader.GetValue(position), 2).PadLeft(8, '0');
            string binary32 = binary + "00000000" + "00000000" + "00000000";
            return (Convert.ToInt32(binary32, 2)).ToString();
        }
        /// <summary>
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
                            output = values[(y - 1) * 16 + x - 1];
                        }
                    }

                    Rectangle rect = new Rectangle(x * width, y * height, width * 2, height * 2);
                    // Afficher les éléments du tableau dans une surface de dessin
                    Brush brush = x == 0 || y == 0 ? Brushes.Blue : Brushes.Black;
                    g.DrawString(output, new Font("Courier New", 8), brush, rect);
                }
            }
            return DrawArea;
        /// Retourne la valeur d'un entier signé de 64 bits
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getInt64(ulong position)
        {
            return ((long)(fileReader.GetValue(position) * 72057594037927936)).ToString();
        }
        /// <summary>
        /// Retourne la valeur binaire
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getBinary(ulong position)
        {
            return Convert.ToString(fileReader.GetValue(position), 2).PadLeft(8, '0');
        }
        /// <summary>
        /// Retourne la valeur d'un décimal sur 32 bits
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getFloat(ulong position)
        {
            return string.Empty;
        }
        /// <summary>
        /// Retourne la valeur d'un décimal sur 64 bits
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getDouble(ulong position)
        {
            return string.Empty;
        }
        /// <summary>
        /// Retourne le caractère correspondant au code ASCII donnéS
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public char getASCII(ulong position)
        {
            return (char)fileReader.GetValue(position);
        }

        public Bitmap generateDrawnValuesAsAscii(string[] values, int imageWidth, int imageHeight)
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
                    
                        // Valeurs à afficher
                        int key = y * 16 + x;
                        UInt32 val = Convert.ToUInt32(values[key][0]) + Convert.ToUInt32(values[key][1]);
                        char c = (val == 0) ? '.' : Convert.ToChar(val);
                        output = c.ToString();
                    

                    Rectangle rect = new Rectangle(x * width, y * height, width * 2, height * 2);
                    // Afficher les éléments du tableau dans une surface de dessin
                    g.DrawString(output, new Font("Courier New", 8), Brushes.Black, rect);
                }
            }
            return DrawArea;
        }
    }
}
