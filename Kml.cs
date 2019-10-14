using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekml
{
    class Kml
    {
        private string filePath = string.Empty;


        public virtual void Write(string lineInput)
        {

            FileInfo fi = new FileInfo(filePath);
            if (fi.Exists)
            {
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(lineInput);
                    sw.Close();
                }
            }

        }
        public virtual void Write(string lineInput,object arg0)
        {
            
            FileInfo fi = new FileInfo(filePath);
            if (fi.Exists)
            {
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(lineInput, arg0);
                    sw.Close();
                }
            }
       
        }

        public virtual void Write(string lineInput, object arg0, object arg1)
        {

            FileInfo fi = new FileInfo(filePath);
            if (fi.Exists)
            {
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(lineInput, arg0,arg1);
                    sw.Close();
                }
            }

        }


        public void Create(string fileName)
        {
            filePath = $"{fileName}.kml";
            FileInfo fi = new FileInfo(filePath);

            if (!fi.Exists)
            {
                // Create a file
                using (StreamWriter sw = fi.CreateText()){ sw.Close(); }
            }
            
        }
    }
}

