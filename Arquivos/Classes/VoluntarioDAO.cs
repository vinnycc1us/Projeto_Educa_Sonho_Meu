using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class VoluntarioDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Voluntario obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO voluntario VALUES " +
                "(null, @nome, @cpf, @rg, @numero_telefone, @Id_End_Fk)";


                comando.Parameters.AddWithValue("@nome", obj.Nome);
                comando.Parameters.AddWithValue("@cpf", obj.Cpf);
                comando.Parameters.AddWithValue("@rg", obj.Rg);
                comando.Parameters.AddWithValue("@numero_telefone", obj.Numero_Telefone);
                comando.Parameters.AddWithValue("@Id_End_Fk", obj.Id_End_Fk);
               

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

        public List<Voluntario> List()
        {
            try
            {
                var lista = new List<Voluntario>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM voluntario, Endereco WHERE voluntario.Id_End_Fk = Endereco.id_end";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var voluntario = new Voluntario();

                    voluntario.Id = reader.GetInt32("id_volu");
                    voluntario.Nome = DAOHelper.GetString(reader, "nome_volu");
                    voluntario.Cpf = DAOHelper.GetString(reader, "cpf_volu");
                    voluntario.Rg = DAOHelper.GetString(reader, "rg_volu");
                    voluntario.Numero_Telefone = reader.GetInt32("numero_telefone_volu");
                    voluntario.Endereco.Id = reader.GetInt32("id_end");

                    lista.Add(voluntario);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /*
        public void Delete(Voluntario obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM voluntario WHERE id_volu = @id";

                comando.Parameters.AddWithValue("@id", obj.Id);

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

        */

        /*
        public void Update(Voluntario obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE Voluntario SET " +
                "nome_volu = @nome, cpf_volu = @cpf, rg_volu = @rg, numero_telefone_turm = @numero_telefone," +
                " id_edn_fk = @Id_End_Fk" + "WHERE id_volu = @id";

                
                comando.Parameters.AddWithValue("@nome", obj.Nome);
                comando.Parameters.AddWithValue("@razao", obj.Cpf);
                comando.Parameters.AddWithValue("@cnpj", obj.Rg);
                comando.Parameters.AddWithValue("@inscricao", obj.Numero_Telefone);
                comando.Parameters.AddWithValue("@tipo", obj.Id_End_Fk);

                comando.Parameters.AddWithValue("@id", obj.Id);
                

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
        */
    }
}
