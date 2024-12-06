using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                "(null, @nome, @cpf, @ctps, @rg, @funcao, @Id_Sal_Fk, @num_telefone, @Id_End_Fk);";

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@ctps", funcionario.Ctps);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);
                comando.Parameters.AddWithValue("@Id_Sal_Fk", funcionario.Id_Sal_Fk);
                comando.Parameters.AddWithValue("@num_telefone", funcionario.Numero);
                comando.Parameters.AddWithValue("@Id_End_Fk", funcionario.Id_End_Fk);

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
        
        public List<Funcionario> List()
        {
            try
            {
                var lista = new List<Funcionario>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM funcionario, sala WHERE funcionario.Id_Sal_Fk = Sala.id_sal";
                comando.CommandText = "SELECT * FROM funcionario, endereco WHERE funcionario.Id_End_Fk = Endereco.id_end";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var funcionario = new Funcionario();

                    funcionario.Id = reader.GetInt32("id_func");
                    funcionario.Nome = DAOHelper.GetString(reader, "nome_func");
                    funcionario.Cpf = DAOHelper.GetString(reader, "cpf_func");
                    funcionario.Ctps = DAOHelper.GetString(reader, "ctps_func");
                    funcionario.Rg = DAOHelper.GetString(reader, "rg_func");
                    funcionario.Funcao = DAOHelper.GetString(reader, "funcao_func");
                    funcionario.Sala.Id = reader.GetInt32("id_sal_fk");
                    funcionario.Endereco.Id = reader.GetInt32("id_end_fk");

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

        
        public void Delete(Funcionario funcionario)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM funcionario WHERE id_func = @id";

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
        



        
        public void Update(Funcionario funcionario)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE funcionario SET " +
                "nome_func = @nome, cpf_func = @cpf, ctps_func = @ctps, rg_func = @rg," +
                " funcao_func = @funcao" + "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", funcionario.Nome);
                comando.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                comando.Parameters.AddWithValue("@ctps", funcionario.Ctps);
                comando.Parameters.AddWithValue("@rg", funcionario.Rg);
                comando.Parameters.AddWithValue("@funcao", funcionario.Funcao);
          

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
}