using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisgrain
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            SetAndStartTimer();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            labelVersion.Text = "v. " + MainForm.AppVersion;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMInimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Timer timer = new Timer();

        private void SetAndStartTimer()
        {
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        static int count = 0;

        void timer_Tick(object sender, EventArgs e)
        {
            count += 2;
            label3.Text = "Carregando...  (" + count + "%)";

            if (count == 100)
            {
                timer.Stop();
                this.Close();
            }
        }

        private void LoadingForm_Closed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
