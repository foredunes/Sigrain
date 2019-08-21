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
    public partial class CorrelationOptions : Form
    {
        public MainForm ParentForm { get; set; }

        List<string> options = new List<string>();

        public CorrelationOptions()
        {
            InitializeComponent();
        }

        private void BivariateOptions_Load(object sender, EventArgs e)
        {
            options.Add("Assimetria");
            options.Add("Curtose");
            options.Add("Média");
            options.Add("Mediana");
            options.Add("Selecionamento");

            foreach(string option in options)
                comboBoxHorizontal.Items.Add(option);

            foreach (string option in options)
                comboBoxVertical.Items.Add(option);

            comboBoxHorizontal.Text = "Média";
            comboBoxVertical.Text = "Selecionamento";
        }

        private void ComboBoxHorizontal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prevSelected = comboBoxVertical.Text;
            comboBoxVertical.Items.Clear();

            List<string> options2 = new List<string>();
            foreach (string option2 in options)
                if(option2 != comboBoxHorizontal.Text)
                    comboBoxVertical.Items.Add(option2);

            comboBoxVertical.SelectedItem = prevSelected;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxHorizontal.Text != "" && comboBoxVertical.Text != "")
            {
                this.Close();
                ParentForm.GenerateBivariateChart(PortugueseToEnglish(comboBoxHorizontal.Text), PortugueseToEnglish(comboBoxVertical.Text));
            }
            else if (comboBoxHorizontal.Text == "")
            { 
                MessageBox.Show("Nenhuma variável selecionada para o eixo horizontal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (comboBoxVertical.Text == "")
            {
                MessageBox.Show("Nenhuma variável selecionada para o eixo vertical.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string PortugueseToEnglish(string str)
        {
            if (str == "Assimetria")
                return "assimetry";
            if (str == "Curtose")
                return "curtose";
            if (str == "Média")
                return "mean";
            if (str == "Mediana")
                return "median";
            if (str == "Selecionamento")
                return "selection";

            return "";
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
