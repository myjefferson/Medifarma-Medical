using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Medifarma
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }
        string endereco;
        Image ClienteNormal;
        Image ClienteDown;
        Image ClienteEnter;

        Image voltarNormal;
        Image voltarDown;
        Image voltarEnter;

        Image OlhoEnter;
        Image OlhoDown;
        Image OlhoNormal;
        private void LoginUsuario_Load(object sender, EventArgs e)
        {
            endereco = Application.StartupPath + @"\imagens";
            ClienteDown = Image.FromFile(endereco + @"\btnLogCliDown.png");
            ClienteEnter = Image.FromFile(endereco + @"\btnLogCliEnter.png");
            ClienteNormal = Image.FromFile(endereco + @"\btnLogCliNormal.png");

            voltarDown = Image.FromFile(endereco + @"\voltarCliDown.png");
            voltarEnter = Image.FromFile(endereco + @"\voltarCliEnter.png");
            voltarNormal = Image.FromFile(endereco + @"\voltarCliNormal.png");

            OlhoDown = Image.FromFile(endereco + @"\OlhoSenhaClick.png");
            OlhoEnter = Image.FromFile(endereco + @"\OlhoSenhaEnter.png");
            OlhoNormal = Image.FromFile(endereco + @"\OlhoSenha.png");

            picVoltar.BackgroundImage = voltarNormal;
            picClienteLog.BackgroundImage = ClienteNormal;
            picOlhoSenha.BackgroundImage = OlhoNormal;

            MouseDown += new MouseEventHandler(LoginUsuario_MouseDown);
            MouseMove += new MouseEventHandler(LoginUsuario_MouseMove);
        }

        private void LoginUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicClienteLog_MouseDown(object sender, MouseEventArgs e)
        {
            picClienteLog.BackgroundImage = ClienteDown;
        }

        private void PicClienteLog_MouseEnter(object sender, EventArgs e)
        {
            picClienteLog.BackgroundImage = ClienteEnter;
        }

        private void PicClienteLog_MouseLeave(object sender, EventArgs e)
        {
            picClienteLog.BackgroundImage = ClienteNormal;
        }

        private void PicClienteLog_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {

                conn.Open();
                SqlCommand login = new SqlCommand("select count(*) from Cliente where Logi = @Logi", conn);
                login.Parameters.Add("@Logi", SqlDbType.VarChar, 40).Value = txtLogin.Text;

                int contagem = (int)login.ExecuteScalar();

                if (contagem > 0)
                {
                    SqlCommand senha = new SqlCommand("select count(*) from Cliente where Senha = @Senha", conn);
                    senha.Parameters.Add("@Senha", SqlDbType.VarChar, 6).Value = txtSenha.Text;

                    int cont = (int)senha.ExecuteScalar();

                    if (cont > 0)
                    {
                        SqlCommand nome = new SqlCommand("select Nome from Cliente where Logi = @Logi", conn);
                        nome.Parameters.Add("@Logi", SqlDbType.VarChar, 50).Value = txtLogin.Text;
                        string nomeCliente = (string)nome.ExecuteScalar();

                        SqlCommand foto = new SqlCommand("select Foto from Cliente where Logi = @Logi", conn);
                        foto.Parameters.Add("@Logi", SqlDbType.VarChar, 50).Value = txtLogin.Text;
                        SqlDataReader DR = foto.ExecuteReader();

                        Image imagem = null;

                        if (DR.Read())
                        {
                            byte[] fotoPerfil = (byte[])DR["Foto"];
                            MemoryStream ms = new MemoryStream(fotoPerfil);
                            imagem = Image.FromStream(ms);
                        }
                        
                        AreaCliente cliente = new AreaCliente(nomeCliente, imagem);
                        cliente.Show();
                        Hide();

                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!","ATENÇÂO!");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario não cadastrado!","ATENÇÂO!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Inserção"+ex);
            }
            finally
            {
                conn.Close();
            }
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
            MedifarmaArea medifarmaArea = new MedifarmaArea();
            medifarmaArea.Show();
            Hide();
        }
        int x, y;

        private void LoginUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }

        private void PicOlhoSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            picOlhoSenha.BackgroundImage = OlhoDown;
        }

        private void PicOlhoSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            picOlhoSenha.BackgroundImage = OlhoNormal;
        }

        private void PicOlhoSenha_MouseEnter(object sender, EventArgs e)
        {
            picOlhoSenha.BackgroundImage = OlhoEnter;
        }

        private void PicOlhoSenha_MouseLeave(object sender, EventArgs e)
        {
            picOlhoSenha.BackgroundImage = OlhoNormal;
        }

        private void LoginUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }
    }
}
