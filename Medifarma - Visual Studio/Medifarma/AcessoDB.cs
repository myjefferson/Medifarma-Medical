using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Medifarma
{
    class AcessoDB
    {
        SqlConnection conn = new SqlConnection();
        public DataTable CarregarDadosCliente() //CARREGAR DADOS CLIENTE-------------------
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlCommand cmdo = new SqlCommand();
                cmdo.CommandType = CommandType.Text;
                cmdo.CommandText = "select * from Cliente";
                cmdo.Connection = conn;
                SqlDataReader DR = cmdo.ExecuteReader();
                dt.Load(DR);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public void InserirCliente(Cliente c) //ADM INSERE O CLIENTE
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (Nome,Logi,Senha,DataCad,Foto) VALUES (@Nome,@Logi,@Senha,@DataCad,@Foto)", conn);

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = c.Nome;
                cmd.Parameters.Add("@Logi", SqlDbType.VarChar, 50).Value = c.Logi;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar, 6).Value = c.Senha;
                cmd.Parameters.Add("@DataCad", SqlDbType.Date).Value = c.DataCad;
                cmd.Parameters.Add("@Foto", SqlDbType.Binary).Value = c.Foto;

                cmd.ExecuteNonQuery();
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
        public void AlterarCliente(Cliente c) //ADM ALTERA O CLIENTE
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Cliente SET Nome = @Nome, Logi = @Logi, Senha = @Senha, DataCad = @DataCad WHERE CodCli = @CodCli", conn);

                cmd.Parameters.Add("@CodCli", SqlDbType.Int, 18).Value = c.CodCli;
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = c.Nome;
                cmd.Parameters.Add("@Logi", SqlDbType.VarChar, 50).Value = c.Logi;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar, 6).Value = c.Senha;
                cmd.Parameters.Add("@DataCad", SqlDbType.Date).Value = c.DataCad;

                cmd.ExecuteNonQuery();
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
        public void DeletarCliente(Cliente c) //ADM DELETA O CLIENTE
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE Cliente WHERE CodCli = @CodCli", conn);

                cmd.Parameters.Add("@CodCli", SqlDbType.VarChar, 50).Value = c.CodCli;

                cmd.ExecuteNonQuery();
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

        public DataTable CarregarDadosPacientes() //CARREGAR DADOS PACIENTES-------------------
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlCommand cmdo = new SqlCommand();
                cmdo.CommandType = CommandType.Text;
                cmdo.CommandText = "select * from Paciente";
                cmdo.Connection = conn;
                SqlDataReader DR = cmdo.ExecuteReader();
                dt.Load(DR);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public void InserirPaciente(Paciente p) //ADM INSERE O PACIENTE
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Paciente (Nome, SobreN, DataNasc, Email, Genero, Conv, Descricao, CPF) " +
                                                              "VALUES (@Nome, @SobreN, @DataNasc, @Email, @Genero, @Conv, @Descricao, @CPF)", conn);

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = p.Nome;
                cmd.Parameters.Add("@SobreN", SqlDbType.VarChar, 50).Value = p.Sobrenome;
                cmd.Parameters.Add("@DataNasc", SqlDbType.Date).Value = p.DataNasc;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 70).Value = p.Email;
                cmd.Parameters.Add("@Genero", SqlDbType.Char, 1).Value = p.Genero;
                cmd.Parameters.Add("@Conv", SqlDbType.VarChar, 50).Value = p.Convenio;
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar, 50).Value = p.Descricao;
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar, 12).Value = p.CPF;

                cmd.ExecuteNonQuery();
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

        public void AlterarPaciente(Paciente p) //ADM ALTERA O PACIENTE
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Paciente SET Nome = @Nome, SobreN = @SobreN, DataNasc = @DataNasc, Email = @Email, Genero = @Genero, Conv = @Conv, Descricao = @Descricao, CPF = @CPF WHERE IdPac = @IdPac", conn);

                cmd.Parameters.Add("@IdPac", SqlDbType.Int,18).Value = p.Cod;
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = p.Nome;
                cmd.Parameters.Add("@SobreN", SqlDbType.VarChar, 50).Value = p.Sobrenome;
                cmd.Parameters.Add("@DataNasc", SqlDbType.Date).Value = p.DataNasc;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 70).Value = p.Email;
                cmd.Parameters.Add("@Genero", SqlDbType.Char, 1).Value = p.Genero;
                cmd.Parameters.Add("@Conv", SqlDbType.VarChar, 50).Value = p.Convenio;
                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar, 50).Value = p.Descricao;
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar, 12).Value = p.CPF;

                cmd.ExecuteNonQuery();
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

        public void DeletarPaciente(Paciente p) //ADM DELETA O PACIENTE
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete Paciente where IdPac = @IdPac", conn);

                cmd.Parameters.Add("@IdPac", SqlDbType.Int, 18).Value = p.Cod;

                cmd.ExecuteNonQuery();
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

        
        public DataTable PesquisarPorNomePaciente(string nome)
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Consulta where nome like '%" + nome + "%'", conn);

                SqlDataReader DR = cmd.ExecuteReader();
                dt.Load(DR);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable CarregarDadosConsulta()
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlCommand cmdo = new SqlCommand();
                cmdo.CommandType = CommandType.Text;
                cmdo.CommandText = "select * from Consulta";
                cmdo.Connection = conn;
                SqlDataReader DR = cmdo.ExecuteReader();
                dt.Load(DR);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public void InserirConsulta(Consulta c) //INSERE CONSULTA
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Consulta (Nome, DataNasc,  Genero, Conv, CPF, Espec, Medico, DataConsulta, Hora, Preco) " +
                                                             "VALUES (@Nome, @DataNasc, @Genero, @Conv, @CPF, @Espec, @Medico, @DataConsulta, @Hora, @Preco)", conn);

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = c.NomePaciente;
                cmd.Parameters.Add("@DataNasc", SqlDbType.Date).Value = c.DataNasc;
                cmd.Parameters.Add("@Genero", SqlDbType.Char, 1).Value = c.Genero;
                cmd.Parameters.Add("@Conv", SqlDbType.VarChar, 50).Value = c.Convenio;
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar, 12).Value = c.CPF;
                cmd.Parameters.Add("@Espec", SqlDbType.VarChar, 30).Value = c.Especialidade;
                cmd.Parameters.Add("@Medico", SqlDbType.VarChar, 40).Value = c.Medico;
                cmd.Parameters.Add("@DataConsulta", SqlDbType.Date).Value = c.Data;
                cmd.Parameters.Add("@Hora", SqlDbType.VarChar,15).Value = c.Hora;
                cmd.Parameters.Add("@Preco", SqlDbType.VarChar, 15).Value = c.Preco;

                cmd.ExecuteNonQuery();
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

        public void AlterarConsulta(Consulta c) //ALTERA CONSULTA
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Consulta SET Nome = @Nome, SobreN = @SobreN, DataNasc = @DataNasc, Email = @Email, Genero = @Genero, Conv = @Conv, Descricao = @Descricao, CPF = @CPF WHERE IdConsulta = @IdConsulta", conn);

                cmd.Parameters.Add("@IdConsulta", SqlDbType.Int, 18).Value = c.Codigo;
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar, 50).Value = c.NomePaciente;
                cmd.Parameters.Add("@DataNasc", SqlDbType.Date).Value = c.DataNasc;
                cmd.Parameters.Add("@Genero", SqlDbType.Char, 1).Value = c.Genero;
                cmd.Parameters.Add("@Conv", SqlDbType.VarChar, 50).Value = c.Convenio;
                cmd.Parameters.Add("@CPF", SqlDbType.VarChar, 12).Value = c.CPF;
                cmd.Parameters.Add("@Espec", SqlDbType.VarChar, 30).Value = c.Especialidade;
                cmd.Parameters.Add("@Medico", SqlDbType.VarChar, 40).Value = c.Medico;
                cmd.Parameters.Add("@DataConsulta", SqlDbType.Date).Value = c.Data;
                cmd.Parameters.Add("@Hora", SqlDbType.VarChar, 15).Value = c.Hora;
                cmd.Parameters.Add("@Preco", SqlDbType.VarChar, 15).Value = c.Preco;

                cmd.ExecuteNonQuery();
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

        public void DeletarConsulta(Consulta c) //DELETA CONSULTA
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE Consulta WHERE IdConsulta = @IdConsulta", conn);

                cmd.Parameters.Add("@IdConsulta", SqlDbType.Int, 18).Value = c.Codigo;

                cmd.ExecuteNonQuery();
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
        public DataTable PesquisarCPF(string cpf)
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdo = new SqlCommand();
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;
                cmdo.CommandText = "SELECT * FROM Consulta WHERE CPF = @CPF";

                cmdo.Parameters.Add("@CPF", SqlDbType.VarChar, 11).Value = cpf;
                SqlDataReader DR = cmdo.ExecuteReader();


                dt.Load(DR);      

            }
            catch (Exception ex)
            { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable PesquisarDataNasc(DateTime datanasc)
        {
            conn.ConnectionString = Properties.Settings.Default.conexao;
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmdo = new SqlCommand();
                cmdo.Connection = conn;
                cmdo.CommandType = CommandType.Text;
                cmdo.CommandText = "SELECT * FROM Consulta WHERE DataNasc = @DataNasc";

                cmdo.Parameters.Add("@DataNasc", SqlDbType.Date, 11).Value = datanasc;
                SqlDataReader DR = cmdo.ExecuteReader();


                dt.Load(DR);

            }
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

    }
}
