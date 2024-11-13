using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class FuncionarioDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Funcionario funcionario)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO funcionario VALUES " +
                "(null, @nome, @cpf, @ctps, @rg, @funcao, @Id_fk, @num_telefone, @id_end_fk);";

                comando.Parameters.AddWithValue("@nome", funcionario.nome_func);
                comando.Parameters.AddWithValue("@cpf", funcionario.cpf_func);
                comando.Parameters.AddWithValue("@ctps", funcionario.ctps_func);
                comando.Parameters.AddWithValue("@rg", funcionario.rg_func);
                comando.Parameters.AddWithValue("@funcao", funcionario.funcao_func);
                comando.Parameters.AddWithValue("@Id_fk", funcionario.Id_fk);
                comando.Parameters.AddWithValue("@num_telefone", funcionario.num_telefone_func);
                comando.Parameters.AddWithValue("@id_end_fk", funcionario.id_end_fk);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public List<funcionario> List()
        {
            try
            {
                var lista = new List<funcionario>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM funcionario";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var funcionario = new funcionario();

                    funcionario.Id = reader.GetInt32("id_esc");
                    funcionario.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");
                    funcionario.RazaoSocial = DAOHelper.GetString(reader, "razao_social_esc");
                    funcionario.Cnpj = DAOHelper.GetString(reader, "cnpj_esc");
                    funcionario.InscEstadual = DAOHelper.GetString(reader, "insc_estadual_esc");
                    funcionario.Tipo = DAOHelper.GetString(reader, "tipo_esc");
                    funcionario.Email = DAOHelper.GetString(reader, "email_esc");
                    funcionario.Telefone = DAOHelper.GetString(reader, "telefone_esc");
                    funcionario.Responsavel = DAOHelper.GetString(reader, "responsavel_esc");
                    funcionario.ResponsavelTelefone = DAOHelper.GetString(reader, "responsavel_telefone_esc");
                    funcionario.DataCriacao = DAOHelper.GetDateTime(reader, "data_criacao_esc");

                    lista.Add(funcionario);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(funcionario funcionario)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM funcionario WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@id", funcionario.Id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações.");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void Update(funcionario funcionario)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE funcionario SET " +
                "nome_fantasia_esc = @nome, razao_social_esc = @razao, cnpj_esc = @cnpj, insc_estadual_esc = @inscricao," +
                " tipo_esc = @tipo, data_criacao_esc = @data_criacao, responsavel_esc = @resp " +
                "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", funcionario.NomeFantasia);
                comando.Parameters.AddWithValue("@razao", funcionario.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", funcionario.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", funcionario.InscEstadual);
                comando.Parameters.AddWithValue("@tipo", funcionario.Tipo);
                comando.Parameters.AddWithValue("@data_criacao", funcionario.DataCriacao?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@resp", funcionario.Responsavel);

                comando.Parameters.AddWithValue("@id", funcionario.Id);

                var resultado = comando.ExecuteNonQuery();

                if (resultado == 0)
                {
                    throw new Exception("Ocorreram erros ao salvar as informações");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }
    }
} */
