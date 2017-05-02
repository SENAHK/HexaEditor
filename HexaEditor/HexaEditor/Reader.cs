using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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

        //Modifications apportées au fichier
        private Stack<string> _states;
        private Stack<string> States
        {
            get { return _states; }
            set { _states = value; }
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

        private bool _isEmpty;
        public bool IsEmpty
        {
            get { return _isEmpty; }
            set { _isEmpty = value; }
        }

        ///  CONSTRUCTOR & CONSTRUCTION RELATED FUNCTIONS  \\\        
        public Reader(string paramPath)
        {
            this.Path = paramPath;
            if (readData())
            {
                this.IsEmpty = false;
                this.InfoFile = new FileInfo(paramPath);
                this.OpenDate = DateTime.Now.ToString();
            }
            else
            {
                this.IsEmpty = true;
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

                    // Si le fichier est vide
                    if (this.Length == 0)
                        return false;

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
        /// <summary>
        /// PAS TESTE
        /// Réecris les informations dans le fichier ouvert, en se basant sur la variable data
        /// </summary>
        public void writeData()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(this.InfoFile.FullName, FileMode.Truncate)))
            {
                writer.Write(this.Data);
            }
        }
        /// <summary>
        /// PAS TESTE
        /// Met a jour une parcelle de data, correspondant dans la vue à une page
        /// </summary>
        /// <param name="values">tableau contenant les valeur de la page présente sur la form</param>
        /// <param name="startID">Index correspondant à la première entrée de value dans la référence Data</param>
        public void updatePseudoPage(byte[] values, ulong startID)
        {
            ulong length = startID + (ulong)values.Length;
            int count = 0;
            for (ulong i = startID; i < length; i++)
            {
                this.Data[i] = values[count];
                count++;
            }
        }

        /// FILE INFO FUNCTIONS \\\
        //Donne la date et l'heure de la dernière écriture dans le fichier
        public string getLastModDate()
        {
            return InfoFile.LastWriteTime.ToString();
        }

        public string getLastAccess()
        {
            return InfoFile.LastAccessTime.ToString();
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

        public string getFileLength()
        {
            return InfoFile.Length.ToString();
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
        public char hexaWrite(int value)
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

        public byte GetValue(ulong offset)
        {
            return Data[offset];
        }

        /// UNDO FUNCTIONS \\\
        
        /// <summary>
        /// Rétabli la dernière valeur modifiée si celle ci existe dans le tableau des modifications
        /// </summary>
        /// <returns>
        /// la page de la modification si elle existe
        /// 0 si aucune modification n'est enregistrée
        /// </returns>
        public ulong previousState()
        {
            if (this.States.Count > 0)
            {
                string stateCode = States.Pop();
                byte stateValue = Convert.ToByte(stateCode[0]);
                char[] tmpID = new char[stateCode.Length - 1];
                Array.Copy(stateCode.ToCharArray(), 1, tmpID, 0, stateCode.Length - 1);
                ulong stateID = (ulong)Convert.ToInt64(new string(tmpID));

                Data[stateID] = stateValue;

                return stateID;
            }
            else
            {
                return 0;
            }
            
        }
        public void addStates(Stack<string> s)
        {
            string[] externalStates = s.ToArray();
            Array.Reverse(externalStates);
            foreach (string item in externalStates)
            {
                this.States.Push(item);
            }
        }
    }
}
