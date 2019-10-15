using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Ekml
{
    class Kml
    {
        private string fileRead = string.Empty;
        private string fileWrite = string.Empty;

        public virtual void Write(string lineInput)
        {

            FileInfo fi = new FileInfo(fileWrite);
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
            
            FileInfo fi = new FileInfo(fileWrite);
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

            FileInfo fi = new FileInfo(fileWrite);
            if (fi.Exists)
            {
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(lineInput, arg0,arg1);
                    sw.Close();
                }
            }

        }

        public virtual void Write(string lineInput, object arg0, object arg1, object arg2)
        {

            FileInfo fi = new FileInfo(fileWrite);
            if (fi.Exists)
            {
                using (StreamWriter sw = fi.AppendText())
                {
                    sw.WriteLine(lineInput, arg0, arg1,arg2);
                    sw.Close();
                }
            }

        }
        //Create a kml file
        public void Create(string fileName)
        {
            fileWrite = $"{fileName}.kml";
            FileInfo fileKML = new FileInfo(fileWrite);

            if (fileKML.Exists){ fileKML.Delete();}
            // Create a file
            using (StreamWriter sw = fileKML.CreateText()){ sw.Close();}

        }

        public void PlaceMark(string range, int source, int lat, int lon, string path, List<string> data)
        {
 
            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();
           
                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] Values = csvParser.ReadFields();
                    Write("  <Placemark>");
                    Write("      <name>{0}</name>", Values[source]);
                    Write("      <styleUrl>#{0}</styleUrl>",range);
                    Write("      <ExtendedData>");

                    for (int i = 0; i < data.Count; i++)
                    {
                    Write("         <Data name='{0}'>{1}</Data>",data[i],Values[i]);
                    }

                    Write("      </ExtendedData>");
                    Write("      <Point>");
                    Write("          <coordinates>{0},{1},{2}</coordinates>", Values[lon], Values[lat], 10);
                    Write("      </Point>");
                    Write("  </Placemark>");
                }
            }
        }


        public void StyleRange(string range,string name, object color,object scale)
        {
            Write("<name>{0}</name>",name);
            Write("  <Style id='{0}'>",range);
            Write("      <IconStyle>");
            Write("          <color>{0}</color>", color);
            Write("          <scale>{0}</scale>", scale);
            Write("          <Icon>");
            Write("              <href>files/white_circle.png</href>");
            Write("          </Icon>");
            Write("       </IconStyle>");
            Write("  </Style>");
        }

        public void Header()
        {
            Write("<?xml version='1.1' encoding='UTF-8'?>");
            Write("<kml xmlns='http://www.opengis.net/kml/2.2' xmlns:gx='http://www.google.com/kml/ext/2.2' xmlns:kml='http://www.opengis.net/kml/2.2' xmlns:atom='http://www.w3.org/2005/Atom'>");
            Write("<Document>");
        }
        public void End()
        {
            Write("</Document>");
            Write("</kml>");


        }

    }
}

