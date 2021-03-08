using Net.SourceForge.Koogra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Net.SourceForge.Koogra.Excel2007;
namespace Locations
{
    public partial class frmDonus : Form
    {
        public List<string> addlist = new List<string>();
        public frmDonus()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult rsl = openFileDialog1.ShowDialog();
            if (rsl == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    IWorkbook workbook;
                    IWorksheet sheet;
                    uint lastRow;
                    workbook = new Excel.Workbook(file);
                    sheet = workbook.Worksheets.GetWorksheetByIndex(0);
                    lastRow = sheet.LastRow;
                    for (uint i = 1; i <= lastRow; i++)
                    {
                        IRow row = sheet.Rows.GetRow(i);
                        AddressList element = new AddressList();
                        element.address = GetCellValue(row, 0).ToUpper().Replace("İ", "I");
                        element.name = GetCellValue(row, 1).ToUpper().Replace("İ", "I");
                        element.gsm = GetCellValue(row, 2).ToUpper().Replace("İ", "I");
                        Form1.returnlst.Add(element);
                        addlist.Add(element.address);
                    }
                }
                catch (IOException)
                {
                }
            }
            listBox1.DataSource = addlist;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Form1.returnAddress = addlist;
            this.Close();
        }
        public string GetCellValue(IRow cells, uint column)
        {
            if (cells != null && cells.GetCell(column) != null)
            {
                object value = cells.GetCell(column).Value;
                if (value != null)
                {
                    return value.ToString().Trim();
                }
            }
            return string.Empty;
        }
    }
}
