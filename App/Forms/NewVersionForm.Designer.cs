namespace Sigran.Forms
{
    partial class NewVersionForm
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
            this.console = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxNoNotify = new System.Windows.Forms.CheckBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.Location = new System.Drawing.Point(10, 10);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(580, 280);
            this.console.TabIndex = 1;
            this.console.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 300);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.console);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(600, 300);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxNoNotify);
            this.panel1.Controls.Add(this.buttonView);
            this.panel1.Controls.Add(this.buttonDownload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 50);
            this.panel1.TabIndex = 2;
            // 
            // checkBoxNoNotify
            // 
            this.checkBoxNoNotify.AutoSize = true;
            this.checkBoxNoNotify.Location = new System.Drawing.Point(12, 15);
            this.checkBoxNoNotify.Name = "checkBoxNoNotify";
            this.checkBoxNoNotify.Size = new System.Drawing.Size(183, 17);
            this.checkBoxNoNotify.TabIndex = 2;
            this.checkBoxNoNotify.Text = "Não exibir esta janela novamente";
            this.checkBoxNoNotify.UseVisualStyleBackColor = true;
            this.checkBoxNoNotify.CheckedChanged += new System.EventHandler(this.CheckBoxNoNotify_CheckedChanged);
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonView.Location = new System.Drawing.Point(222, 15);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(180, 23);
            this.buttonView.TabIndex = 1;
            this.buttonView.Text = "Ver informações da nova versão";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload.Location = new System.Drawing.Point(408, 15);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(180, 23);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Baixar arquivo da nova versão";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // NewVersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NewVersionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova versão";
            this.Load += new System.EventHandler(this.NewVersionForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxNoNotify;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonDownload;
    }
}