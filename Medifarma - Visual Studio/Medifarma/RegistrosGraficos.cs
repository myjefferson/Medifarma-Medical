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
using System.Data.Sql;
using System.Collections;

namespace Medifarma
{
    public partial class RegistrosGraficos : Form
    {
        SqlConnection conexao = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;

        public RegistrosGraficos()
        {
            InitializeComponent();
        }

        private void RegistrosGraficos_Load(object sender, EventArgs e)
        {
            GrafColsultasMedicos();
        }
        ArrayList Consultas = new ArrayList();
        private void GrafColsultasMedicos()
        {
            conexao.ConnectionString = Properties.Settings.Default.conexao;
            conexao.Open();
            cmd = new SqlCommand("VeneuzaLista", conexao);
            cmd.CommandType = CommandType.StoredProcedure;

            /*dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Consultas.Add(dr.GetString(0));
            }
            ConsutasMedico.Series[0].Points.DataBindXY(Consultas);
            dr.Close();
            conexao.Close();*/
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
