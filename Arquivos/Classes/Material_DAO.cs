using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Material_DAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Material material)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO material VALUES " +
                "(null, @nome, @quantidade, @descricao, @valor, @Id_Sal_Fk);";

                comando.Parameters.AddWithValue("@nome", material.Nome);
                comando.Parameters.AddWithValue("@quantidade", material.Quantidade);
                comando.Parameters.AddWithValue("@descricao", material.Descricao);
                comando.Parameters.AddWithValue("@valor", material.Valor);
                comando.Parameters.AddWithValue("@Id_Sal_Fk", material.Id_Sal_Fk);

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

        public List<Material> List()
        {
            try
            {
                var lista = new List<Material>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM material, sala WHERE material.Id_SAl_Fk = sala.id_turm";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var material = new Material();

                    material.Id = reader.GetInt32("id_esc");
                    material.Quantidade = reader.GetInt32("nome_fantasia_esc");
                    material.Descricao = DAOHelper.GetString(reader, "razao_social_esc");
                    material.Valor = reader.GetInt32("cnpj_esc");
                    material.sala.Id = reader.GetInt32("id_sal_fk");

                    lista.Add(material);
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
        public void Delete(Material material)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM material WHERE id_mate = @id";

                comando.Parameters.AddWithValue("@id", material.Id);

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
        public void Update(Material material)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE material SET " +
                "nome_mate = @nome, quantidade_mate = @quantidade, descricao_mate = @descricao, valor_mate = @valor," +              
                "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", material.Nome);
                comando.Parameters.AddWithValue("@quantidade", material.Quantidade);
                comando.Parameters.AddWithValue("@descricao", material.Descricao);
                comando.Parameters.AddWithValue("@valor", material.Valor);

                comando.Parameters.AddWithValue("@id", material.Id);

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
