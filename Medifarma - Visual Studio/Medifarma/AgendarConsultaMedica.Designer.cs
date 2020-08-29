namespace Medifarma
{
    partial class AgendarConsultaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarConsultaMedica));
            this.label1 = new System.Windows.Forms.Label();
            this.dtDataPesq = new System.Windows.Forms.DateTimePicker();
            this.btnLocDataNasc = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.MaskedTextBox();
            this.dtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPesPaciente = new System.Windows.Forms.TextBox();
            this.btnPesqNome = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.btnPesqCPF = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.btnAgendarConsulta = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.picVoltar = new System.Windows.Forms.PictureBox();
            this.cbMedico = new System.Windows.Forms.ComboBox();
            this.txtPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtPesqCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtEspecialidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(792, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtDataPesq
            // 
            this.dtDataPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtDataPesq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPesq.Location = new System.Drawing.Point(18, 349);
            this.dtDataPesq.Name = "dtDataPesq";
            this.dtDataPesq.Size = new System.Drawing.Size(118, 29);
            this.dtDataPesq.TabIndex = 63;
            // 
            // btnLocDataNasc
            // 
            this.btnLocDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLocDataNasc.Location = new System.Drawing.Point(146, 347);
            this.btnLocDataNasc.Name = "btnLocDataNasc";
            this.btnLocDataNasc.Size = new System.Drawing.Size(233, 35);
            this.btnLocDataNasc.TabIndex = 62;
            this.btnLocDataNasc.Text = "Loc. Data de Nascimento";
            this.btnLocDataNasc.UseVisualStyleBackColor = true;
            this.btnLocDataNasc.Click += new System.EventHandler(this.btnLocDataNasc_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(229, 160);
            this.txtGenero.Mask = "A";
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(32, 27);
            this.txtGenero.TabIndex = 61;
            // 
            // dtDataNasc
            // 
            this.dtDataNasc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasc.Location = new System.Drawing.Point(229, 191);
            this.dtDataNasc.Name = "dtDataNasc";
            this.dtDataNasc.Size = new System.Drawing.Size(140, 27);
            this.dtDataNasc.TabIndex = 60;
            this.dtDataNasc.ValueChanged += new System.EventHandler(this.dtDataNasc_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Data";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(507, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Médico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Gênero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Especialidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Data de Nascimento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "CPF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(161, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 50;
            this.label13.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nome do paciente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(229, 98);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(60, 27);
            this.txtCodigo.TabIndex = 42;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(229, 129);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(181, 27);
            this.txtNome.TabIndex = 41;
            // 
            // txtPesPaciente
            // 
            this.txtPesPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPesPaciente.Location = new System.Drawing.Point(450, 366);
            this.txtPesPaciente.Name = "txtPesPaciente";
            this.txtPesPaciente.Size = new System.Drawing.Size(152, 29);
            this.txtPesPaciente.TabIndex = 40;
            // 
            // btnPesqNome
            // 
            this.btnPesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnPesqNome.Location = new System.Drawing.Point(610, 365);
            this.btnPesqNome.Name = "btnPesqNome";
            this.btnPesqNome.Size = new System.Drawing.Size(187, 35);
            this.btnPesqNome.TabIndex = 39;
            this.btnPesqNome.Text = "Pesquisar Nome";
            this.btnPesqNome.UseVisualStyleBackColor = true;
            this.btnPesqNome.Click += new System.EventHandler(this.btnPesqNome_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtGridView.Location = new System.Drawing.Point(17, 413);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.Size = new System.Drawing.Size(780, 124);
            this.dtGridView.TabIndex = 38;
            this.dtGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellContentClick);
            // 
            // btnPesqCPF
            // 
            this.btnPesqCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnPesqCPF.Location = new System.Drawing.Point(611, 328);
            this.btnPesqCPF.Name = "btnPesqCPF";
            this.btnPesqCPF.Size = new System.Drawing.Size(185, 35);
            this.btnPesqCPF.TabIndex = 64;
            this.btnPesqCPF.Text = "Pesquisar CPF";
            this.btnPesqCPF.UseVisualStyleBackColor = true;
            this.btnPesqCPF.Click += new System.EventHandler(this.btnPesqCPF_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(524, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 57;
            this.label14.Text = "Hora";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(492, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "Convenio";
            // 
            // txtConvenio
            // 
            this.txtConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvenio.Location = new System.Drawing.Point(578, 213);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(181, 27);
            this.txtConvenio.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(517, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 66;
            this.label16.Text = "Preço";
            // 
            // dtHora
            // 
            this.dtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(578, 176);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(87, 27);
            this.dtHora.TabIndex = 68;
            // 
            // dtData
            // 
            this.dtData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(578, 139);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(140, 27);
            this.dtData.TabIndex = 60;
            // 
            // btnAgendarConsulta
            // 
            this.btnAgendarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgendarConsulta.Location = new System.Drawing.Point(604, 289);
            this.btnAgendarConsulta.Name = "btnAgendarConsulta";
            this.btnAgendarConsulta.Size = new System.Drawing.Size(197, 32);
            this.btnAgendarConsulta.TabIndex = 69;
            this.btnAgendarConsulta.Text = "Gravar Consulta";
            this.btnAgendarConsulta.UseVisualStyleBackColor = true;
            this.btnAgendarConsulta.Click += new System.EventHandler(this.btnAgendarConsulta_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnInserir.Location = new System.Drawing.Point(15, 289);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(159, 32);
            this.btnInserir.TabIndex = 69;
            this.btnInserir.Text = "Inserir Consulta";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // picVoltar
            // 
            this.picVoltar.BackColor = System.Drawing.Color.Transparent;
            this.picVoltar.Location = new System.Drawing.Point(22, 19);
            this.picVoltar.Name = "picVoltar";
            this.picVoltar.Size = new System.Drawing.Size(55, 54);
            this.picVoltar.TabIndex = 70;
            this.picVoltar.TabStop = false;
            this.picVoltar.Click += new System.EventHandler(this.picVoltar_Click);
            // 
            // cbMedico
            // 
            this.cbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbMedico.FormattingEnabled = true;
            this.cbMedico.Location = new System.Drawing.Point(578, 103);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(181, 28);
            this.cbMedico.TabIndex = 71;
            this.cbMedico.Click += new System.EventHandler(this.cbMedico_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txtPreco.Location = new System.Drawing.Point(578, 250);
            this.txtPreco.Mask = "00,000.00";
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 27);
            this.txtPreco.TabIndex = 72;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txtCPF.Location = new System.Drawing.Point(228, 221);
            this.txtCPF.Mask = "00000000000";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(109, 27);
            this.txtCPF.TabIndex = 72;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtPesqCPF
            // 
            this.txtPesqCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPesqCPF.Location = new System.Drawing.Point(494, 332);
            this.txtPesqCPF.Mask = "00000000000";
            this.txtPesqCPF.Name = "txtPesqCPF";
            this.txtPesqCPF.Size = new System.Drawing.Size(108, 29);
            this.txtPesqCPF.TabIndex = 72;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAlterar.Location = new System.Drawing.Point(182, 289);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(153, 32);
            this.btnAlterar.TabIndex = 69;
            this.btnAlterar.Text = "Alterar Consulta";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnExcluir.Location = new System.Drawing.Point(341, 289);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(153, 32);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.Text = "Excluir Consulta";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.txtEspecialidade.FormattingEnabled = true;
            this.txtEspecialidade.Location = new System.Drawing.Point(228, 252);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(182, 28);
            this.txtEspecialidade.TabIndex = 73;
            this.txtEspecialidade.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // AgendarConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Medifarma.Properties.Resources.AgendaConsulta_Cliente_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 575);
            this.Controls.Add(this.txtEspecialidade);
            this.Controls.Add(this.txtPesqCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.cbMedico);
            this.Controls.Add(this.picVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnAgendarConsulta);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtConvenio);
            this.Controls.Add(this.btnPesqCPF);
            this.Controls.Add(this.dtDataPesq);
            this.Controls.Add(this.btnLocDataNasc);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.dtDataNasc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtPesPaciente);
            this.Controls.Add(this.btnPesqNome);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgendarConsultaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgendarConsultaMedica";
            this.Load += new System.EventHandler(this.AgendarConsultaMedica_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AgendarConsultaMedica_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AgendarConsultaMedica_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDataPesq;
        private System.Windows.Forms.Button btnLocDataNasc;
        private System.Windows.Forms.MaskedTextBox txtGenero;
        private System.Windows.Forms.DateTimePicker dtDataNasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPesPaciente;
        private System.Windows.Forms.Button btnPesqNome;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Button btnPesqCPF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button btnAgendarConsulta;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.PictureBox picVoltar;
        private System.Windows.Forms.ComboBox cbMedico;
        private System.Windows.Forms.MaskedTextBox txtPreco;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtPesqCPF;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ComboBox txtEspecialidade;
    }
}