using Sigrain.Classes;
using Sigran.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigran.Forms
{
    public partial class SampleForm : Form
    {
        public string DatabaseFile = null;

        public SampleForm()
        {
            InitializeComponent();

            dateTimePickerData.CustomFormat = "dd/MM/yyyy";
            dateTimePickerData.Format = DateTimePickerFormat.Custom;

            this.AcceptButton = buttonSave;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.labelWeight.Text = this.dataGridView1.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Pesos"].Value.ToString().Replace(".", ","))).ToString("N2");
            }
            catch
            {
                MessageBox.Show("Erro no formato dos dados.\nVerifique se todos os campos estão preenchidos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            //Constroi o objeto
            Sample sample = new Sample();
            sample.Name = textBoxName.Text;
            sample.Category = comboBoxCategory.Text;
            sample.Description = textBoxDescription.Text;
            sample.Date = dateTimePickerData.Text;

            sample.Carbonates = numericUpDownCarbonates.Value;
            sample.Latitude = numericUpDownLatitude.Value;
            sample.Longitude = numericUpDownLongitude.Value;

            sample.Weight0 = Convert.ToDecimal(dataGridView1.Rows[0].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight1 = Convert.ToDecimal(dataGridView1.Rows[1].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight2 = Convert.ToDecimal(dataGridView1.Rows[2].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight3 = Convert.ToDecimal(dataGridView1.Rows[3].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight4 = Convert.ToDecimal(dataGridView1.Rows[4].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight5 = Convert.ToDecimal(dataGridView1.Rows[5].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight6 = Convert.ToDecimal(dataGridView1.Rows[6].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight7 = Convert.ToDecimal(dataGridView1.Rows[7].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight8 = Convert.ToDecimal(dataGridView1.Rows[8].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight9 = Convert.ToDecimal(dataGridView1.Rows[9].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight10 = Convert.ToDecimal(dataGridView1.Rows[10].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight11 = Convert.ToDecimal(dataGridView1.Rows[11].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight12 = Convert.ToDecimal(dataGridView1.Rows[12].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight13 = Convert.ToDecimal(dataGridView1.Rows[13].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight14 = Convert.ToDecimal(dataGridView1.Rows[14].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight15 = Convert.ToDecimal(dataGridView1.Rows[15].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight16 = Convert.ToDecimal(dataGridView1.Rows[16].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight17 = Convert.ToDecimal(dataGridView1.Rows[17].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight18 = Convert.ToDecimal(dataGridView1.Rows[18].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight19 = Convert.ToDecimal(dataGridView1.Rows[19].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight20 = Convert.ToDecimal(dataGridView1.Rows[20].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight21 = Convert.ToDecimal(dataGridView1.Rows[21].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight22 = Convert.ToDecimal(dataGridView1.Rows[22].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight23 = Convert.ToDecimal(dataGridView1.Rows[23].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight24 = Convert.ToDecimal(dataGridView1.Rows[24].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Weight25 = Convert.ToDecimal(dataGridView1.Rows[25].Cells["Pesos"].Value.ToString().Replace(".", ","));

            if(buttonSave.Text == "Editar")
            {
                //Edita dados no banco de dados
                DatabaseConnect database = new DatabaseConnect(DatabaseFile);
                database.EditRow(sample, "Samples", textBoxId.Text);

                //Atualiza a tabela da área de trabalho
                MainForm form = (MainForm)this.Owner;
                form.updateDataGrid(null, null, null, true);

                //Limpa a janela atual
                this.Close();
            }
            else
            {
                //Insere dados no banco de dados
                DatabaseConnect database = new DatabaseConnect(DatabaseFile);
                database.Insert(sample, "Samples");

                //Atualiza a tabela da área de trabalho
                MainForm form = (MainForm)this.Owner;
                form.updateDataGrid(null, null, null, true);

                MainForm mainForm = new MainForm();
                IniFile ini = new IniFile(mainForm.SettingsFile);
                if (ini.Read("FORMINSERTOPEN") == "1")
                {
                    textBoxName.Text = "";
                    Clear();
                }
                else
                {
                    //Limpa a janela atual
                    this.Close();
                }
            }
        }

        private void SampleForm_Load(object sender, EventArgs e)
        {

            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                if(dataGridView1.Rows[j].Cells[1].Value.Equals("0"))
                    dataGridView1.Rows[j].Cells[1].Value = "0.000";
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteClipboard();
        }

        private void PasteClipboard()
        {
            try
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int iFail = 0, iRow = dataGridView1.CurrentCell.RowIndex;
                int iCol = dataGridView1.CurrentCell.ColumnIndex;
                DataGridViewCell oCell;
                foreach (string line in lines)
                {
                    if (iRow < dataGridView1.RowCount && line.Length > 0)
                    {
                        string[] sCells = line.Split('\t');
                        for (int i = 0; i < sCells.GetLength(0); ++i)
                        {
                            if (iCol + i < this.dataGridView1.ColumnCount)
                            {
                                oCell = dataGridView1[iCol + i, iRow];
                                if (!oCell.ReadOnly)
                                {
                                    if (oCell.Value.ToString() != sCells[i])
                                    {
                                        oCell.Value = Convert.ChangeType(sCells[i], oCell.ValueType);
                                        oCell.Style.BackColor = Color.LightSkyBlue;
                                    }
                                    else
                                        iFail++;//only traps a fail if the data has changed and you are pasting into a read only cell
                                }
                            }
                            else
                            { break; }
                        }
                        iRow++;
                    }
                    else
                    { break; }
                    if (iFail > 0)
                        MessageBox.Show(string.Format("{0} updates failed due to read only column setting", iFail));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The data you pasted is in the wrong format for the cell");
                return;
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyClipboard();
        }

        private void CopyClipboard()
        {
            DataObject d = dataGridView1.GetClipboardContent();
            Clipboard.SetDataObject(d);
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (i > 0)
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        dataGridView1.Rows[j].Cells[i].Value = "0.000";
                    }
                }
            }
        }
    }
}
