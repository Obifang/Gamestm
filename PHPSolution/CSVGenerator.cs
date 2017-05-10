using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PHPSolution
{
    class CSVGenerator
    {
        private string _FilePath;
        private string _FileFolder;

        public CSVGenerator()
        {
            _FilePath = "";
            _FileFolder = @"Data\";
        }

        //Creates a CSVFile with the given filename
        public void NewCSVFile (string FileName)
        {
            //Sets the file path
            _FilePath = _FileFolder + FileName + ".csv";

            if (!Directory.Exists(_FileFolder))
            {
                Directory.CreateDirectory(_FileFolder);
            }

            //Checks if the file already exists
            if (File.Exists(_FilePath))
            {
                //Increment
                int i = 0;
                //Checks if the file exists if it does it adds a number to it
                while (File.Exists(_FilePath))
                {
                    //Increments a number until new file can be created
                    _FilePath = _FileFolder + FileName + i++ + ".csv";
                }
                
            }

            //Create File
            FileStream file = File.Create(_FilePath);
            //Close File
            file.Close();
        }

        public bool WriteToFile (string[] [] DataToWrite)
        {
            string delimiter = ",";

            if (File.Exists(_FilePath))
            {
                int length = DataToWrite.GetLength(0);
                StringBuilder buildString = new StringBuilder();

                using (StreamWriter file = new StreamWriter(_FilePath, true))
                {
                    for (int i = 0; i < length; i++)
                    {
                        buildString.AppendLine(string.Join(delimiter, DataToWrite[i]));
                    }

                    file.Write(buildString.ToString());
                    file.Close();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetFilePath
        {
            get
            {
                return _FilePath;
            }
        }

        public string GetSetFileFolder
        {
            get
            {
                return _FileFolder;
            }

            set
            {
                _FileFolder = value;
            }
        }
    }
}
