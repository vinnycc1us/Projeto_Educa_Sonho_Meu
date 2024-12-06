using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class InstrumentoDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Instrumento instrumento)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO instrumento VALUES " +
                "(null, @nome, @quantidade, @descricao, @valor);";

                comando.Parameters.AddWithValue("@nome", instrumento.Nome);
                comando.Parameters.AddWithValue("@quantidade", instrumento.Quantidade);
                comando.Parameters.AddWithValue("@descricao", instrumento.Descricao);
                comando.Parameters.AddWithValue("@valor", instrumento.Valor);

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

        public List<Instrumento> List()
        {
            try
            {
                var lista = new List<Instrumento>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM instrumento";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var instrumento = new Instrumento();

                    instrumento.Id = reader.GetInt32("id_inst");
                    instrumento.Nome = DAOHelper.GetString(reader, "nome_inst");
                    instrumento.Quantidade = reader.GetInt32("quantidade_inst");
                    instrumento.Descricao = DAOHelper.GetString(reader, "descricao_inst");
                    instrumento.Valor = reader.GetInt32("valor_inst");
                 
                    lista.Add(instrumento);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        public void Delete(Instrumento instrumento)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM instrumento WHERE id_inst = @id";

                comando.Parameters.AddWithValue("@id", instrumento.Id);

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
        

        
        public void Update(Instrumento instrumento)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE instrumento SET " +
                "nome_inst = @nome, quantidade_inst = @quantidade, descricao_inst = @quantidade, valor = @valor," 
                + "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", instrumento.Nome);
                comando.Parameters.AddWithValue("@quantidade", instrumento.Quantidade);
                comando.Parameters.AddWithValue("@descricao", instrumento.Descricao);
                comando.Parameters.AddWithValue("@valor", instrumento.Valor);

                comando.Parameters.AddWithValue("@id", instrumento.Id);

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
