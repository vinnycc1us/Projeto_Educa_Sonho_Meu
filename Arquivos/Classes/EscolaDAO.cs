using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class EscolaDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Escola escola)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "INSERT INTO Escola (nome_esc, Id_End_Fk) VALUES (@nome, @idEnd)";
                comando.Parameters.AddWithValue("@nome", escola.Nome);
                comando.Parameters.AddWithValue("@idEnd", escola.Id_End_Fk);

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

        public void Update(Escola escola)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "UPDATE Escola SET nome_esc = @nome, Id_End_Fk = @idEnd WHERE id_esc = @id";
                comando.Parameters.AddWithValue("@id", escola.Id);
                comando.Parameters.AddWithValue("@nome", escola.Nome);
                comando.Parameters.AddWithValue("@idEnd", escola.Id_End_Fk);

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

        public void Delete(Escola escola)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM Escola WHERE id_esc = @id";
                comando.Parameters.AddWithValue("@id", escola.Id);

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

        public List<Escola> List()
        {
            try
            {
                var lista = new List<Escola>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Escola";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var escola = new Escola();
                    escola.Id = reader.GetInt32("id_esc");
                    escola.Nome = DAOHelper.GetString(reader, "nome_esc");
                    escola.Id_End_Fk = reader.GetInt32("Id_End_Fk");
                    lista.Add(escola);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
