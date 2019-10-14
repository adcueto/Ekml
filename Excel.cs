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
        
        private ExcelFile.Application xlApp;
        private ExcelFile.Workbook xlWorkBook;
        private ExcelFile.Worksheet xlWorkSheet;
        private ExcelFile.Range xlRange;
        

        private string filePath = string.Empty;

        public string Path
        {
            get { return filePath;  }
            set { filePath = value; }
        }

        public void LoadFile()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            open.Title = "Excel files";

            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
            }
        }
        public void ReadSheet(string sheet)
        {

            xlApp = new ExcelFile.Application();
            xlWorkBook = xlApp.Workbooks.Open(filePath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = xlWorkBook.Worksheets[sheet];
            xlRange = xlWorkSheet.UsedRange;
   
        }

    }
}

