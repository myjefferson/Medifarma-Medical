using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Medifarma
{
    public partial class BuscarPaciente : Form
    {
        string opcao;
        SqlConnection conexao = new SqlConnection();
        AcessoDB acesso = new AcessoDB();
        Cliente c = new Cliente();
        Paciente p = new Paciente();
        public BuscarPaciente()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Image Enter, Normal, Down;
        string imagens;
        private void BuscarPaciente_Load(object sender, EventArgs e)
        {
            dtGridView.DataSource = acesso.CarregarDadosPacientes();
            dtGridView.Update();
            btnGravar.Enabled = false;
            btnCancelar.Enabled = false;
            CamposDesabilitados();
            imagens = Application.StartupPath + @"\imagens";

            Enter = Image.FromFile(imagens + @"\voltarEnter.png");
            Normal = Image.FromFile(imagens + @"\voltarNormal.png");
            Down = Image.FromFile(imagens + @"\voltarDown.png");

            MouseDown += new MouseEventHandler(BuscarPaciente_MouseDown);
            MouseMove += new MouseEventHandler(BuscarPaciente_MouseMove);
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = 0;

            linha = dtGridView.CurrentRow.Index;

            txtCodigo.Text = dtGridView[0, linha].Value.ToString();
            txtNome.Text = dtGridView[1, linha].Value.ToString();
            txtSobrenome.Text = dtGridView[2, linha].Value.ToString();
            dtDataNasc.Text = dtGridView[3, linha].Value.ToString();
            txtEmail.Text = dtGridView[4, linha].Value.ToString();
            txtGenero.Text = dtGridView[5, linha].Value.ToString();
            txtConvenio.Text = dtGridView[6, linha].Value.ToString();
            txtDescricao.Text = dtGridView[7, linha].Value.ToString();
            //txtEndereco.Text = dtGridView[8, linha].Value.ToString();
            txtCPF.Text = dtGridView[9, linha].Value.ToString();

        }

        private void dtDataNasc_ValueChanged(object sender, EventArgs e)
        {

            dtDataNasc.MaxDate = DateTime.Today;
        }


        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesqNome_Click(object sender, EventArgs e)
        {
            dtGridView.DataSource = acesso.PesquisarPorNomePaciente(txtPesPaciente.Text);
            dtGridView.Update();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            opcao = "inserir";
            MessageBox.Show("Clique em CADASTRAR depois que terminar de preecher os campos", "ATENÇÂO");
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAltera.Enabled = false;
            btnExcluir.Enabled = false;
            CamposHabilitados();
        }
        private void BtnAltera_Click(object sender, EventArgs e)
        {
            opcao = "alterar";
            MessageBox.Show("Clique em CADASTRAR depois que terminar de alterar os campos", "ATENÇÂO");
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
            CamposHabilitados();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            opcao = "excluir";
            MessageBox.Show("Selecione na lista abaixo o paciente que deseja excluir, depois clique em GRAVAR", "ATENÇÂO");
            btnGravar.Enabled = true;
            btnCancelar.Enabled = true;
            btnInserir.Enabled = false;
            btnAltera.Enabled = false;
            CamposHabilitados();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (opcao.Equals("inserir"))
            {

                p.Nome = txtNome.Text;
                p.Sobrenome = txtSobrenome.Text;
                p.DataNasc = dtDataNasc.Value;
                p.Email = txtEmail.Text;
                p.Genero = txtGenero.Text;
                p.Convenio = txtConvenio.Text;
                p.Descricao = txtDescricao.Text;
                p.CPF = txtCPF.Text;

                acesso.InserirPaciente(p);
                dtGridView.DataSource = acesso.CarregarDadosPacientes();
                dtGridView.Update();

                MessageBox.Show("Usuario Cadastrado Com Sucesso!");
                btnGravar.Enabled = false;

                CamposDesabilitados();
                LimparCampos();
            }

            if (opcao.Equals("alterar"))
            {
                p.Cod = Convert.ToInt16(txtCodigo.Text);
                p.Nome = txtNome.Text;
                p.Sobrenome = txtSobrenome.Text;
                p.DataNasc = dtDataNasc.Value;
                p.Email = txtEmail.Text;
                p.Genero = txtGenero.Text;
                p.Convenio = txtConvenio.Text;
                p.Descricao = txtDescricao.Text;
                p.CPF = txtCPF.Text;

                acesso.AlterarPaciente(p);
                dtGridView.DataSource = acesso.CarregarDadosPacientes();
                dtGridView.Update();

                MessageBox.Show("Usuario Alterado Com Sucesso!");
                btnGravar.Enabled = false;

                CamposDesabilitados();
                LimparCampos();
            }

            if (opcao.Equals("excluir"))
            {
                p.Cod = Convert.ToInt16(txtCodigo.Text);

                acesso.DeletarPaciente(p);
                dtGridView.DataSource = acesso.CarregarDadosPacientes();
                dtGridView.Update();

                MessageBox.Show("Usuario Excluido Com Sucesso!");
                btnGravar.Enabled = false;

                CamposDesabilitados();
                LimparCampos();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (VEmail.validarEmail(txtEmail.Text))
            {
                MessageBox.Show("Email válido");
            }
            else
            {
                MessageBox.Show("Email Inválido");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (VCPF.ValidaCPF(txtCPF.Text))
            {
                MessageBox.Show("CPF Válido");
            }
            else
            {
                MessageBox.Show("CPF Inválido");
            }
        }

        void CamposHabilitados()
        {
            txtNome.ReadOnly = false;
            txtSobrenome.ReadOnly = false;
            dtDataNasc.Enabled = true;
            txtEmail.ReadOnly = false;
            txtGenero.ReadOnly = false;
            txtConvenio.ReadOnly = false;
            txtDescricao.ReadOnly = false;
            txtCPF.ReadOnly = false;
        }

        void CamposDesabilitados()
        {
            txtNome.ReadOnly = true;
            txtSobrenome.ReadOnly = true;
            dtDataNasc.Enabled = false;
            txtEmail.ReadOnly = true;
            txtGenero.ReadOnly = true;
            txtConvenio.ReadOnly = true;
            txtDescricao.ReadOnly = true;
            txtCPF.ReadOnly = true;
        }

        void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSobrenome.Clear();
            dtDataNasc.MinDate = DateTime.MinValue;
            txtEmail.Clear();
            txtGenero.Clear();
            txtConvenio.Clear();
            txtDescricao.Clear();
            txtCPF.Clear();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        int x, y;
        private void BuscarPaciente_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void PicVoltar_MouseDown(object sender, MouseEventArgs e)
        {
            picVoltar.BackgroundImage = Down;
        }

        private void PicVoltar_MouseUp(object sender, MouseEventArgs e)
        {
            picVoltar.BackgroundImage = Enter;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja cancelar?", "CANCELAR PREENCHIMENTO DO FORMULÁRIO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                CamposDesabilitados();
                LimparCampos();
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                btnInserir.Enabled = true;
                btnAltera.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {

            }

        }

        private void PicVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PicVoltar_MouseEnter(object sender, EventArgs e)
        {
            picVoltar.BackgroundImage = Enter;
        }

        private void PicVoltar_MouseLeave(object sender, EventArgs e)
        {
            picVoltar.BackgroundImage = Normal;
        }

        private void BuscarPaciente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }
    }
}

