namespace Medifarma
{
    partial class LoginUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUsuario));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.Fechar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.picClienteLog = new System.Windows.Forms.PictureBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.picOlhoSenha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClienteLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOlhoSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtLogin.Location = new System.Drawing.Point(72, 248);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(207, 23);
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
            this.Fechar.TabIndex = 10;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSenha.Location = new System.Drawing.Point(72, 303);
            this.txtSenha.Mask = "000000";
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(91, 26);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // picClienteLog
            // 
            this.picClienteLog.BackColor = System.Drawing.Color.Transparent;
            this.picClienteLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClienteLog.Location = new System.Drawing.Point(11, 372);
            this.picClienteLog.Name = "picClienteLog";
            this.picClienteLog.Size = new System.Drawing.Size(291, 47);
            this.picClienteLog.TabIndex = 14;
            this.picClienteLog.TabStop = false;
            this.picClienteLog.Click += new System.EventHandler(this.PicClienteLog_Click);
            this.picClienteLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicClienteLog_MouseDown);
            this.picClienteLog.MouseEnter += new System.EventHandler(this.PicClienteLog_MouseEnter);
            this.picClienteLog.MouseLeave += new System.EventHandler(this.PicClienteLog_MouseLeave);
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVoltar.Location = new System.Drawing.Point(128, 492);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(53, 50);
            this.picVoltar.TabIndex = 17;
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
            this.picOlhoSenha.TabIndex = 18;
            this.picOlhoSenha.TabStop = false;
            this.picOlhoSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicOlhoSenha_MouseDown);
            this.picOlhoSenha.MouseEnter += new System.EventHandler(this.PicOlhoSenha_MouseEnter);
            this.picOlhoSenha.MouseLeave += new System.EventHandler(this.PicOlhoSenha_MouseLeave);
            this.picOlhoSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicOlhoSenha_MouseUp);
            // 
            // LoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Medifarma.Properties.Resources.LoginUsuarioFundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.picOlhoSenha);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.picClienteLog);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.txtLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginUsuario_FormClosing);
            this.Load += new System.EventHandler(this.LoginUsuario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginUsuario_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginUsuario_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picClienteLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOlhoSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.PictureBox picClienteLog;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.PictureBox picOlhoSenha;
    }
}