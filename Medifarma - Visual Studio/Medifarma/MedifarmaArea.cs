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
    public partial class MedifarmaArea : Form
    {
        public MedifarmaArea()
        {
            InitializeComponent();
        }
        Image admClick;
        Image admEnter;
        Image admLeave;

        Image usuarioClick;
        Image usuarioEnter;
        Image usuarioLeave;

        string endereco = "";

        private void Escolha_Load(object sender, EventArgs e)
        {
            endereco = Application.StartupPath + @"\imagens";
            admClick = Image.FromFile(endereco + @"\admin-ButtonClick.png");
            admEnter = Image.FromFile(endereco + @"\admin-ButtonEnter.png");
            admLeave = Image.FromFile(endereco + @"\admin-ButtonLeave.png");

            usuarioClick = Image.FromFile(endereco + @"\usuario-ButtonClick.png");
            usuarioEnter = Image.FromFile(endereco + @"\usuario-ButtonEnter.png");
            usuarioLeave = Image.FromFile(endereco + @"\usuario-ButtonLeave.png");

            picUsuario.BackgroundImage = usuarioLeave;
            picAdmin.BackgroundImage = admLeave;

            MouseDown += new MouseEventHandler(Escolha_MouseDown);
            MouseMove += new MouseEventHandler(Escolha_MouseMove);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            LoginUsuario loginUsuario = new LoginUsuario();
            loginUsuario.Show();
            this.Hide();
        }

        private void PicUsuario_MouseEnter(object sender, EventArgs e)
        {
            picUsuario.BackgroundImage = usuarioEnter;
        }

        private void PicUsuario_MouseLeave(object sender, EventArgs e)
        {
            picUsuario.BackgroundImage = usuarioLeave;
        }

        private void PicUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            picUsuario.BackgroundImage = usuarioClick;
        }

        private void PicUsuario_Click(object sender, EventArgs e)
        {
            LoginUsuario loginUsuario = new LoginUsuario();
            loginUsuario.Show();
            this.Hide();
        }

        private void PicAdmin_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
            this.Hide();
        }

        private void PicAdmin_MouseEnter(object sender, EventArgs e)
        {
            picAdmin.BackgroundImage = admEnter;
        }

        private void PicAdmin_MouseLeave(object sender, EventArgs e)
        {
            picAdmin.BackgroundImage = admLeave;
        }

        private void PicAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            picAdmin.BackgroundImage = admClick;
        }
        int x, y;

        private void Escolha_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }

        private void Fechar_MouseEnter(object sender, EventArgs e)
        {
            Fechar.BackColor = Color.Red;
            Fechar.ForeColor = Color.White;
        }

        private void Fechar_MouseLeave(object sender, EventArgs e)
        {
            Fechar.BackColor = Color.Transparent;

        }

        private void Fechar_MouseUp(object sender, MouseEventArgs e)
        {
            Fechar.BackColor = Color.Red;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Minimizar_MouseEnter(object sender, EventArgs e)
        {
            Minimizar.BackColor = Color.Gray;
            Minimizar.ForeColor = Color.White;
        }

        private void Minimizar_MouseLeave(object sender, EventArgs e)
        {
            Minimizar.BackColor = Color.Transparent;
        }

        private void Escolha_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }
    }
}
