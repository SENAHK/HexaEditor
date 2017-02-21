using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HexaEditor
{
    public class Reader
    {
        /// PARAM  \\


        //Bytes contenu dans le ficher
        private byte[] _data;
        public byte[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        //Classe permettant d'accéder à tout les détails du fichier
        private FileInfo _infoFile;
        public FileInfo InfoFile
        {
            get { return _infoFile; }
            set { _infoFile = value; }
        }

        //Longueur en byte du fichier
        private ulong _length;
        public ulong Length
        {
            get { return _length; }
            set { _length = value; }
        }

        //Date et heure d'ouverture du fichier par le programme
        private string _openDate;
        public string OpenDate
        {
            get { return _openDate; }
            set { _openDate = value; }
        }

        //Adresse complète du fichier
        private string _path;
        private string Path
        {
            get { return _path; }
            set { _path = value; }
        }




        ///  CONSTRUCTOR & CONSTRUCTION RELATED FUNCTIONS  \\\


        public Reader(string paramPath)
        {
            this.Path = paramPath;
            if (readData())
            {
                this.InfoFile = new FileInfo(paramPath);
                this.OpenDate = DateTime.Now.ToString();
            }
        }

        /// <summary>
        /// Lis le contenu du fichier inidiqué par le paramètre Path. Les valeurs sont stoquées dans Data
        /// La fonction retourne un booléen en fonction de le réussite de la lecture.
        /// </summary>
        private bool readData()
        {
            try
            {
                using (BinaryReader b = new BinaryReader(File.Open(this.Path, FileMode.Open)))
                {
                    byte v;
                    int pos = 0;
                    this.Length = (ulong)b.BaseStream.Length;
                    this.Data = new byte[this.Length];
                    while ((ulong)pos < this.Length)
                    {
                        v = b.ReadByte();
                        this.Data[pos] = v;
                        pos += sizeof(byte);
                    }
                    b.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        /// FILE INFO FUNCTIONS \\\


        //Donne la date et l'heure de la dernière écriture dans le fichier
        public string getLastModDate()
        {
            return InfoFile.LastWriteTime.ToString();
        }

        //Donne la date de création du fichier
        public string getCreationDate()
        {
            return InfoFile.CreationTime.ToString();
        }

        //Donne le nom du fichier et son extention, sans son chemin d'accès
        public string getShortName()
        {
            return InfoFile.Name;
        }



        ///  DATA CONVERTING FUNCTIONS  \\\

        //Retourne la valeur de l'ofset donné en hexadécimal
        public string getHexa(ulong offset)
        {
            byte value = Data[offset];
            string hexa = hexaWrite(value / 16).ToString() + hexaWrite(value % 16).ToString();
            return hexa;
        }
        //Convertit une valeur décimale entre 0 et 15 en une valeur hexadécimale 
        private char hexaWrite(int value)
        {
            if (value < 10)
            {
                return Convert.ToChar(value.ToString());
            }
            if (value >= 10 && value < 16)
            {
                return Convert.ToChar(65 + value % 10);
            }
            return '0';
        }
    }
}
