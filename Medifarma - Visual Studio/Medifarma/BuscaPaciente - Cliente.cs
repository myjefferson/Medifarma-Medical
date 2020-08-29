using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medifarma
{
    public partial class BuscarPacienteCliente : Form
    {
        AcessoDB acesso = new AcessoDB();
        Cliente c = new Cliente();
        Paciente p = new Paciente();
        public BuscarPacienteCliente()
        {
            InitializeComponent();
        }
        Image Enter, Normal, Down;
        string imagens;
        private void BuscarPacienteCliente_Load(object sender, EventArgs e)
        {
            dtGridView.DataSource = acesso.CarregarDadosPacientes();
            dtGridView.Update();
            CamposDesabilitados();

            MouseDown += new MouseEventHandler(BuscarPacienteCliente_MouseDown);
            MouseMove += new MouseEventHandler(BuscarPacienteCliente_MouseMove);

            imagens = Application.StartupPath + @"\imagens";

            Enter = Image.FromFile(imagens + @"\voltarCliEnter.png");
            Normal = Image.FromFile(imagens + @"\voltarCliNormal.png");
            Down = Image.FromFile(imagens + @"\voltarCliDown.png");
        }

        private void DtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void BtnPesqNome_Click(object sender, EventArgs e)
        {
            dtGridView.DataSource = acesso.PesquisarPorNomePaciente(txtPesPaciente.Text);
            dtGridView.Update();
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

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtDataNasc_ValueChanged(object sender, EventArgs e)
        {

        }
        int x, y;

        private void PicVoltar_MouseEnter(object sender, EventArgs e)
        {
            picVoltar.BackgroundImage = Enter;
        }

        private void PicVoltar_MouseLeave(object sender, EventArgs e)
        {
            picVoltar.BackgroundImage = Normal;
        }

        private void PicVoltar_MouseDown(object sender, MouseEventArgs e)
        {
            picVoltar.BackgroundImage = Down;
        }

        private void PicVoltar_MouseUp(object sender, MouseEventArgs e)
        {
            picVoltar.BackgroundImage = Normal;
        }

        private void PicVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscarPacienteCliente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarPacienteCliente_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }
    }
}
