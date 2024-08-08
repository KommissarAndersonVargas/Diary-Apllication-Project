using ClosedXML.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Application_Project
{
    public partial class OpenExcel : Form
    {
        public OpenExcel()
        {
            InitializeComponent();
        }

        private void OpenExcel_Load(object sender, EventArgs e)
        {
            // Process.Start(@"C:\Users\Usuario\OneDrive\Documentos\Images & Testes");
            btnAbrirPlanilha_Click();
        }
        private void btnAbrirPlanilha_Click()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx|Todos os arquivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1); // Primeira planilha

                    DataTable dataTable = new DataTable();
                    foreach (var firstRowCell in worksheet.FirstRow().Cells())
                    {
                        dataTable.Columns.Add(firstRowCell.Value.ToString());
                    }

                    foreach (var row in worksheet.RowsUsed().Skip(1))
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < row.Cells().Count(); i++)
                        {
                            dataRow[i] = row.Cell(i + 1).Value.ToString();
                        }
                        dataTable.Rows.Add(dataRow);
                    }

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
