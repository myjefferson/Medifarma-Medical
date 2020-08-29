namespace Medifarma
{
    partial class AreaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaCliente));
            this.lblNome = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.AgendaConsulta = new System.Windows.Forms.Button();
            this.picFotoPerfil = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.Indigo;
            this.lblNome.Location = new System.Drawing.Point(236, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 40);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBuscarPaciente.Location = new System.Drawing.Point(405, 146);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(203, 102);
            this.btnBuscarPaciente.TabIndex = 8;
            this.btnBuscarPaciente.Text = "Buscar Paciente";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Fechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Fechar.Location = new System.Drawing.Point(767, -1);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(37, 35);
            this.Fechar.TabIndex = 13;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Indigo;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(-4, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(236, 68);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // AgendaConsulta
            // 
            this.AgendaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AgendaConsulta.Location = new System.Drawing.Point(272, 286);
            this.AgendaConsulta.Name = "AgendaConsulta";
            this.AgendaConsulta.Size = new System.Drawing.Size(203, 102);
            this.AgendaConsulta.TabIndex = 15;
            this.AgendaConsulta.Text = "Agendar Consulta Médica";
            this.AgendaConsulta.UseVisualStyleBackColor = true;
            this.AgendaConsulta.Click += new System.EventHandler(this.AgendaConsulta_Click);
            // 
            // picFotoPerfil
            // 
            this.picFotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFotoPerfil.Location = new System.Drawing.Point(65, 86);
            this.picFotoPerfil.Name = "picFotoPerfil";
            this.picFotoPerfil.Size = new System.Drawing.Size(100, 100);
            this.picFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPerfil.TabIndex = 16;
            this.picFotoPerfil.TabStop = false;
            this.picFotoPerfil.Click += new System.EventHandler(this.picFotoPerfil_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(525, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 102);
            this.button2.TabIndex = 17;
            this.button2.Text = "Registro de Consultas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AreaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Medifarma.Properties.Resources.AreaCliente1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 536);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picFotoPerfil);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.AgendaConsulta);
            this.Controls.Add(this.btnBuscarPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AreaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AreaCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AreaCliente_FormClosing);
            this.Load += new System.EventHandler(this.AreaCliente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaCliente_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AreaCliente_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button AgendaConsulta;
        private System.Windows.Forms.PictureBox picFotoPerfil;
        private System.Windows.Forms.Button button2;
    }
}