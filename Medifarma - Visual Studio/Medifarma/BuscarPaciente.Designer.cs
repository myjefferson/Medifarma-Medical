namespace Medifarma
{
    partial class BuscarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPaciente));
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.btnPesqNome = new System.Windows.Forms.Button();
            this.txtPesPaciente = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtDataPesq = new System.Windows.Forms.DateTimePicker();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAltera = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(12, 409);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(789, 128);
            this.dtGridView.TabIndex = 0;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellContentClick);
            // 
            // btnPesqNome
            // 
            this.btnPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnPesqNome.Location = new System.Drawing.Point(583, 353);
            this.btnPesqNome.Name = "btnPesqNome";
            this.btnPesqNome.Size = new System.Drawing.Size(187, 35);
            this.btnPesqNome.TabIndex = 1;
            this.btnPesqNome.Text = "Pesquisar Paciente";
            this.btnPesqNome.UseVisualStyleBackColor = true;
            this.btnPesqNome.Click += new System.EventHandler(this.btnPesqNome_Click);
            // 
            // txtPesPaciente
            // 
            this.txtPesPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPesPaciente.Location = new System.Drawing.Point(422, 357);
            this.txtPesPaciente.Name = "txtPesPaciente";
            this.txtPesPaciente.Size = new System.Drawing.Size(152, 29);
            this.txtPesPaciente.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNome.Location = new System.Drawing.Point(204, 212);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 29);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSobrenome.Location = new System.Drawing.Point(204, 248);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(181, 29);
            this.txtSobrenome.TabIndex = 2;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(136, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(86, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sobrenome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(102, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "DataNasc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(456, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(204, 283);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(140, 29);
            this.dtDataNasc.TabIndex = 4;
            this.dtDataNasc.ValueChanged += new System.EventHandler(this.dtDataNasc_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(439, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Genero";
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGenero.Location = new System.Drawing.Point(520, 230);
            this.txtGenero.Mask = "A";
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(32, 29);
            this.txtGenero.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(420, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Convenio";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDescricao.Location = new System.Drawing.Point(519, 303);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(181, 29);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(417, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Descrição";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(165, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Loc. Data de Nascimento";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtDataPesq
            // 
            this.dtDataPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtDataPesq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPesq.Location = new System.Drawing.Point(36, 358);
            this.dtDataPesq.Name = "dtDataPesq";
            this.dtDataPesq.Size = new System.Drawing.Size(118, 26);
            this.dtDataPesq.TabIndex = 8;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCPF.Location = new System.Drawing.Point(519, 159);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(181, 29);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtCPF.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(461, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "CPF";
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnInserir.Location = new System.Drawing.Point(69, 106);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(118, 34);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnExcluir.Location = new System.Drawing.Point(324, 106);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(118, 34);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAltera.Location = new System.Drawing.Point(197, 106);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(118, 34);
            this.btnAltera.TabIndex = 9;
            this.btnAltera.Text = "Alterar";
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.BtnAltera_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGravar.Location = new System.Drawing.Point(642, 106);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(105, 34);
            this.btnGravar.TabIndex = 9;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEmail.Location = new System.Drawing.Point(519, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 29);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(125, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCodigo.Location = new System.Drawing.Point(204, 177);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(60, 29);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtConvenio
            // 
            this.txtConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtConvenio.Location = new System.Drawing.Point(519, 267);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(181, 29);
            this.txtConvenio.TabIndex = 2;
            this.txtConvenio.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVoltar.Location = new System.Drawing.Point(25, 23);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(49, 49);
            this.picVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVoltar.TabIndex = 18;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.PicVoltar_Click);
            this.picVoltar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicVoltar_MouseDown);
            this.picVoltar.MouseEnter += new System.EventHandler(this.PicVoltar_MouseEnter);
            this.picVoltar.MouseLeave += new System.EventHandler(this.PicVoltar_MouseLeave);
            this.picVoltar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicVoltar_MouseUp);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancelar.Location = new System.Drawing.Point(528, 106);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Medifarma.Properties.Resources.BuscaPaciente_Administrador;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAltera);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
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
            this.MaximizeBox = false;
            this.Name = "BuscarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPaciente - Admin";
            this.Load += new System.EventHandler(this.BuscarPaciente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuscarPaciente_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BuscarPaciente_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Button btnPesqNome;
        private System.Windows.Forms.TextBox txtPesPaciente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtDataPesq;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.Button btnCancelar;
    }
}