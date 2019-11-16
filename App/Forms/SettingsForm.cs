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
    public partial class SettingsForm : Form
    {
        public string DatabaseFile = null;

        public SettingsForm()
        {
            InitializeComponent();
        }


        private void SampleForm_Load(object sender, EventArgs e)
        {
            comboBoxRotulesVariable.Items.Add("Amostra");
            comboBoxRotulesVariable.Items.Add("Categoria");
            comboBoxRotulesVariable.Items.Add("Descrição");
            comboBoxRotulesVariable.Items.Add("Data");

            MainForm mainForm = new MainForm();
            IniFile ini = new IniFile(mainForm.SettingsFile);
            if (ini.Read("ROTULES") == "sample")
                comboBoxRotulesVariable.Text = "Amostra";
            if (ini.Read("ROTULES") == "description")
                comboBoxRotulesVariable.Text = "Descrição";
            if (ini.Read("ROTULES") == "category")
                comboBoxRotulesVariable.Text = "Categoria";
            if (ini.Read("ROTULES") == "date")
                comboBoxRotulesVariable.Text = "Data";

            if(ini.Read("RELOAD") == "1")
            {
                checkBoxOpenLast.Checked = true;
            }
            else
            {
                checkBoxOpenLast.Checked = false;
            }

            if (ini.Read("FORMINSERTOPEN") == "1")
            {
                checkBoxFormInsertOpen.Checked = true;
            }
            else
            {
                checkBoxFormInsertOpen.Checked = false;
            }

            if (ini.Read("NOSEARCHNEWVERSIONS") == "1")
            {
                checkBoxNoNotifyNews.Checked = true;
            }
            else
            {
                checkBoxNoNotifyNews.Checked = false;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            IniFile ini = new IniFile(mainForm.SettingsFile);

            string rotules = "";
            if (comboBoxRotulesVariable.Text == "Amostra")
                rotules = "sample";
            if (comboBoxRotulesVariable.Text == "Descrição")
                rotules = "description";
            if (comboBoxRotulesVariable.Text == "Categoria")
                rotules = "category";
            if (comboBoxRotulesVariable.Text == "Data")
                rotules = "date";

            ini.Write("ROTULES", rotules);


            if (checkBoxOpenLast.Checked)
            {
                ini.Write("RELOAD", "1");
            }
            else
            {
                ini.Write("RELOAD", "0");
            }

            if (checkBoxFormInsertOpen.Checked)
            {
                ini.Write("FORMINSERTOPEN", "1");
            }
            else
            {
                ini.Write("FORMINSERTOPEN", "0");
            }

            if (checkBoxNoNotifyNews.Checked)
            {
                ini.Write("NOSEARCHNEWVERSIONS", "1");
            }
            else
            {
                ini.Write("NOSEARCHNEWVERSIONS", "0");
            }


            this.Close();
        }
    }
}
