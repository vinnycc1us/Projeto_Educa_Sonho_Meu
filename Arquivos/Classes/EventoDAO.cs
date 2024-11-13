using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class EventoDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Evento evento)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "INSERT INTO Evento (nome_even, data_even, Id_End_Fk, descricao_even) VALUES (@nome, @data, @idEnd, @descricao)";
                comando.Parameters.AddWithValue("@nome", evento.Nome);
                comando.Parameters.AddWithValue("@data", evento.Data);
                comando.Parameters.AddWithValue("@idEnd", evento.Id_End_Fk);
                comando.Parameters.AddWithValue("@descricao", evento.Descricao);

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

        public void Update(Evento evento)
        {

            try
            {
                var comando = _conn.Query();
                comando.CommandText = "UPDATE Evento SET nome_even = @nome, data_even = @data, Id_End_Fk = @idEnd, descricao_even = @descricao WHERE id_even = @id";
                comando.Parameters.AddWithValue("@id", evento.Id);
                comando.Parameters.AddWithValue("@nome", evento.Nome);
                comando.Parameters.AddWithValue("@data", evento.Data);
                comando.Parameters.AddWithValue("@idEnd", evento.Id_End_Fk);
                comando.Parameters.AddWithValue("@descricao", evento.Descricao);

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

        public void Delete(Evento evento)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM Evento WHERE id_even = @id";
                comando.Parameters.AddWithValue("@id", evento.Id);

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

        public List<Evento> List()
        {
            try
            {
                var lista = new List<Evento>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Evento";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                    {
                    var evento = new Evento();
                    evento.Id = reader.GetInt32("id_even");
                    evento.Nome = DAOHelper.GetString(reader, "nome_even");
                    evento.Data = DAOHelper.GetDateTime(reader, "data_even");
                    evento.Id_End_Fk = reader.GetInt32("Id_End_Fk");
                    evento.Descricao = DAOHelper.GetString(reader, "descricao_even");
                    lista.Add(evento);
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
