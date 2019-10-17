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
       

        public string FileRead
        {
            get { return fileRead; }
            set { fileRead = value; }
        }

        public string FileWrite
        {
            get { return fileWrite; }
            set { fileWrite = value; }
        }

        
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
        public virtual void Write(string lineInput, object arg0)
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
                    sw.WriteLine(lineInput, arg0, arg1);
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
                    sw.WriteLine(lineInput, arg0, arg1, arg2);
                    sw.Close();
                }
            }

        }
        //Create a kml file
        public void Create(string fileName)
        {
            FileWrite = $"{fileName}.kml";
            FileInfo fileKML = new FileInfo(fileWrite);

            if (fileKML.Exists) { fileKML.Delete(); }
            // Create a file
            using (StreamWriter sw = fileKML.CreateText()) { sw.Close(); }

        }

        //Create a PlaceMark
        public void PlaceMark(int source, int lat, int lon, List<string> data, string[] ranges)
        {
            Plotter Point = new Plotter();

            using (TextFieldParser csvParser = new TextFieldParser(fileRead))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;
                Console.WriteLine("archivo de lectura: {0}", fileRead);
                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] Values = csvParser.ReadFields();
                    Console.WriteLine("valor {0} de referencia : {1}", source, Values[source]);
                    Write("  <Placemark>");
                    Write("      <name>{0}</name>", Values[source]);

                    if (Point.CompareRange(ranges[0], ranges[1], Values[source]))
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range0");
                        Console.WriteLine("archivo de lectura: {0}", "Range0");
                    }
                    else if (Point.CompareRange(ranges[2], ranges[3], Values[source]))
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range1");
                        Console.WriteLine("archivo de lectura: {0}", "Range1");
                    }
                    else if (Point.CompareRange(ranges[4], ranges[5], Values[source]))
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range2");
                        Console.WriteLine("archivo de lectura: {0}", "Range2");
                    }
                    else if (Point.CompareRange(ranges[6], ranges[7], Values[source]))
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range3");
                        Console.WriteLine("archivo de lectura: {0}", "Range3");
                    }
                    else 
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range4");
                        Console.WriteLine("archivo de lectura: {0}", "Range4");

                    }

                    Write("      <ExtendedData>");

                    for (int i = 0; i < data.Count; i++)
                    {
                        Write("         <Data name='{0}'>{1}</Data>", data[i], Values[i]);
                    }

                    Write("      </ExtendedData>");
                    Write("      <Point>");
                    Write("          <coordinates>{0},{1},{2}</coordinates>", Values[lon], Values[lat], 10);
                    Write("      </Point>");
                    Write("  </Placemark>");
                }
            }
        }
        //
        //Create a StyleRange
        //
        public void StyleRange(string range, object color, object scale)
        {
            Write("  <Style id='{0}'>", range);
            Write("      <IconStyle>");
            Write("          <color>{0}</color>", color);
            Write("          <scale>{0}</scale>", scale);
            Write("          <Icon>");
            Write("              <href>files/white_circle.png</href>");
            Write("          </Icon>");
            Write("       </IconStyle>");
            Write("  </Style>");
        }

        public void Header(string name)
        {
            Write("<?xml version='1.1' encoding='UTF-8'?>");
            Write("<kml xmlns='http://www.opengis.net/kml/2.2' xmlns:gx='http://www.google.com/kml/ext/2.2' xmlns:kml='http://www.opengis.net/kml/2.2' xmlns:atom='http://www.w3.org/2005/Atom'>");
            Write("<Document>");
            Write("<name>{0}</name>", name);
        }
        public void End()
        {
            Write("</Document>");
            Write("</kml>");
        }

        public void imprimir(string[] name)
        {
            MessageBox.Show(name[0]);
  
        }
    }
}

