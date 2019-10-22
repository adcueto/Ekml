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
            

        public string Color { get; set; }
        public string Scale { get; set; }
        public string Opacity { get; set; }
        public string Name { get; set; }
        public string PointName { get; set; }
        public bool PointNameDisable { get; set; }
        public string KmlFilePath { get; set; }
        public string CsvFilePath { get; set; }
        public string PointIcon { get; set; }
        public Kml()
        {
            KmlFilePath = string.Empty;
            CsvFilePath = string.Empty;

        }

        public virtual void Write(string lineInput)
        {

            FileInfo fi = new FileInfo(KmlFilePath);
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

            FileInfo fi = new FileInfo(KmlFilePath);
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

            FileInfo fi = new FileInfo(KmlFilePath);
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

            FileInfo fi = new FileInfo(KmlFilePath);
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
        public void Create()
        {
            KmlFilePath = $"{Name}.kml";
            FileInfo KmlFile = new FileInfo(KmlFilePath);

            if (KmlFile.Exists) { KmlFile.Delete(); }
            // Create a file
            using (StreamWriter sw = KmlFile.CreateText()) { sw.Close(); }

        }

        //Create a PlaceMark
        public void PlaceMark(int dataIndex, int latIndex, int lonIndex, List<string> colData, string[] rngValues)
        {
            Point PointKml = new Point();

            using (TextFieldParser CsvParser = new TextFieldParser(CsvFilePath))
            {
                CsvParser.CommentTokens = new string[] { "#" };
                CsvParser.SetDelimiters(new string[] { "," });
                CsvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                CsvParser.ReadLine();

                while (!CsvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] Values = CsvParser.ReadFields();

                    Write("  <Placemark>");
                    if (PointNameDisable)
                    {
                        Write("      <name>{0}</name>", Values[dataIndex]);
                    }
                    else
                    {
                        Write("      <name>{0}</name>", null);
                    }

                    // Evaluate the ranges of the point.
                    if (PointKml.Between(rngValues[0], rngValues[1], Values[dataIndex]))
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range0");
                    }
                    else if (PointKml.Between(rngValues[2], rngValues[3], Values[dataIndex]))
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range1");
                    }
                    else if (PointKml.Between(rngValues[4], rngValues[5], Values[dataIndex]))
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range2");
                    }
                    else if (PointKml.Between(rngValues[6], rngValues[7], Values[dataIndex]))
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range3");
                    }
                    else 
                    {
                        Write("      <styleUrl>#{0}</styleUrl>", "Range4");
                    }

                    Write("      <ExtendedData>");

                    for (int i = 0; i < colData.Count; i++)
                    {
                        Write("         <Data name='{0}'>{1}</Data>", colData[i], Values[i]);
                    }

                    Write("      </ExtendedData>");
                    Write("      <Point>");
                    Write("          <coordinates>{0},{1},{2}</coordinates>", Values[lonIndex], Values[latIndex], 10);
                    Write("      </Point>");
                    Write("  </Placemark>");
                }
            }
        }
        //
        //Create a StyleRange
        //
        public void StyleRange(string rngName, string rgbColor)
        {
            Color = Opacity + rgbColor;

            Write("  <Style id='{0}'>", rngName);
            Write("      <IconStyle>");
            Write("          <color>{0}</color>", Color);
            Write("          <scale>{0}</scale>", Scale);
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
            Write("<name>{0}</name>", Name);
        }
        public void End()
        {
            Write("</Document>");
            Write("</kml>");
        }

    }
}

