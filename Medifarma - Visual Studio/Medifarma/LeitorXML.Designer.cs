namespace Medifarma
{
    partial class LeitorArquivoXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeitorArquivoXML));
            this.listXML = new System.Windows.Forms.ListBox();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.btnXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcurarXML = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // listXML
            // 
            this.listXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listXML.FormattingEnabled = true;
            this.listXML.ItemHeight = 16;
            this.listXML.Location = new System.Drawing.Point(17, 121);
            this.listXML.Name = "listXML";
            this.listXML.Size = new System.Drawing.Size(327, 132);
            this.listXML.TabIndex = 21;
            // 
            // txtXML
            // 
            this.txtXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtXML.Location = new System.Drawing.Point(17, 84);
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(327, 27);
            this.txtXML.TabIndex = 20;
            // 
            // btnXML
            // 
            this.btnXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnXML.Location = new System.Drawing.Point(17, 261);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(327, 32);
            this.btnXML.TabIndex = 19;
            this.btnXML.Text = "Ler Arquivo XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(337, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProcurarXML
            // 
            this.btnProcurarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnProcurarXML.Location = new System.Drawing.Point(79, 48);
            this.btnProcurarXML.Name = "btnProcurarXML";
            this.btnProcurarXML.Size = new System.Drawing.Size(205, 30);
            this.btnProcurarXML.TabIndex = 23;
            this.btnProcurarXML.Text = "Procurar Arquivo XML";
            this.btnProcurarXML.UseVisualStyleBackColor = true;
            this.btnProcurarXML.Click += new System.EventHandler(this.btnProcurarXML_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LeitorArquivoXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(364, 337);
            this.Controls.Add(this.btnProcurarXML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listXML);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.btnXML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeitorArquivoXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeitorXML";
            this.Load += new System.EventHandler(this.LeitorArquivoXML_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeitorArquivoXML_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeitorArquivoXML_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listXML;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcurarXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}