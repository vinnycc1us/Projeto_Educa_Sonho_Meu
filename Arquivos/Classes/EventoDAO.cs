using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class EventoDAO
    {
        private string connectionString;

        public EventoDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Inserir(Evento evento)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO Evento (nome_even, data_even, id_end_fk, descricao_even) VALUES (@nome, @data, @idEnd, @descricao)", connection);
                command.Parameters.AddWithValue("@nome", evento.Nome);
                command.Parameters.AddWithValue("@data", evento.Data);
                command.Parameters.AddWithValue("@idEnd", evento.id_end_fk);
                command.Parameters.AddWithValue("@descricao", evento.Descricao);

                command.ExecuteNonQuery();
            }
        }

        public void Atualizar(Evento evento)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("UPDATE Evento SET nome_even = @nome, data_even = @data, id_end_fk = @idEnd, descricao_even = @descricao WHERE id_even = @id", connection);
                command.Parameters.AddWithValue("@id", evento.Id);
                command.Parameters.AddWithValue("@nome", evento.Nome);
                command.Parameters.AddWithValue("@data", evento.Data);
                command.Parameters.AddWithValue("@idEnd", evento.id_end_fk);
                command.Parameters.AddWithValue("@descricao", evento.Descricao);

                command.ExecuteNonQuery();
            }
        }

        public void Deletar(int id_even)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM Evento WHERE id_even = @id", connection);
                command.Parameters.AddWithValue("@id", id_even);

                command.ExecuteNonQuery();
            }
        }

        public Evento BuscarPorId(int id_even)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Evento WHERE id_even = @id", connection);
                command.Parameters.AddWithValue("@id", id_even);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Evento
                        {
                            Id = reader.GetInt32("id_even"),
                            Nome = reader.GetString("nome_even"),
                            Data = reader.GetDateTime("data_even"),
                            id_end_fk = reader.GetInt32("id_end_fk"),
                            Descricao = reader.GetString("descricao_even")
                        };
                    }
                }
            }
            return null;
        }

        public List<Evento> ListarTodos()
        {
            var eventos = new List<Evento>();
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM Evento", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        eventos.Add(new Evento
                        {
                            Id = reader.GetInt32("id_even"),
                            Nome = reader.GetString("nome_even"),
                            Data = reader.GetDateTime("data_even"),
                            id_end_fk = reader.GetInt32("id_end_fk"),
                            Descricao = reader.GetString("descricao_even")
                        });
                    }
                }
            }
            return eventos;
        }
    }
}
