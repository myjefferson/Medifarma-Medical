using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medifarma
{
    public partial class AreaCliente : Form
    {
        public AreaCliente(string nomeCliente, Image fotoPerfil)
        {            
            InitializeComponent();

            lblNome.Text = nomeCliente;
            picFotoPerfil.Image = fotoPerfil;
        }

        private void AreaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AreaCliente_Load(object sender, EventArgs e)
        {
            MouseDown += new MouseEventHandler(AreaCliente_MouseDown);
            MouseMove += new MouseEventHandler(AreaCliente_MouseMove);
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            BuscarPacienteCliente buscarPaciente = new BuscarPacienteCliente();
            buscarPaciente.Show();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            LoginUsuario loginUsuario = new LoginUsuario();
            loginUsuario.Show();
            Hide();
        }
        int x, y;
        private void AreaCliente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }

        private void AgendaConsulta_Click(object sender, EventArgs e)
        {
            AgendarConsultaMedica consultaMedica = new AgendarConsultaMedica();
            consultaMedica.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrosGraficos registrosGraficos = new RegistrosGraficos();
            registrosGraficos.Show();
        }

        private void picFotoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void AreaCliente_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }
    }
}
