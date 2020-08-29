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

namespace Medifarma
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }
        string endereco;
        Image AdmNormal;
        Image AdmDown;
        Image AdmEnter;

        Image voltarNormal;
        Image voltarDown;
        Image voltarEnter;

        Image OlhoEnter;
        Image OlhoDown;
        Image OlhoNormal;
        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            endereco = Application.StartupPath + @"\imagens";
            AdmDown = Image.FromFile(endereco + @"\btnLogAdmDown.png");
            AdmEnter = Image.FromFile(endereco + @"\btnLogAdmEnter.png");
            AdmNormal = Image.FromFile(endereco + @"\btnLogAdmNormal.png");

            voltarDown = Image.FromFile(endereco + @"\voltarDown.png");
            voltarEnter = Image.FromFile(endereco + @"\voltarEnter.png");
            voltarNormal = Image.FromFile(endereco + @"\voltarNormal.png");

            OlhoDown = Image.FromFile(endereco + @"\OlhoSenhaClick.png");
            OlhoEnter = Image.FromFile(endereco + @"\OlhoSenhaEnter.png");
            OlhoNormal = Image.FromFile(endereco + @"\OlhoSenha.png");

            picAdmLog.BackgroundImage = AdmNormal;
            picVoltar.BackgroundImage = voltarNormal;
            picOlhoSenha.BackgroundImage = OlhoNormal;

            MouseDown += new MouseEventHandler(LoginAdmin_MouseDown);
            MouseMove += new MouseEventHandler(LoginAdmin_MouseMove);
        }

        private void LoginAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {

                conn.Open();
                SqlCommand login = new SqlCommand("select count(*) from Adm where Logi = @Logi", conn);
                login.Parameters.Add("@Logi", SqlDbType.VarChar, 50).Value = txtLogin.Text;

                int contagem = (int)login.ExecuteScalar();

                if (contagem > 0)
                {
                    MessageBox.Show("Administrador não encontrado!", "ATENÇÃO!");
                    SqlCommand senha = new SqlCommand("select count(*) from Adm where Senha = @Senha", conn);
                    senha.Parameters.Add("@Senha", SqlDbType.VarChar, 6).Value = txtSenha.Text;

                    int cont = (int)senha.ExecuteScalar();

                    if (cont > 0)
                    {

                        SqlCommand nome = new SqlCommand("select Nome from Adm where Logi = @Logi", conn);
                        nome.Parameters.Add("@Logi", SqlDbType.VarChar, 50).Value = txtLogin.Text;
                        string nomeAdm = (string)nome.ExecuteScalar();

                        MessageBox.Show("Senha incorreta!", "ATENÇÃO!");
                        AreaAdministrador administrador = new AreaAdministrador(nomeAdm);
                        administrador.Show();
                        Hide();

                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!","ATENÇÃO!");
                    }

                }
                else
                {
                    MessageBox.Show("Administrador não encontrado!","ATENÇÃO!");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            picOlhoSenha.BackgroundImage = OlhoDown;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            picOlhoSenha.BackgroundImage = OlhoNormal;
        }
        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void PicAdmLog_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {

                conn.Open();
                SqlCommand login = new SqlCommand("select count(*) from Adm where Logi = @Logi", conn);
                login.Parameters.Add("@Logi", SqlDbType.VarChar, 50).Value = txtLogin.Text;

                int contagem = (int)login.ExecuteScalar();

                if (contagem > 0)
                {
                    MessageBox.Show("email ok");
                    SqlCommand senha = new SqlCommand("select count(*) from Adm where Senha = @Senha", conn);
                    senha.Parameters.Add("@Senha", SqlDbType.VarChar, 6).Value = txtSenha.Text;

                    int cont = (int)senha.ExecuteScalar();

                    if (cont > 0)
                    {

                        SqlCommand nome = new SqlCommand("select Nome from Adm where Logi = @Logi", conn);
                        nome.Parameters.Add("@Logi", SqlDbType.VarChar, 50).Value = txtLogin.Text;
                        string nomeAdm = (string)nome.ExecuteScalar();

                        MessageBox.Show("senha ok");
                        AreaAdministrador administrador = new AreaAdministrador(nomeAdm);
                        administrador.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario não cadastrada!");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void PicAdmLog_MouseEnter(object sender, EventArgs e)
        {
            picAdmLog.BackgroundImage = AdmEnter;
        }

        private void PicAdmLog_MouseLeave(object sender, EventArgs e)
        {
            picAdmLog.BackgroundImage = AdmNormal;
        }

        private void PicAdmLog_MouseDown(object sender, MouseEventArgs e)
        {
            picAdmLog.BackgroundImage = AdmDown;
        }

        private void PicAdmLog_MouseUp(object sender, MouseEventArgs e)
        {
            picAdmLog.BackgroundImage = AdmEnter;
        }

        private void PicVoltar_MouseEnter(object sender, EventArgs e)
        {
            picVoltar.BackgroundImage = voltarEnter;
        }

        private void PicVoltar_MouseLeave(object sender, EventArgs e)
        {
            picVoltar.BackgroundImage = voltarNormal;
        }
        private void PicVoltar_MouseDown(object sender, MouseEventArgs e)
        {
            picVoltar.BackgroundImage = voltarDown;
        }

        private void PicVoltar_Click(object sender, EventArgs e)
        {
            MedifarmaArea medifarmaArea = new MedifarmaArea();
            medifarmaArea.Show();
            Hide();
        }
        int x, y;
        private void LoginAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }

        private void PicOlhoSenha_MouseEnter(object sender, EventArgs e)
        {
            picOlhoSenha.BackgroundImage = OlhoEnter;
        }

        private void PicOlhoSenha_MouseLeave(object sender, EventArgs e)
        {
            picOlhoSenha.BackgroundImage = OlhoNormal;
        }

        private void LoginAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }
    }
}
