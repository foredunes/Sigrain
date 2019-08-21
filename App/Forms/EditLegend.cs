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
    public partial class EditLegend : Form
    {
        public ResultChart parentForm = new ResultChart();

        public string type = "frequencyAcc";

        public EditLegend()
        {
            InitializeComponent();
        }

        private void EditLegend_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                e.RowIndex >= 0)
            {
                var buttonClicked = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                ColorDialog colorDialog = new ColorDialog();
                // Keeps the user from selecting a custom color.
                colorDialog.AllowFullOpen = true;
                // Allows the user to get help. (The default is false.)
                colorDialog.ShowHelp = true;
                // Sets the initial color select to the current text color.
                colorDialog.Color = buttonClicked.Style.BackColor;

                // Update the text box color if the user clicks OK 
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    buttonClicked.Value = colorDialog.Color.ToString();
                    buttonClicked.Style.BackColor = colorDialog.Color;
                    buttonClicked.Style.ForeColor = Color.Black;
                }
                    
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            for(int i=0; i < dataGridView1.Rows.Count; i++)
            {
                if(type == "frequencyAcc")
                {
                    parentForm.chart1.Series[i].LegendText = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    parentForm.chart1.Series[i].BorderWidth = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    parentForm.chart1.Series[i].Color = dataGridView1.Rows[i].Cells[3].Style.BackColor;
                }
                else
                {
                    parentForm.chart1.Series[0].Points[i].Label = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    parentForm.chart1.Series[0].Points[i].MarkerSize = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    parentForm.chart1.Series[0].Points[i].MarkerColor = dataGridView1.Rows[i].Cells[3].Style.BackColor;
                }
            }
            this.Close();
        }
    }
}
