namespace Sisgrain.Forms
{
    partial class SampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCanelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownLongitude = new System.Windows.Forms.NumericUpDown();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.numericUpDownLatitude = new System.Windows.Forms.NumericUpDown();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCarbonato = new System.Windows.Forms.NumericUpDown();
            this.labelCarbonatos = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.textBoxAmostra = new System.Windows.Forms.TextBox();
            this.labelAmostra = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Phi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarbonato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 3, 10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.splitContainer1.Size = new System.Drawing.Size(598, 450);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.labelPeso);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(10, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 32);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Peso total";
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPeso.Location = new System.Drawing.Point(3, 16);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(28, 13);
            this.labelPeso.TabIndex = 0;
            this.labelPeso.Text = "0.00";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonCanelar);
            this.flowLayoutPanel1.Controls.Add(this.buttonSalvar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 411);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(185, 29);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // buttonCanelar
            // 
            this.buttonCanelar.Location = new System.Drawing.Point(3, 3);
            this.buttonCanelar.Name = "buttonCanelar";
            this.buttonCanelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCanelar.TabIndex = 0;
            this.buttonCanelar.Text = "Cancelar";
            this.buttonCanelar.UseVisualStyleBackColor = true;
            this.buttonCanelar.Click += new System.EventHandler(this.ButtonCanelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(84, 3);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.numericUpDownLongitude);
            this.groupBox2.Controls.Add(this.labelLongitude);
            this.groupBox2.Controls.Add(this.numericUpDownLatitude);
            this.groupBox2.Controls.Add(this.labelLatitude);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(185, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Localização";
            // 
            // numericUpDownLongitude
            // 
            this.numericUpDownLongitude.DecimalPlaces = 5;
            this.numericUpDownLongitude.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownLongitude.Location = new System.Drawing.Point(3, 62);
            this.numericUpDownLongitude.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownLongitude.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownLongitude.Name = "numericUpDownLongitude";
            this.numericUpDownLongitude.Size = new System.Drawing.Size(179, 20);
            this.numericUpDownLongitude.TabIndex = 22;
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLongitude.Location = new System.Drawing.Point(3, 49);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(54, 13);
            this.labelLongitude.TabIndex = 18;
            this.labelLongitude.Text = "Longitude";
            // 
            // numericUpDownLatitude
            // 
            this.numericUpDownLatitude.DecimalPlaces = 5;
            this.numericUpDownLatitude.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownLatitude.Location = new System.Drawing.Point(3, 29);
            this.numericUpDownLatitude.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownLatitude.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numericUpDownLatitude.Name = "numericUpDownLatitude";
            this.numericUpDownLatitude.Size = new System.Drawing.Size(179, 20);
            this.numericUpDownLatitude.TabIndex = 17;
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLatitude.Location = new System.Drawing.Point(3, 16);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(45, 13);
            this.labelLatitude.TabIndex = 0;
            this.labelLatitude.Text = "Latitude";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.numericUpDownCarbonato);
            this.groupBox1.Controls.Add(this.labelCarbonatos);
            this.groupBox1.Controls.Add(this.dateTimePickerData);
            this.groupBox1.Controls.Add(this.labelData);
            this.groupBox1.Controls.Add(this.textBoxDescricao);
            this.groupBox1.Controls.Add(this.labelDescricao);
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.labelCategoria);
            this.groupBox1.Controls.Add(this.textBoxAmostra);
            this.groupBox1.Controls.Add(this.labelAmostra);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(185, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificação da amostra";
            // 
            // numericUpDownCarbonato
            // 
            this.numericUpDownCarbonato.DecimalPlaces = 3;
            this.numericUpDownCarbonato.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownCarbonato.Location = new System.Drawing.Point(3, 195);
            this.numericUpDownCarbonato.Name = "numericUpDownCarbonato";
            this.numericUpDownCarbonato.Size = new System.Drawing.Size(179, 20);
            this.numericUpDownCarbonato.TabIndex = 16;
            // 
            // labelCarbonatos
            // 
            this.labelCarbonatos.AutoSize = true;
            this.labelCarbonatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCarbonatos.Location = new System.Drawing.Point(3, 182);
            this.labelCarbonatos.Name = "labelCarbonatos";
            this.labelCarbonatos.Size = new System.Drawing.Size(72, 13);
            this.labelCarbonatos.TabIndex = 15;
            this.labelCarbonatos.Text = "Carbonatos %";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePickerData.Location = new System.Drawing.Point(3, 162);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerData.TabIndex = 14;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelData.Location = new System.Drawing.Point(3, 149);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 13;
            this.labelData.Text = "Data";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDescricao.Location = new System.Drawing.Point(3, 129);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(179, 20);
            this.textBoxDescricao.TabIndex = 7;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescricao.Location = new System.Drawing.Point(3, 116);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 6;
            this.labelDescricao.Text = "Descrição";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(3, 95);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(179, 21);
            this.comboBoxCategoria.TabIndex = 5;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCategoria.Location = new System.Drawing.Point(3, 82);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 4;
            this.labelCategoria.Text = "Categoria";
            // 
            // textBoxAmostra
            // 
            this.textBoxAmostra.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxAmostra.Location = new System.Drawing.Point(3, 62);
            this.textBoxAmostra.Name = "textBoxAmostra";
            this.textBoxAmostra.Size = new System.Drawing.Size(179, 20);
            this.textBoxAmostra.TabIndex = 3;
            // 
            // labelAmostra
            // 
            this.labelAmostra.AutoSize = true;
            this.labelAmostra.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAmostra.Location = new System.Drawing.Point(3, 49);
            this.labelAmostra.Name = "labelAmostra";
            this.labelAmostra.Size = new System.Drawing.Size(45, 13);
            this.labelAmostra.TabIndex = 2;
            this.labelAmostra.Text = "Amostra";
            // 
            // textBoxId
            // 
            this.textBoxId.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(3, 29);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(179, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelId.Location = new System.Drawing.Point(3, 16);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Phi,
            this.Pesos});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 430);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // Phi
            // 
            this.Phi.HeaderText = "Phi";
            this.Phi.Name = "Phi";
            this.Phi.ReadOnly = true;
            this.Phi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Pesos
            // 
            this.Pesos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pesos.DataPropertyName = "Pesos";
            this.Pesos.HeaderText = "Pesos";
            this.Pesos.Name = "Pesos";
            this.Pesos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Amostras";
            this.Load += new System.EventHandler(this.SampleForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLatitude)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarbonato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCarbonatos;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelAmostra;
        public System.Windows.Forms.TextBox textBoxId;
        public System.Windows.Forms.Label labelId;
        public System.Windows.Forms.NumericUpDown numericUpDownLongitude;
        public System.Windows.Forms.NumericUpDown numericUpDownLatitude;
        public System.Windows.Forms.NumericUpDown numericUpDownCarbonato;
        public System.Windows.Forms.DateTimePicker dateTimePickerData;
        public System.Windows.Forms.TextBox textBoxDescricao;
        public System.Windows.Forms.ComboBox comboBoxCategoria;
        public System.Windows.Forms.TextBox textBoxAmostra;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesos;
        public System.Windows.Forms.Button buttonCanelar;
        public System.Windows.Forms.Button buttonSalvar;
    }
}