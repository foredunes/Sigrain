using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigran.Classes
{
    static class Exports
    {
        public static void ToExcel(DataGridView DGV, string FileName, bool showHeader = false)
        {
            /*// Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = 0; i < DGV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DGV.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1 && showHeader)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DGV.Columns[j].HeaderText;
                        }
                        if (showHeader)
                        {
                            if (cellRowIndex != 1)
                            {
                                worksheet.Cells[cellRowIndex, cellColumnIndex] = DGV.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        else
                        {
                            if (cellRowIndex != 1)
                            {
                                worksheet.Cells[cellRowIndex - 1, cellColumnIndex] = DGV.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }
                workbook.SaveAs(FileName);

                MessageBox.Show("Arquivo Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }*/

        }

        public static void ToCSV(DataGridView DGV, string FileName, bool showHeader = false)
        {
            string value = "";
            DataGridViewRow dr = new DataGridViewRow();
            StreamWriter swOut = new StreamWriter(FileName);

            if (showHeader)
            {
                for (int i = 0; i <= DGV.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(";");
                    }
                    swOut.Write(DGV.Columns[i].HeaderText);
                }

                swOut.WriteLine();
            }

            for (int j = 0; j <= DGV.Rows.Count - 1; j++)
            {
                if (j > 0)
                {
                    swOut.WriteLine();
                }

                dr = DGV.Rows[j];

                for (int i = 0; i <= DGV.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(";");
                    }

                    value = dr.Cells[i].Value.ToString();
                    value = value.Replace(',', '.');
                    value = value.Replace(Environment.NewLine, " ");

                    swOut.Write(value);
                }
            }
            swOut.Close();
            MessageBox.Show("Arquivo Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ToTxt(DataGridView DGV, string FileName, bool showHeader = false)
        {
            if (DGV.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(FileName);

                if (showHeader)
                {
                    for (int i = 0; i <= DGV.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(";");
                        }
                        swOut.Write(DGV.Columns[i].HeaderText);
                    }

                    swOut.WriteLine();
                }

                for (int j = 0; j <= DGV.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = DGV.Rows[j];

                    for (int i = 0; i <= DGV.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(";");
                        }

                        value = dr.Cells[i].Value.ToString();
                        value = value.Replace(',', '.');
                        value = value.Replace(Environment.NewLine, " ");

                        swOut.Write(value);
                    }
                }
                swOut.Close();
                MessageBox.Show("Arquivo Salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void DatagridToFile(DataGridView DGV, bool showHeader = false)
        {
            //Getting the location and file name of the excel to save from user.
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo de texto (*.txt)|*.txt|Texto Separado por vírgula (*.csv)|*.csv";
            //saveDialog.Filter = "All files (*.*)|*.*|Arquivo do Excel (*.xlsx)|*.xlsx|Texto Separado por vírgula (*.csv)|*.csv|Arquivo de texto (*.txt)|*.txt";
            saveDialog.FilterIndex = 2;

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(saveDialog.FileName))
                {
                    try
                    {
                        File.Delete(saveDialog.FileName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Você não tem permissão para substituir o arquivo." + ex.Message);
                    }
                }
                if (saveDialog.FileName.Contains(".xlsx"))
                {
                    ToExcel(DGV, saveDialog.FileName, showHeader);
                }
                if (saveDialog.FileName.Contains(".csv"))
                {
                    ToCSV(DGV, saveDialog.FileName, showHeader);
                }
                if (saveDialog.FileName.Contains(".txt"))
                {
                    ToTxt(DGV, saveDialog.FileName, showHeader);
                }
            }
        }
    }
}
