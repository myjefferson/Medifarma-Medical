namespace Medifarma
{
    partial class BuscarPacienteCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPacienteCliente));
            this.dtDataPesq = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.MaskedTextBox();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPesPaciente = new System.Windows.Forms.TextBox();
            this.btnPesqNome = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.Fechar = new System.Windows.Forms.Label();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDataPesq
            // 
            this.dtDataPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtDataPesq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPesq.Location = new System.Drawing.Point(39, 338);
            this.dtDataPesq.Name = "dtDataPesq";
            this.dtDataPesq.Size = new System.Drawing.Size(118, 26);
            this.dtDataPesq.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(168, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "Loc. Data de Nascimento";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGenero.Location = new System.Drawing.Point(519, 190);
            this.txtGenero.Mask = "A";
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(32, 29);
            this.txtGenero.TabIndex = 34;
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(190, 243);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(140, 29);
            this.dtDataNasc.TabIndex = 33;
            this.dtDataNasc.ValueChanged += new System.EventHandler(this.dtDataNasc_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(416, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(419, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Convenio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(438, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(455, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(88, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "DataNasc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(72, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Sobrenome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(460, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "CPF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(111, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(122, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEmail.Location = new System.Drawing.Point(518, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 29);
            this.txtEmail.TabIndex = 19;
            // 
            // txtConvenio
            // 
            this.txtConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtConvenio.Location = new System.Drawing.Point(519, 226);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(181, 29);
            this.txtConvenio.TabIndex = 18;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDescricao.Location = new System.Drawing.Point(518, 263);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(181, 29);
            this.txtDescricao.TabIndex = 17;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSobrenome.Location = new System.Drawing.Point(190, 208);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(181, 29);
            this.txtSobrenome.TabIndex = 16;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCPF.Location = new System.Drawing.Point(518, 119);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(181, 29);
            this.txtCPF.TabIndex = 15;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCodigo.Location = new System.Drawing.Point(190, 137);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(60, 29);
            this.txtCodigo.TabIndex = 14;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNome.Location = new System.Drawing.Point(190, 172);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 29);
            this.txtNome.TabIndex = 13;
            // 
            // txtPesPaciente
            // 
            this.txtPesPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPesPaciente.Location = new System.Drawing.Point(425, 337);
            this.txtPesPaciente.Name = "txtPesPaciente";
            this.txtPesPaciente.Size = new System.Drawing.Size(152, 29);
            this.txtPesPaciente.TabIndex = 12;
            // 
            // btnPesqNome
            // 
            this.btnPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnPesqNome.Location = new System.Drawing.Point(586, 332);
            this.btnPesqNome.Name = "btnPesqNome";
            this.btnPesqNome.Size = new System.Drawing.Size(187, 38);
            this.btnPesqNome.TabIndex = 11;
            this.btnPesqNome.Text = "Pesquisar Paciente";
            this.btnPesqNome.UseVisualStyleBackColor = true;
            this.btnPesqNome.Click += new System.EventHandler(this.BtnPesqNome_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(18, 397);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(780, 143);
            this.dtGridView.TabIndex = 10;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridView_CellContentClick);
            // 
            // Fechar
            // 
            this.Fechar.AutoSize = true;
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Fechar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Fechar.Location = new System.Drawing.Point(789, 1);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(27, 26);
            this.Fechar.TabIndex = 37;
            this.Fechar.Text = "X";
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVoltar.Location = new System.Drawing.Point(24, 21);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(51, 51);
            this.picVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVoltar.TabIndex = 38;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.PicVoltar_Click);
            this.picVoltar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicVoltar_MouseDown);
            this.picVoltar.MouseEnter += new System.EventHandler(this.PicVoltar_MouseEnter);
            this.picVoltar.MouseLeave += new System.EventHandler(this.PicVoltar_MouseLeave);
            this.picVoltar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicVoltar_MouseUp);
            // 
            // BuscarPacienteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Medifarma.Properties.Resources.BuscaPaciente_Cliente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.dtDataPesq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.dtDataNasc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConvenio);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtPesPaciente);
            this.Controls.Add(this.btnPesqNome);
            this.Controls.Add(this.dtGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarPacienteCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Paciente - Cliente";
            this.Load += new System.EventHandler(this.BuscarPacienteCliente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuscarPacienteCliente_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BuscarPacienteCliente_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDataPesq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtGenero;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPesPaciente;
        private System.Windows.Forms.Button btnPesqNome;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Label Fechar;
        private System.Windows.Forms.PictureBox picVoltar;
    }
}