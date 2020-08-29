using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medifarma
{
    public partial class AgendarConsultaMedica : Form
    {
        Consulta c = new Consulta();
        AcessoDB acessoDB = new AcessoDB();
        public AgendarConsultaMedica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtDataNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AgendarConsultaMedica_Load(object sender, EventArgs e)
        {
            dtGridView.DataSource = acessoDB.CarregarDadosConsulta();
            dtGridView.Update();

            MouseDown += new MouseEventHandler(AgendarConsultaMedica_MouseDown);
            MouseMove += new MouseEventHandler(AgendarConsultaMedica_MouseMove);

            btnAgendarConsulta.Enabled = false;
            txtCodigo.ReadOnly = true;
        }
        int x, y;
        private void AgendarConsultaMedica_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            opcao = "inserir";
            MessageBox.Show("Clique em GRAVAR CONSULTA depois que terminar de preecher os campos", "ATENÇÂO");
            btnAgendarConsulta.Enabled = true;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            opcao = "alterar";
            MessageBox.Show("Depois que terminar de alterar os campos, Clique em GRAVAR CONSULTA", "ATENÇÂO");
            btnAgendarConsulta.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            opcao = "excluir";
            MessageBox.Show("Selecione a consulta na lista abaixo e depois clique em GRAVAR CONSULTA", "ATENÇÂO");
            btnAgendarConsulta.Enabled = true;
        }
        string opcao;
        private void btnAgendarConsulta_Click(object sender, EventArgs e)
        {
            if (cbMedico.Text == string.Empty || txtCPF.Text == string.Empty || txtEspecialidade.Text == string.Empty || txtConvenio.Text == string.Empty || txtGenero.Text == string.Empty || txtPreco.Text == "  .   ,  " || txtNome.Text == string.Empty)
            {
                MessageBox.Show("Por favor, Preencha todos os campos!", "ATENÇÃO");
            }

            else if (opcao.Equals("inserir"))
            {
                c.NomePaciente = txtNome.Text;
                c.DataNasc = dtDataNasc.Value;
                c.Genero = txtGenero.Text;
                c.CPF = txtCPF.Text;
                c.Especialidade = txtEspecialidade.Text;
                c.Medico = cbMedico.Text;
                c.Data = dtData.Value;
                c.Hora = dtHora.Value.ToString();
                c.Convenio = txtConvenio.Text;
                c.Preco = txtPreco.Text;

                acessoDB.InserirConsulta(c);
                dtGridView.DataSource = acessoDB.CarregarDadosConsulta();
                dtGridView.Update();

                MessageBox.Show("Usuario Cadastrado Com Sucesso!");
                btnAgendarConsulta.Enabled = false;
            }
            else if (opcao.Equals("alterar"))
            {
                c.Codigo = Convert.ToInt16(txtCodigo.Text);
                c.NomePaciente = txtNome.Text;
                c.DataNasc = dtDataNasc.Value;
                c.Genero = txtGenero.Text;
                c.CPF = txtCPF.Text;
                c.Especialidade = txtEspecialidade.Text;
                c.Medico = cbMedico.Text;
                c.Data = dtData.Value;
                c.Hora = dtHora.Value.ToString();
                c.Convenio = txtConvenio.Text;
                c.Preco = txtPreco.Text;

                acessoDB.AlterarConsulta(c);
                dtGridView.DataSource = acessoDB.CarregarDadosConsulta();
                dtGridView.Update();

                MessageBox.Show("Usuario Alterado Com Sucesso!");
                btnAgendarConsulta.Enabled = false;
            }

            else if (opcao.Equals("excluir"))
            {
                c.Codigo = Convert.ToInt16(txtCodigo.Text);

                acessoDB.DeletarConsulta(c);
                dtGridView.DataSource = acessoDB.CarregarDadosConsulta();
                dtGridView.Update();

                MessageBox.Show("Usuario Excluido Com Sucesso!");
                btnAgendarConsulta.Enabled = false;
            }


        }

        private void cbMedico_Click(object sender, EventArgs e)
        {
            SqlCommand cmdo = new SqlCommand();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.conexao;

            try
            {
                conn.Open();
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;
                cmdo.CommandText = "select * from Medicos";

                DataTable dt = new DataTable();
                SqlDataReader DR = cmdo.ExecuteReader();
                dt.Load(DR);

                cbMedico.DataSource = dt;
                cbMedico.DisplayMember = "Medicos";
            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnPesqCPF_Click(object sender, EventArgs e)
        {
            c.CPF = txtPesqCPF.Text;

            dtGridView.DataSource = acessoDB.PesquisarCPF(c.CPF);
            dtGridView.Update();
        }

        private void btnPesqNome_Click(object sender, EventArgs e)
        {
            c.NomePaciente = txtPesPaciente.Text;

            dtGridView.DataSource = acessoDB.PesquisarPorNomePaciente(c.NomePaciente);
            dtGridView.Update();
        }

        private void btnLocDataNasc_Click(object sender, EventArgs e)
        {
            c.DataNasc = dtDataPesq.Value;

            dtGridView.DataSource = acessoDB.PesquisarDataNasc(c.DataNasc);
            dtGridView.Update();
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = 0;

            linha = dtGridView.CurrentRow.Index;

            txtCodigo.Text = dtGridView[0, linha].Value.ToString();
            txtNome.Text = dtGridView[1, linha].Value.ToString();
            dtDataNasc.Text = dtGridView[2, linha].Value.ToString();
            txtGenero.Text = dtGridView[3, linha].Value.ToString();
            txtConvenio.Text = dtGridView[4, linha].Value.ToString();
            txtCPF.Text = dtGridView[5, linha].Value.ToString();
            txtEspecialidade.Text = dtGridView[6, linha].Value.ToString();
            cbMedico.Text = dtGridView[7, linha].Value.ToString();
            dtData.Text = dtGridView[8, linha].Value.ToString();
            dtHora.Text = dtGridView[9, linha].Value.ToString();
            txtPreco.Text = dtGridView[10, linha].Value.ToString();

        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (VCPF.ValidaCPF(txtCPF.Text))
            {
                MessageBox.Show("CPF Válido");
            }
            else
            {
                MessageBox.Show("CPF Inválido");
                txtCPF.Focus();
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.conexao;
            try
            {
                conexao.Open();
                SqlCommand cmd = new SqlCommand("select * from Esp", conexao);

                SqlDataReader DR = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(DR);

                txtEspecialidade.DataSource = dt;
                txtEspecialidade.DisplayMember = "Nome";
                txtEspecialidade.Update();
            }
            catch
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void AgendarConsultaMedica_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }
    }
}
