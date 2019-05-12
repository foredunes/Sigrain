using Sisgrain.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisgrain.Forms
{
    public partial class SampleForm : Form
    {
        public string DatabaseFile = null;

        public SampleForm()
        {
            InitializeComponent();

            dateTimePickerData.CustomFormat = "dd/MM/yyyy";
            dateTimePickerData.Format = DateTimePickerFormat.Custom;

            this.AcceptButton = buttonSalvar;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.labelPeso.Text = this.dataGridView1.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells["Pesos"].Value.ToString().Replace(".", ","))).ToString("N2");
            }
            catch
            {
                MessageBox.Show("Erro no formato dos dados.\nVerifique se todos os campos estão preenchidos corretamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCanelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            //Constroi o objeto
            Sample sample = new Sample();
            sample.Amostra = textBoxAmostra.Text;
            sample.Categoria = comboBoxCategoria.Text;
            sample.Descricao = textBoxDescricao.Text;
            sample.Data = dateTimePickerData.Text;

            sample.Carbonatos = numericUpDownCarbonato.Value;
            sample.Latitude = numericUpDownLatitude.Value;
            sample.Longitude = numericUpDownLongitude.Value;

            sample.Peso0 = Convert.ToDecimal(dataGridView1.Rows[0].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso1 = Convert.ToDecimal(dataGridView1.Rows[1].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso2 = Convert.ToDecimal(dataGridView1.Rows[2].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso3 = Convert.ToDecimal(dataGridView1.Rows[3].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso4 = Convert.ToDecimal(dataGridView1.Rows[4].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso5 = Convert.ToDecimal(dataGridView1.Rows[5].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso6 = Convert.ToDecimal(dataGridView1.Rows[6].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso7 = Convert.ToDecimal(dataGridView1.Rows[7].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso8 = Convert.ToDecimal(dataGridView1.Rows[8].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso9 = Convert.ToDecimal(dataGridView1.Rows[9].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso10 = Convert.ToDecimal(dataGridView1.Rows[10].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso11 = Convert.ToDecimal(dataGridView1.Rows[11].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso12 = Convert.ToDecimal(dataGridView1.Rows[12].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso13 = Convert.ToDecimal(dataGridView1.Rows[13].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso14 = Convert.ToDecimal(dataGridView1.Rows[14].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso15 = Convert.ToDecimal(dataGridView1.Rows[15].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso16 = Convert.ToDecimal(dataGridView1.Rows[16].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso17 = Convert.ToDecimal(dataGridView1.Rows[17].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso18 = Convert.ToDecimal(dataGridView1.Rows[18].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso19 = Convert.ToDecimal(dataGridView1.Rows[19].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso20 = Convert.ToDecimal(dataGridView1.Rows[20].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso21 = Convert.ToDecimal(dataGridView1.Rows[21].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso22 = Convert.ToDecimal(dataGridView1.Rows[22].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso23 = Convert.ToDecimal(dataGridView1.Rows[23].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso24 = Convert.ToDecimal(dataGridView1.Rows[24].Cells["Pesos"].Value.ToString().Replace(".", ","));
            sample.Peso25 = Convert.ToDecimal(dataGridView1.Rows[25].Cells["Pesos"].Value.ToString().Replace(".", ","));

            if(buttonSalvar.Text == "Editar")
            {
                //Edita dados no banco de dados
                DatabaseConnect database = new DatabaseConnect(DatabaseFile);
                database.EditRow(sample, "Amostras", textBoxId.Text);
            }
            else
            {
                //Insere dados no banco de dados
                DatabaseConnect database = new DatabaseConnect(DatabaseFile);
                database.Insert(sample, "Amostras");
            }

            //Atualiza a tabela da área de trabalho
            MainForm form = (MainForm)this.Owner;
            form.updateDataGrid(null, true);

            //Limpa a janela atual
            this.Close();
        }

        private void SampleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
