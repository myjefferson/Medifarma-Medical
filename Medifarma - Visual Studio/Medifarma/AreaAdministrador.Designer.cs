namespace Medifarma
{
    partial class AreaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaAdministrador));
            this.button1 = new System.Windows.Forms.Button();
            this.lblAdm = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.LeitorXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(283, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 120);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCadCliente);
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.BackColor = System.Drawing.Color.Transparent;
            this.lblAdm.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.lblAdm.ForeColor = System.Drawing.Color.Crimson;
            this.lblAdm.Location = new System.Drawing.Point(242, 29);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(231, 40);
            this.lblAdm.TabIndex = 5;
            this.lblAdm.Text = "NOMEADMIN";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBuscarPaciente.Location = new System.Drawing.Point(283, 128);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(203, 120);
            this.btnBuscarPaciente.TabIndex = 7;
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
            this.Fechar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Fechar.Location = new System.Drawing.Point(784, -3);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(37, 35);
            this.Fechar.TabIndex = 12;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 22F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(-2, 425);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(239, 68);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LeitorXML
            // 
            this.LeitorXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LeitorXML.Location = new System.Drawing.Point(283, 413);
            this.LeitorXML.Name = "LeitorXML";
            this.LeitorXML.Size = new System.Drawing.Size(203, 86);
            this.LeitorXML.TabIndex = 19;
            this.LeitorXML.Text = "Leitor de Arquivo XML";
            this.LeitorXML.UseVisualStyleBackColor = true;
            this.LeitorXML.Click += new System.EventHandler(this.LeitorXML_Click);
            // 
            // AreaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.LeitorXML);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.btnBuscarPaciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AreaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AreaAdministrador";
            this.Load += new System.EventHandler(this.AreaAdministrador_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AreaAdministrador_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AreaAdministrador_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAdm;
        private System.Windows.Forms.Button btnBuscarPaciente;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button LeitorXML;
    }
}