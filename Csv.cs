using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Ekml
{
    class Csv
    {
        private string filePath = string.Empty;
        private int ColCount, lineCount;
        public List<string> ColList = new List<string>();
        public List<string> ValList = new List<string>();
      
        public string Path
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public void LoadFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Csv files (*.csv)|*.csv|All files (*.*)|*.*";
            open.Title = "Csv files";

            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
            }

            open.Dispose();
        }

        public void ReadCSV()
        {

            lineCount = File.ReadAllLines(filePath).Length;
            Console.WriteLine("numero de lineas {0}", lineCount);
            /*
            using (var reader = File.OpenText(filePath))
            {
                while (reader.ReadLine() != null)

                {

                    linCount++;
                }
            }
            */

            Console.WriteLine("numero de lineas: {0}", lineCount);

        }

        public void ReadColumn()
        {

            using (TextFieldParser csvParser = new TextFieldParser(filePath))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                string[] fields = csvParser.ReadFields(); //le la columna

                foreach (string element in fields)
                {
                    ColList.Add(element);
                }
            }
        }

        public void ReadValues( )
        {

            using (TextFieldParser csvParser = new TextFieldParser(filePath))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();
           
                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    string Name = fields[0];
                    string Address = fields[1];

                    MessageBox.Show(Name + " "+Address);
                }

            }
        }
    }
}
