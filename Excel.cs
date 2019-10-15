using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ExcelFile = Microsoft.Office.Interop.Excel;

namespace Ekml
{
    public class Excel
    {
        
        private string filePath = string.Empty;
        private int rw, cl;
        public List<string> ColList = new List<string>();

        public string Path
        {
            get { return filePath;  }
            set { filePath = value; }
        }
        public int Col        {
            get { return cl; }
            set { cl = value; }
        }
        public int Row
        {
            get { return rw; }
            set { rw = value; }
        }

        public void LoadFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            open.Filter = "Excel files (*.csv)|*.csv|All files (*.*)|*.*";
            open.Title = "Excel files";

            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
            }

            open.Dispose();
        }
        public void ReadSheet(string sheet)
        {
            ExcelFile.Application xlApp;
            ExcelFile.Workbook xlWorkBook;
            ExcelFile.Worksheet xlWorkSheet;
            ExcelFile.Range xlRange;
            
            xlApp = new ExcelFile.Application();
            xlWorkBook = xlApp.Workbooks.Open(filePath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = xlWorkBook.Worksheets[sheet];
            xlRange = xlWorkSheet.UsedRange;

            rw = xlRange.Rows.Count;
            cl = xlRange.Columns.Count;

            for (int i=1; i<= cl; i++)
            {
               // MessageBox.Show(xlWorkSheet.Cells[1,i].value);
                ColList.Add(xlWorkSheet.Cells[1, i].value);
            }      
        }

    }
}

