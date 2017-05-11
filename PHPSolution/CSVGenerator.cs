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
        //File path
        private string _FilePath;
        //Folder used to create File Path
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

        //Function for writing data to file
        public bool WriteToFile (string[] [] DataToWrite)
        {
            //Delimiter ','  represents the seperation of elements in a csv
            string delimiter = ",";

            //Checks whether file exists to write to
            if (File.Exists(_FilePath))
            {
                //Checks the length of the data to write
                int length = DataToWrite.GetLength(0);
                //Creates a string builder to work in delimiter
                StringBuilder buildString = new StringBuilder();

                buildString.AppendLine("sep=,");

                //Opens file to begin writing data
                using (StreamWriter file = new StreamWriter(_FilePath, true))
                {
                    //Loops through all the indexes to add a delimiter and build a string
                    for (int i = 0; i < length; i++)
                    {
                        buildString.AppendLine(string.Join(delimiter, DataToWrite[i]));
                    }

                    //Writes the string that was built to file
                    file.Write(buildString.ToString());
                    //Closes the file
                    file.Close();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        //Getter for _FilePath
        public string GetFilePath
        {
            get
            {
                return _FilePath;
            }
        }

        //Getter and Setter for File Folder
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
