using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class EnderecoDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Endereco endereco)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "INSERT INTO Endereco (uf_end, cidade_end, bairro_end, numero_end, cep_end) VALUES (@uf, @cidade, @bairro, @numero, @cep)";
                comando.Parameters.AddWithValue("@uf", endereco.Uf);
                comando.Parameters.AddWithValue("@cidade", endereco.Cidade);
                comando.Parameters.AddWithValue("@bairro", endereco.Bairro);
                comando.Parameters.AddWithValue("@numero", endereco.Numero);
                comando.Parameters.AddWithValue("@cep", endereco.Cep);


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

        public void Update(Endereco endereco)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "UPDATE Endereco SET uf_end = @uf, cidade_end = @cidade, bairro_end = @bairro, numero_end = @numero, cep_end = @cep WHERE id_end = @id" ;
                comando.Parameters.AddWithValue("@id", endereco.Id);
                comando.Parameters.AddWithValue("@uf", endereco.Uf);
                comando.Parameters.AddWithValue("@cidade", endereco.Cidade);
                comando.Parameters.AddWithValue("@bairro", endereco.Bairro);
                comando.Parameters.AddWithValue("@numero", endereco.Numero);
                comando.Parameters.AddWithValue("@cep", endereco.Cep);

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

        public void Deletar(Endereco endereco)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM Endereco WHERE id_end = @id";
                comando.Parameters.AddWithValue("@id", endereco.Id);

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

        public List<Endereco> List()
        {
            try
            {
                var lista = new List<Endereco>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Endereco";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var endereco = new Endereco();
                    endereco.Id = reader.GetInt32("id_end");
                    endereco.Uf = DAOHelper.GetString(reader, "uf_end");
                    endereco.Cidade = DAOHelper.GetString(reader, "cidade_end");
                    endereco.Bairro = DAOHelper.GetString(reader, "bairro_end");
                    endereco.Numero = DAOHelper.GetString(reader, "numero_end");
                    endereco.Cep = DAOHelper.GetString(reader, "cep_end");
                    lista.Add(endereco);
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