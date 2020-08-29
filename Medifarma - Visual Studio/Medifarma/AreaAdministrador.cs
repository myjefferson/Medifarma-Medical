using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Medifarma
{
    public partial class AreaAdministrador : Form
    {
        public AreaAdministrador(string nomeAdm)
        {
            InitializeComponent();
            lblAdm.Text = nomeAdm;

        }

        private void AreaAdministrador_Load(object sender, EventArgs e)
        {
            MouseDown += new MouseEventHandler(AreaAdministrador_MouseDown);
            MouseMove += new MouseEventHandler(AreaAdministrador_MouseMove);
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            BuscarPaciente paciente = new BuscarPaciente();
            paciente.Show();
        }

        private void btnCadCliente(object sender, EventArgs e)
        {
            CadastroCliente cadastroCliente = new CadastroCliente();
            cadastroCliente.Show();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            LoginAdmin loginAdmin = new LoginAdmin();
            loginAdmin.Show();
            Hide();

        } 

        private void LeitorXML_Click(object sender, EventArgs e)
        {
            LeitorArquivoXML lerXML = new LeitorArquivoXML();
            lerXML.Show();
        }
        int x, y;
        private void AreaAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            {
                x = Left - MousePosition.X;
                y = Top - MousePosition.Y;
            }
        }

        private void AreaAdministrador_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button != MouseButtons.Left) return;
            {
                Left = x + MousePosition.X;
                Top = y + MousePosition.Y;
            }
        }
    }
}
