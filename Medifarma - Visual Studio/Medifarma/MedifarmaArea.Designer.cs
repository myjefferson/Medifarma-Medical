namespace Medifarma
{
    partial class MedifarmaArea
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedifarmaArea));
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.Button();
            this.Minimizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUsuario.Location = new System.Drawing.Point(504, 266);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(294, 64);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 1;
            this.picUsuario.TabStop = false;
            this.picUsuario.Click += new System.EventHandler(this.PicUsuario_Click);
            this.picUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicUsuario_MouseDown);
            this.picUsuario.MouseEnter += new System.EventHandler(this.PicUsuario_MouseEnter);
            this.picUsuario.MouseLeave += new System.EventHandler(this.PicUsuario_MouseLeave);
            // 
            // picAdmin
            // 
            this.picAdmin.BackColor = System.Drawing.Color.Transparent;
            this.picAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdmin.Location = new System.Drawing.Point(504, 349);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(294, 64);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmin.TabIndex = 1;
            this.picAdmin.TabStop = false;
            this.picAdmin.Click += new System.EventHandler(this.PicAdmin_Click);
            this.picAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicAdmin_MouseDown);
            this.picAdmin.MouseEnter += new System.EventHandler(this.PicAdmin_MouseEnter);
            this.picAdmin.MouseLeave += new System.EventHandler(this.PicAdmin_MouseLeave);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Fechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Fechar.Location = new System.Drawing.Point(783, -1);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(37, 35);
            this.Fechar.TabIndex = 2;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            this.Fechar.MouseEnter += new System.EventHandler(this.Fechar_MouseEnter);
            this.Fechar.MouseLeave += new System.EventHandler(this.Fechar_MouseLeave);
            this.Fechar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Fechar_MouseUp);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.FlatAppearance.BorderSize = 0;
            this.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.Minimizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Minimizar.Location = new System.Drawing.Point(751, -7);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(32, 40);
            this.Minimizar.TabIndex = 3;
            this.Minimizar.Text = "_";
            this.Minimizar.UseVisualStyleBackColor = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            this.Minimizar.MouseEnter += new System.EventHandler(this.Minimizar_MouseEnter);
            this.Minimizar.MouseLeave += new System.EventHandler(this.Minimizar_MouseLeave);
            // 
            // MedifarmaArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Medifarma.Properties.Resources.MEDIFARMA_Inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.picAdmin);
            this.Controls.Add(this.picUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MedifarmaArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Medifarma";
            this.Load += new System.EventHandler(this.Escolha_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Escolha_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Escolha_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button Minimizar;
    }
}

