using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Medifarma
{
    public partial class CadastroCliente : Form
    {
        string opcao;

        AcessoDB acessoDB = new AcessoDB();
        Cliente c = new Cliente();
        public CadastroCliente()
        {
            InitializeComponent();
        }

        string endereco;
        Image voltarNormal;
        Image voltarDown;
        Image voltarEnter;
        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            dtGridView.DataSource = acessoDB.CarregarDadosCliente();
            dtGridView.Update();

            endereco = Application.StartupPath + @"\imagens";
            voltarDown = Image.FromFile(endereco + @"\voltarDown.png");
            voltarEnter = Image.FromFile(endereco + @"\voltarEnter.png");
            voltarNormal = Image.FromFile(endereco + @"\voltarNormal.png");

            picVoltar.BackgroundImage = voltarNormal;

            DataCad.MaxDate = DateTime.Now;

            MouseDown += new MouseEventHandler(CadastroCliente_MouseDown);
            MouseMove += new MouseEventHandler(CadastroCliente_MouseMove);

            btnCadastrar.Enabled = false;
            btnAdicionarFoto.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG FIles(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtImagen.Text = foto; //Endereço do local da imagem
                picFoto.ImageLocation = foto;
            }
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            if (opcao.Equals("inserir"))
            {
                if (txtImagen.Text == "")
                {
                    MessageBox.Show("Porfavor, adicione uma foto e certifique-se de que \ntodos os campos estão preenchidos!", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    byte[] imagembyte = null;
                    FileStream fstream = new FileStream(txtImagen.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);

                    imagembyte = br.ReadBytes((int)fstream.Length);

                    c.Nome = txtNome.Text;
                    c.Logi = txtUsuario.Text;
                    c.Senha = mskSenha.Text;
                    c.DataCad = DataCad.Value;
                    c.Foto = imagembyte;

                    acessoDB.InserirCliente(c);
                    dtGridView.DataSource = acessoDB.CarregarDadosCliente();
                    dtGridView.Update();

                    btnCadastrar.Enabled = false;
                    btnAdicionarFoto.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnCadastrar.Text = "Botão Principal";
                    AtivarBotoesIAE();
                }
            }

            if (opcao.Equals("alterar"))
            {
                c.CodCli = Convert.ToInt16(txtCodigo.Text);
                c.Nome = txtNome.Text;
                c.Logi = txtUsuario.Text;
                c.Senha = mskSenha.Text;
                c.DataCad = DataCad.Value;

                acessoDB.AlterarCliente(c);
                dtGridView.DataSource = acessoDB.CarregarDadosCliente();
                dtGridView.Update();

                MessageBox.Show("Usuario Cadastrado Com Sucesso!");
                btnCadastrar.Enabled = false;
                btnAdicionarFoto.Enabled = false;
                btnCancelar.Enabled = false;
                btnCadastrar.Text = "Botão Principal";
                AtivarBotoesIAE();
            }

            if (opcao.Equals("excluir"))
            {
                c.CodCli = Convert.ToInt16(txtCodigo.Text);

                acessoDB.DeletarCliente(c);
                dtGridView.DataSource = acessoDB.CarregarDadosCliente();
                dtGridView.Update();

                MessageBox.Show("Usuario Cadastrado Com Sucesso!");
                btnCadastrar.Text = "Botão Principal";
                btnCancelar.Enabled = false;
                btnCadastrar.Enabled = false;
                btnAdicionarFoto.Enabled = false;

                AtivarBotoesIAE();
            }
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            opcao = "inserir";
            MessageBox.Show("Clique em CADASTRAR depois que terminar de preecher os campos", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Enabled = true;
            btnAdicionarFoto.Enabled = true;
            btnCancelar.Enabled = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            HabilitarTodosCampos();

        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            opcao = "alterar";
            MessageBox.Show("Clique em SALVAR ALTERAÇÕES depois que terminar de preecher os campos", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnCadastrar.Text = "Salvar Alterações";
            btnCadastrar.Enabled = true;
            btnAdicionarFoto.Enabled = true;
            btnCancelar.Enabled = true;

            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
            HabilitarTodosCampos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            opcao = "excluir";
            MessageBox.Show("Clique em CONFIRMAR EXCLUSÃO depois que terminar de preecher os campos", "ATENÇÂO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnCadastrar.Text = "Confirmar Exclusão";
            btnCadastrar.Enabled = true;
            btnAdicionarFoto.Enabled = true;
            btnCancelar.Enabled = true;

            btnAlterar.Enabled = false;
            btnInserir.Enabled = false;
            HabilitarTodosCampos();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicVoltar_MouseDown(object sender, MouseEventArgs e)
        {
            picVoltar.BackgroundImage = voltarDown;
        }

        private void PicVoltar_MouseEnter(object sender, EventArgs e)
        {
            picVoltar.BackgroundImage = voltarEnter;
        }

        private void PicVoltar_MouseLeave(object sender, EventArgs e)
        {
            picVoltar.BackgroundImage = voltarNormal;
        }

        private void PicVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        int x, y;
        private void CadastroCliente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }

        private void DtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int linha = 0;

            linha = dtGridView.CurrentRow.Index;
            txtCodigo.Text = dtGridView[0, linha].Value.ToString();
            txtNome.Text = dtGridView[1, linha].Value.ToString();
            txtUsuario.Text = dtGridView[2, linha].Value.ToString();
            mskSenha.Text = dtGridView[3, linha].Value.ToString();
            DataCad.Text = dtGridView[5, linha].Value.ToString();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Properties.Settings.Default.conexao;
            conexao.Open();
            SqlCommand foto = new SqlCommand("select Foto from Cliente where Nome = @Nome", conexao);
            foto.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = txtNome.Text;
            SqlDataReader DR = foto.ExecuteReader();

            Image imagem = null;

            if (DR.Read())
            {
                byte[] fotoPerfil = (byte[])DR["Foto"];
                MemoryStream ms = new MemoryStream(fotoPerfil);
                imagem = Image.FromStream(ms);
                picFoto.Image = Image.FromStream(ms);
            }
            conexao.Close();
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            mskSenha.UseSystemPasswordChar = false;
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            mskSenha.UseSystemPasswordChar = true;
        }

        private void DtGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('•', e.Value.ToString().Length);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            var escolha = MessageBox.Show("Tem certeza que deseja cancelar?", "CANCELAR PREENCHIMENTO DO FORMULÁRIO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (escolha == DialogResult.Yes)
            {
                LimparCamposESomenteLeitura();
                btnCancelar.Enabled = false;
                btnCadastrar.Enabled = false;
                btnCadastrar.Text = "Botão Principal";
                btnInserir.Enabled = true;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void CadastroCliente_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }
        void LimparCamposESomenteLeitura()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtUsuario.Clear();
            mskSenha.Clear();
            txtImagen.Clear();

            txtNome.ReadOnly = true;
            txtUsuario.ReadOnly = true;
            mskSenha.ReadOnly = true;
            DataCad.Enabled = false;
            picFoto.Image = null;
        }

        void HabilitarTodosCampos()
        {
            txtNome.ReadOnly = false;
            txtUsuario.ReadOnly = false;
            mskSenha.ReadOnly = false;
            DataCad.Enabled = true;
        }

        void AtivarBotoesIAE()
        {
            btnInserir.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}
