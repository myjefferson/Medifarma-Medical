namespace Medifarma
{
    partial class CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroCliente));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.DataCad = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionarFoto = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Fechar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUsuario.Location = new System.Drawing.Point(293, 232);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(181, 29);
            this.txtUsuario.TabIndex = 1;
            // 
            // DataCad
            // 
            this.DataCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DataCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataCad.Location = new System.Drawing.Point(293, 308);
            this.DataCad.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DataCad.Name = "DataCad";
            this.DataCad.Size = new System.Drawing.Size(140, 29);
            this.DataCad.TabIndex = 3;
            this.DataCad.Value = new System.DateTime(2019, 9, 11, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(201, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(215, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(109, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data de Cadastro";
            // 
            // btnAdicionarFoto
            // 
            this.btnAdicionarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAdicionarFoto.Location = new System.Drawing.Point(608, 107);
            this.btnAdicionarFoto.Name = "btnAdicionarFoto";
            this.btnAdicionarFoto.Size = new System.Drawing.Size(143, 33);
            this.btnAdicionarFoto.TabIndex = 4;
            this.btnAdicionarFoto.Text = "Adicionar Foto";
            this.btnAdicionarFoto.UseVisualStyleBackColor = true;
            this.btnAdicionarFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCadastrar.Location = new System.Drawing.Point(267, 349);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(181, 41);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Botão Principal";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // mskSenha
            // 
            this.mskSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.mskSenha.Location = new System.Drawing.Point(293, 270);
            this.mskSenha.Mask = "000000";
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.Size = new System.Drawing.Size(83, 29);
            this.mskSenha.TabIndex = 2;
            this.mskSenha.UseSystemPasswordChar = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAlterar.Location = new System.Drawing.Point(347, 106);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 35);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnExcluir.Location = new System.Drawing.Point(454, 106);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 35);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnInserir.Location = new System.Drawing.Point(240, 106);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(101, 35);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNome.Location = new System.Drawing.Point(293, 194);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 29);
            this.txtNome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(221, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome";
            // 
            // Fechar
            // 
            this.Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Fechar.ForeColor = System.Drawing.SystemColors.Window;
            this.Fechar.Location = new System.Drawing.Point(782, -2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(37, 35);
            this.Fechar.TabIndex = 13;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCodigo.Location = new System.Drawing.Point(293, 157);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(47, 29);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(207, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(13, 405);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(790, 135);
            this.dtGridView.TabIndex = 14;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridView_CellContentClick);
            this.dtGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DtGridView_CellFormatting);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBox3.Location = new System.Drawing.Point(477, 354);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 31);
            this.textBox3.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button2.Location = new System.Drawing.Point(608, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "Pesquisar Nome";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // picFoto
            // 
            this.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFoto.Location = new System.Drawing.Point(611, 160);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(140, 140);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 4;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVoltar.Location = new System.Drawing.Point(23, 22);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(53, 53);
            this.picVoltar.TabIndex = 17;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.PicVoltar_Click);
            this.picVoltar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicVoltar_MouseDown);
            this.picVoltar.MouseEnter += new System.EventHandler(this.PicVoltar_MouseEnter);
            this.picVoltar.MouseLeave += new System.EventHandler(this.PicVoltar_MouseLeave);
            // 
            // txtImagen
            // 
            this.txtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtImagen.Location = new System.Drawing.Point(611, 271);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(140, 27);
            this.txtImagen.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Medifarma.Properties.Resources.olho_f;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(380, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseUp);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCancelar.Location = new System.Drawing.Point(143, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Medifarma.Properties.Resources.CadClienteAdmin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.mskSenha);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAdicionarFoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataCad);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CadastroCliente_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CadastroCliente_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DateTimePicker DataCad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionarFoto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
    }
}