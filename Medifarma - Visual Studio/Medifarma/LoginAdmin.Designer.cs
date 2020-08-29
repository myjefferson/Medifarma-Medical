namespace Medifarma
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.Fechar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.picAdmLog = new System.Windows.Forms.PictureBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.picOlhoSenha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOlhoSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtLogin.Location = new System.Drawing.Point(75, 249);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(160, 25);
            this.txtLogin.TabIndex = 0;
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fechar.Location = new System.Drawing.Point(783, -2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(37, 35);
            this.Fechar.TabIndex = 11;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSenha.Location = new System.Drawing.Point(75, 305);
            this.txtSenha.Mask = "000000";
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(89, 26);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // picAdmLog
            // 
            this.picAdmLog.BackColor = System.Drawing.Color.Transparent;
            this.picAdmLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdmLog.Location = new System.Drawing.Point(12, 372);
            this.picAdmLog.Name = "picAdmLog";
            this.picAdmLog.Size = new System.Drawing.Size(291, 47);
            this.picAdmLog.TabIndex = 15;
            this.picAdmLog.TabStop = false;
            this.picAdmLog.Click += new System.EventHandler(this.PicAdmLog_Click);
            this.picAdmLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicAdmLog_MouseDown);
            this.picAdmLog.MouseEnter += new System.EventHandler(this.PicAdmLog_MouseEnter);
            this.picAdmLog.MouseLeave += new System.EventHandler(this.PicAdmLog_MouseLeave);
            this.picAdmLog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicAdmLog_MouseUp);
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVoltar.Location = new System.Drawing.Point(128, 492);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(53, 50);
            this.picVoltar.TabIndex = 16;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.PicVoltar_Click);
            this.picVoltar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicVoltar_MouseDown);
            this.picVoltar.MouseEnter += new System.EventHandler(this.PicVoltar_MouseEnter);
            this.picVoltar.MouseLeave += new System.EventHandler(this.PicVoltar_MouseLeave);
            // 
            // picOlhoSenha
            // 
            this.picOlhoSenha.BackColor = System.Drawing.Color.Transparent;
            this.picOlhoSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOlhoSenha.Location = new System.Drawing.Point(261, 301);
            this.picOlhoSenha.Name = "picOlhoSenha";
            this.picOlhoSenha.Size = new System.Drawing.Size(30, 31);
            this.picOlhoSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOlhoSenha.TabIndex = 17;
            this.picOlhoSenha.TabStop = false;
            this.picOlhoSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.picOlhoSenha.MouseEnter += new System.EventHandler(this.PicOlhoSenha_MouseEnter);
            this.picOlhoSenha.MouseLeave += new System.EventHandler(this.PicOlhoSenha_MouseLeave);
            this.picOlhoSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Medifarma.Properties.Resources.LoginAdmFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.picOlhoSenha);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.picAdmLog);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medifarma - Login  Administrasdor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginAdmin_FormClosing);
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginAdmin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginAdmin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOlhoSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.PictureBox picAdmLog;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.PictureBox picOlhoSenha;
    }
}