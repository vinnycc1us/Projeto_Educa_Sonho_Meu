using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class EscolaDAO
    {
        private string connectionString;

        public EscolaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Escola escola)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO Escola (nome_esc, id_end_fk) VALUES (@nome, @idEnd)", connection);
                command.Parameters.AddWithValue("@nome", escola.nome_esc);
                command.Parameters.AddWithValue("@idEnd", escola.id_end_fk);

                command.ExecuteNonQuery();
            }
        }

        public void Atualizar(Escola escola)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("UPDATE Escola SET nome_esc = @nome, id_end_fk = @idEnd WHERE id_esc = @id", connection);
                command.Parameters.AddWithValue("@id", escola.id_esc);
                command.Parameters.AddWithValue("@nome", escola.nome_esc);
                command.Parameters.AddWithValue("@idEnd", escola.id_end_fk);

                command.ExecuteNonQuery();
            }
        }

        public void Deletar(int id_esc)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM Escola WHERE id_esc = @id", connection);
                command.Parameters.AddWithValue("@id", id_esc);

                command.ExecuteNonQuery();
            }
        }

        public Escola BuscarPorId(int id_esc)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Escola WHERE id_esc = @id", connection);
                command.Parameters.AddWithValue("@id", id_esc);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Escola
                        {
                            id_esc = reader.GetInt32("id_esc"),
                            nome_esc = reader.GetString("nome_esc"),
                            id_end_fk = reader.GetInt32("id_end_fk")
                        };
                    }
                }
            }
            return null;
        }

        public List<Escola> ListarTodas()
        {
            var escolas = new List<Escola>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Escola", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        escolas.Add(new Escola
                        {
                            id_esc = reader.GetInt32("id_esc"),
                            nome_esc = reader.GetString("nome_esc"),
                            id_end_fk = reader.GetInt32("id_end_fk")
                        });
                    }
                }
            }
            return escolas;
        }
    }
}
