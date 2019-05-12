namespace Sigrain
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.labelVersion = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMInimize = new Sigrain.Classes.ButtonZ();
            this.buttonExit = new Sigrain.Classes.ButtonZ();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(10, 9);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(54, 26);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "V.1.0";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(100)))), ((int)(((byte)(53)))));
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.buttonMInimize);
            this.mainPanel.Controls.Add(this.buttonExit);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.labelVersion);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(445, 239);
            this.mainPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Sistema de Informação Granulométrica";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(168, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 100);
            this.label1.TabIndex = 54;
            // 
            // buttonMInimize
            // 
            this.buttonMInimize.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(100)))), ((int)(((byte)(53)))));
            this.buttonMInimize.DisplayText = "_";
            this.buttonMInimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMInimize.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMInimize.ForeColor = System.Drawing.Color.White;
            this.buttonMInimize.Location = new System.Drawing.Point(396, 0);
            this.buttonMInimize.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.buttonMInimize.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.buttonMInimize.Name = "buttonMInimize";
            this.buttonMInimize.Size = new System.Drawing.Size(22, 23);
            this.buttonMInimize.TabIndex = 53;
            this.buttonMInimize.Text = "_";
            this.buttonMInimize.TextLocation_X = 6;
            this.buttonMInimize.TextLocation_Y = -2;
            this.buttonMInimize.UseVisualStyleBackColor = true;
            this.buttonMInimize.Click += new System.EventHandler(this.ButtonMInimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(100)))), ((int)(((byte)(53)))));
            this.buttonExit.DisplayText = "X";
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(418, 0);
            this.buttonExit.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.buttonExit.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(27, 23);
            this.buttonExit.TabIndex = 52;
            this.buttonExit.Text = "X";
            this.buttonExit.TextLocation_X = 6;
            this.buttonExit.TextLocation_Y = 0;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carregando...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 78);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIGRAIN";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 239);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Sigrain.Classes.ButtonZ buttonMInimize;
        private Sigrain.Classes.ButtonZ buttonExit;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}