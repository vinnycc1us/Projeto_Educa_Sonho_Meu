using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class SalaDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Sala obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO sala VALUES " +
                "(null, @nome, @localizacao, @capacidade, @Id_Turm_Fk)";


                comando.Parameters.AddWithValue("@nome", obj.Nome);
                comando.Parameters.AddWithValue("@localizacao", obj.Localizacao);
                comando.Parameters.AddWithValue("@capacidade", obj.Capacidade);
                comando.Parameters.AddWithValue("@id_turm_fk", obj.Id_Turm_Fk);

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

        public List<Sala> List()
        {
            try
            {
                var lista = new List<Sala>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM sala, Turma WHERE sala.Id_Turm_Fk = Turma.id_turm";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var sala = new Sala();

                    sala.Id = reader.GetInt32("id_sal");
                    sala.Nome = DAOHelper.GetString(reader, "nome_sal");
                    sala.Localizacao = DAOHelper.GetString(reader, "localizacao_sal");
                    sala.Capacidade = DAOHelper.GetString(reader, "capacidade_sal");
                    sala.Turma.Id = reader.GetInt32("id_turm_fk");
                   
                    lista.Add(sala);
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
        public void Delete(Sala obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM sala WHERE Id = @id";

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
        public void Update(Sala obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE Sala SET " +
                "nome_sal = @nome, localizacao-sal = @localizacao, capacidade_sal = @capacidade" +
                "WHERE id_sal = @id";

                
                comando.Parameters.AddWithValue("@nome", obj.Nome);
                comando.Parameters.AddWithValue("@localizacao", obj.Localizacao);
                comando.Parameters.AddWithValue("@capacidade", obj.Capacidade);
             

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

