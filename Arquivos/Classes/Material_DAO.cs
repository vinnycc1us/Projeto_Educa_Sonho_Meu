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
                "(null, @nome, @quantidade, @descricao, @valor, @id_sal_fk);";

                comando.Parameters.AddWithValue("@nome", material.nome_mate);
                comando.Parameters.AddWithValue("@quantidade", material.quantidade_mate);
                comando.Parameters.AddWithValue("@descricao", material.descricao_mate);
                comando.Parameters.AddWithValue("@valor", material.valor_mate);
                comando.Parameters.AddWithValue("@id_sal_fk", material.id_sal_fk);

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

        public List<material> List()
        {
            try
            {
                var lista = new List<material>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM material";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var material = new material();

                    material.Id = reader.GetInt32("id_esc");
                    material.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");
                    material.RazaoSocial = DAOHelper.GetString(reader, "razao_social_esc");
                    material.Cnpj = DAOHelper.GetString(reader, "cnpj_esc");
                    material.InscEstadual = DAOHelper.GetString(reader, "insc_estadual_esc");
                    material.Tipo = DAOHelper.GetString(reader, "tipo_esc");
                    material.Email = DAOHelper.GetString(reader, "email_esc");
                    material.Telefone = DAOHelper.GetString(reader, "telefone_esc");
                    material.Responsavel = DAOHelper.GetString(reader, "responsavel_esc");
                    material.ResponsavelTelefone = DAOHelper.GetString(reader, "responsavel_telefone_esc");
                    material.DataCriacao = DAOHelper.GetDateTime(reader, "data_criacao_esc");

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

        public void Delete(material material)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM material WHERE id_esc = @id";

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


        public void Update(material material)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE material SET " +
                "nome_fantasia_esc = @nome, razao_social_esc = @razao, cnpj_esc = @cnpj, insc_estadual_esc = @inscricao," +
                " tipo_esc = @tipo, data_criacao_esc = @data_criacao, responsavel_esc = @resp " +
                "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", material.NomeFantasia);
                comando.Parameters.AddWithValue("@razao", material.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", material.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", material.InscEstadual);
                comando.Parameters.AddWithValue("@tipo", material.Tipo);
                comando.Parameters.AddWithValue("@data_criacao", material.DataCriacao?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@resp", material.Responsavel);

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
    }
}
