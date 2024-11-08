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
                "(null, @nome, @localizacao, @capacidade, @id_turma_fk)";


                comando.Parameters.AddWithValue("@nome", obj.nome_sal);
                comando.Parameters.AddWithValue("@descricao", obj.localizacao_sal);
                comando.Parameters.AddWithValue("@carga", obj.capacidade_sal);
                comando.Parameters.AddWithValue("@turno", obj.id_turma_fk);

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

                comando.CommandText = "SELECT * FROM sala, Turma WHERE sala.id_turma_fk = Turma.id_turm";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var sala = new Sala();

                    sala.id_sal = reader.GetInt32("id_sal");
                    sala.nome_sal = DAOHelper.GetString(reader, "nome_sal");
                    sala.localizacao_sal = DAOHelper.GetString(reader, "localizacao_sal");
                    sala.capacidade_sal = DAOHelper.GetString(reader, "capacidade_sal");
                    sala.turma.id_turm = reader.GetInt32("id_turma_fk");
                   
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

        public void Delete(Sala obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM sala WHERE id_sal = @id";

                comando.Parameters.AddWithValue("@id", obj.id_sal);

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

        public void Update(Sala obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE Sala SET " +
                "nome_sal = @nome, localizacao-sal = @localizacao, capacidade_sal = @capacidade" +
                "WHERE id_sal = @id";

                
                comando.Parameters.AddWithValue("@nome", obj.nome_sal);
                comando.Parameters.AddWithValue("@razao", obj.localizacao_sal);
                comando.Parameters.AddWithValue("@cnpj", obj.capacidade_sal);
                comando.Parameters.AddWithValue("@inscricao", obj.id_turma_fk);
             

                comando.Parameters.AddWithValue("@id", obj.id_sal);
                

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

