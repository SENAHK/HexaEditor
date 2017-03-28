using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexaEditor
{
    public class ModelHexaEditor
    {
        private Reader fileReader; //Contient les données entières du fichier
        private bool isInit; //Indique si le fileReader a été initialisé
        private Dictionary<string, string> fileInfos; //Contient les informations relatives au fichier de référence

        public Dictionary<string, string> FileInfos
        {
            get { return fileInfos; }
            set { fileInfos = value; }
        }
        public bool IsInit
        {
            get { return isInit; }
            set { isInit = value; }
        }

        private ulong page = 0; // Numéro de la page active

        /// <summary>
        /// Page suivante
        /// </summary>
        public void nextPage()
        {
            ulong length = (ulong)Convert.ToInt32(Math.Ceiling(Convert.ToDouble((ulong)fileReader.Data.Length / PAGECAPACITY)));

            if (page < length)
            {
                page++;
            }
        }
        /// <summary>
        /// Page précédente
        /// </summary>
        public void previousPage()
        {
            if (page > 0)
            {
                page--;
            }
        }


        private const ulong PAGECAPACITY = 16 * 32; //Largeur * hauteur
        private List<Rectangle> cases = new List<Rectangle>();
        private List<Rectangle> casesASCII = new List<Rectangle>();

        public List<Rectangle> CasesASCII
        {
            get { return casesASCII; }
            set { casesASCII = value; }
        }
        public List<Rectangle> Cases
        {
            get { return cases; }
            set { cases = value; }
        }

        public ModelHexaEditor()
        {
            this.IsInit = false;
        }

        /// <summary>
        /// Initialise le reader avec une adresse désignée en paramètres
        /// </summary>
        /// <param name="path"></param>
        public void initReader(string path)
        {
            this.fileReader = new Reader(path);
            this.IsInit = true;
            this.fileInfos = new Dictionary<string, string>();
            getFileInfos();
        }

        /// <summary>
        /// Met à jour le dictionaire fileinfo avec les informations du reader
        /// </summary>
        private void getFileInfos()
        {
            this.FileInfos.Add("Name", this.fileReader.getShortName());
            this.FileInfos.Add("CreationDate", this.fileReader.getCreationDate());
            this.FileInfos.Add("ModificationDate", this.fileReader.getLastModDate());
            this.FileInfos.Add("Length", this.fileReader.getFileLength());
            this.FileInfos.Add("LastAccess", this.fileReader.getLastAccess());
        }

        /// <summary>
        /// Donne un tableau du nombre de valeur correspondant à la constante PAGECAPACITY, en fonction de la variable page
        /// </summary>
        /// <returns></returns>
        public string[] getPageContent()
        {
            ulong start = PAGECAPACITY * page;
            ulong stop;
            ulong cap;
            if (start + PAGECAPACITY < fileReader.Length)
            {
                stop = start + PAGECAPACITY;
                cap = PAGECAPACITY;
            }
            else
            {
                stop = fileReader.Length;
                cap = stop - start;
            }
            int count = 0;
            string[] values = new string[cap];

            for (ulong i = start; i < stop; i++)
            {
                values[count] = fileReader.getHexa(i);

                count++;
            }
            MessageBox.Show("values : " + values.Length.ToString());
            return values;
        }
        /// <summary>
        /// DOnne un tableau du nombre de valeur corrrespondant à la constante PAGECAPACITY, au format ASCII
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public string[] getASCIIpage()
        {
            string[] ASCIIpage = new string[PAGECAPACITY];
            ulong start = PAGECAPACITY * page;
            ulong stop;
            if (start + PAGECAPACITY < fileReader.Length)
            {
                stop = start + PAGECAPACITY;
            }
            else
            {
                stop = fileReader.Length;
            }
            int count = 0;


            for (ulong i = start; i < stop; i++)
            {
                char c = this.getASCII(i);
                if (c == (char)0)
                {
                    ASCIIpage[count] = ".";
                }
                else
                {
                    ASCIIpage[count] = c.ToString();
                }

                count++;
            }

            return ASCIIpage;
        }
        /// <summary>
        /// Revoie la page modifiée par l'utilisateur au reader
        /// </summary>
        /// <param name="hexaValues"></param>
        public void setPage(string[] hexaValues)
        {
            byte[] values = new byte[hexaValues.Length];

            //Reconverti chaque valeur hexadécimale en byte
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToByte(Convert.ToInt32(hexaValues[i], 16));
            }

            fileReader.updatePseudoPage(values, PAGECAPACITY * page);
        }
        /// <summary>
        /// Ordonne au reader de sauver son contenu actuel à son emplacement de référence
        /// </summary>
        public void saveFIle()
        {
            this.fileReader.writeData();
        }

        // CONVERTING FUNCTIONS \\

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
            byte[] c = new byte[8];
            c[0] = fileReader.GetValue(position);
            for (int i = 1; i < c.Length; i++)
            {
                c[i] = 0;
            }
            double d = BitConverter.ToDouble(c, 0);
            return d.ToString();
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
        /// <summary>
        /// Retourne en base huit la valeur de l'indexe donné sous forme de string
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public string getOctal(ulong position)
        {
            return Convert.ToString(fileReader.GetValue(position), 8);
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

            // Hauteur du tableau
            int valuesY = 0;
            int colstop = 16;

            // Gestion des lignes qui ne font pas 16 pour les pages qui ne font pas 32 lignes
            if (values.Length < (int)PAGECAPACITY)
            {
                if (values.Length % 16 == 0)
                {
                    valuesY = values.Length / 16;
                    colstop = 16;
                }
                else
                {
                    valuesY = values.Length / 16 + 1;
                    colstop = values.Length % 16;
                }
            }

            // Largeur et hauteur des rectangles
            int width = imageWidth / valuesX;
            int height = imageHeight / 32;

            string output = "";

            for (int y = -1; y < valuesY; y++)
            {
                for (int x = -1; x < valuesX; x++)
                {
                    if (y == valuesY-1 && x == colstop)
                    {
                        break;
                    }
                    // En-tête de colonnes
                    if (y < 0)
                    {
                        if (x < 0)
                            output = "";
                        else
                            output = Convert.ToString(x, 16).ToUpper();
                    }
                    else
                    {
                        // Titres de lignes
                        if (x < 0)
                        {
                            output = Convert.ToString(y + (int)page * 32, 16).ToUpper();
                        }
                        else
                        {
                            // Valeurs à afficher
                            output = values[y * 16 + x];
                        }
                        
                    }

                    Rectangle rect = new Rectangle((x + 1) * width, (y + 1) * height, width, height + 1);

                    if (y >= 0 && x >= 0)
                        this.Cases.Add(rect);

                    // Afficher les éléments du tableau dans une surface de dessin
                    Brush brush = ((x < 0) || (y < 0)) ? Brushes.Blue : Brushes.Black;
                    g.DrawString(output, new Font("Tahoma", 8), brush, rect);
                }
            }
            return DrawArea;
        }
        /// <summary>
        /// Genère le tableau ascii
        /// </summary>
        /// <param name="values">Valeurs à écrire</param>
        /// <param name="imageWidth">largeur</param>
        /// <param name="imageHeight">hauteur</param>
        /// <returns></returns>
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
                    output = values[y * 16 + x];
                    // Valeurs à afficher
                    //int key = y * 16 + x;
                    //char chr = getASCII((ulong)key);
                    //output = (chr != (char)0) ? chr.ToString() : '.'.ToString();

                    Rectangle rect = new Rectangle(x * width, y * height, width, height + 1);
                    this.CasesASCII.Add(rect);
                    // Afficher les éléments du tableau dans une surface de dessin
                    g.DrawString(output, new Font("Courier New", 8), Brushes.Black, rect);
                }
            }
            return DrawArea;
        }
    }
}
