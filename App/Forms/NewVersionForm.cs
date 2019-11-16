using Octokit;
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
    public partial class NewVersionForm : Form
    {
        public IReadOnlyList<Release> Releases;

        public string LatestVersionUrl = "";
        public string LatestVersionTagName = "";
        public string LatestVersionName = "";
        public string LatestVersionUrlAsset = "";

        public NewVersionForm()
        {
            InitializeComponent();
        }

        private void NewVersionForm_Load(object sender, EventArgs e)
        {
            buttonView.Text = "Ver informações da versão " + LatestVersionTagName;
            buttonDownload.Text = "Baixar arquivo da versão " + LatestVersionUrlAsset;


            console.SelectionFont = new System.Drawing.Font("Tahoma", 16, FontStyle.Underline);
            console.AppendText("Olá, temos novidades! A versão " + LatestVersionTagName + " do SIGRAN está disponível para download.");

            foreach (Release release in Releases)
            {
                console.AppendText("\n\r\n\r");

                console.SelectionFont = new System.Drawing.Font("Tahoma", 12, FontStyle.Bold);
                console.AppendText(release.TagName + " - " + release.Name + " (" + release.CreatedAt.ToString("yyyy/MM/dd") + ")");

                console.AppendText("\n\r");

                console.SelectionFont = new System.Drawing.Font("Tahoma", 10, FontStyle.Regular);
                console.AppendText(release.Body);

                console.AppendText("\n\r");

                console.SelectionFont = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                console.AppendText("Arquivo: " + release.Assets[0].BrowserDownloadUrl);
            }
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            if (LatestVersionUrlAsset != "")
                System.Diagnostics.Process.Start(LatestVersionUrlAsset);
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            if (LatestVersionUrl != "")
                System.Diagnostics.Process.Start(LatestVersionUrl);
        }

        private void CheckBoxNoNotify_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoNotify.Checked)
            {
                IniFile ini = new IniFile(new MainForm().SettingsFile);
                    ini.Write("NOSEARCHNEWVERSIONS", "1");
            }
            else
            {
                IniFile ini = new IniFile(new MainForm().SettingsFile);
                ini.Write("NOSEARCHNEWVERSIONS", "0");
            }
        }
    }
}
