using Sisgrain.Classes;
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

namespace Sisgrain.Forms
{
    public partial class ResultSample : Form
    {
        internal static Functions f = new Functions();

        public ResultSample()
        {
            InitializeComponent();
        }

        private void ResultSample_Load(object sender, EventArgs e)
        {

        }

        private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void CopiarTodaATabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyDataGridViewToClipboard(dataGridView1, false, true);
        }

        private void CopyDataGridViewToClipboard(DataGridView dgv, bool includeHeaders = true, bool allRows = false)
        {
            try
            {
                string s = "";
                DataGridViewColumn oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
                if (includeHeaders)
                {
                    do
                    {
                        s = s + oCurrentCol.HeaderText + "\t";
                        oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, DataGridViewElementStates.Visible, DataGridViewElementStates.None);
                    }
                    while (oCurrentCol != null);
                    s = s.Substring(0, s.Length - 1);
                    s = s + Environment.NewLine;    //Get rows
                }
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible);

                    if (row.Selected || allRows)
                    {
                        do
                        {
                            if (row.Cells[oCurrentCol.Index].Value != null) s = s + row.Cells[oCurrentCol.Index].Value.ToString();
                            s = s + "\t";
                            oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, DataGridViewElementStates.Visible, DataGridViewElementStates.None);
                        }
                        while (oCurrentCol != null);
                        s = s.Substring(0, s.Length - 1);
                        s = s + Environment.NewLine;
                    }
                }
                Clipboard.SetText(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void ExportarPlanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.exportDatagridToFile(dataGridView1);


        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
