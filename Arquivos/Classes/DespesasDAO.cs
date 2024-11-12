using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class DespesasDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Despesas despesa)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "INSERT INTO Despesa (doador_desp, valor_desp, destino_desp, data_desp) VALUES (@doador, @valor, @destino, @data)";
                comando.Parameters.AddWithValue("@doador", despesa.Doador);
                comando.Parameters.AddWithValue("@valor", despesa.Valor);
                comando.Parameters.AddWithValue("@destino", despesa.Destino);
                comando.Parameters.AddWithValue("@data", despesa.Data);

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

        public void Update(Despesas despesa)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "UPDATE Despesa SET doador_desp = @doador, valor_desp = @valor, destino_desp = @destino, data_desp = @data WHERE id_desp = @id";
                comando.Parameters.AddWithValue("@id", despesa.Id);
                comando.Parameters.AddWithValue("@doador", despesa.Doador);
                comando.Parameters.AddWithValue("@valor", despesa.Valor);
                comando.Parameters.AddWithValue("@destino", despesa.Destino);
                comando.Parameters.AddWithValue("@data", despesa.Data);

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

        public void Delete(Despesas despesa)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM Despesa WHERE id_desp = @id";
                comando.Parameters.AddWithValue("@id", despesa.Id);

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

        public List<Despesas> List()
        {
            try
            {
                var lista = new List<Despesas>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Despesa";

                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    {
                    var despesa = new Despesas();
                    despesa.Id = reader.GetInt32("id_desp");
                    despesa.Doador = reader.GetString("doador_desp");
                    despesa.Valor = reader.GetDouble("valor_desp");
                    despesa.Destino = reader.GetString("destino_desp");
                    despesa.Data = reader.GetDateTime("data_desp");
                    lista.Add(despesa);
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