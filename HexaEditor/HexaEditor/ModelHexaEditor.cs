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

        public void WriteInPictureBox(PictureBox pbx, string[,] values)
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
    }
}
