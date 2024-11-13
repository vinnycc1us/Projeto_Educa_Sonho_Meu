using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

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

                comando.Parameters.AddWithValue("@nome", instrumento.nome_inst);
                comando.Parameters.AddWithValue("@quantidade", instrumento.quantidade_inst);
                comando.Parameters.AddWithValue("@descricao", instrumento.descricao_inst);
                comando.Parameters.AddWithValue("@valor", instrumento.valor_inst);

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

        public List<instrumento> List()
        {
            try
            {
                var lista = new List<instrumento>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM instrumento";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var instrumento = new instrumento();

                    instrumento.Id = reader.GetInt32("id_esc");
                    instrumento.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");
                    instrumento.RazaoSocial = DAOHelper.GetString(reader, "razao_social_esc");
                    instrumento.Cnpj = DAOHelper.GetString(reader, "cnpj_esc");
                    instrumento.InscEstadual = DAOHelper.GetString(reader, "insc_estadual_esc");
                    instrumento.Tipo = DAOHelper.GetString(reader, "tipo_esc");
                    instrumento.Email = DAOHelper.GetString(reader, "email_esc");
                    instrumento.Telefone = DAOHelper.GetString(reader, "telefone_esc");
                    instrumento.Responsavel = DAOHelper.GetString(reader, "responsavel_esc");
                    instrumento.ResponsavelTelefone = DAOHelper.GetString(reader, "responsavel_telefone_esc");
                    instrumento.DataCriacao = DAOHelper.GetDateTime(reader, "data_criacao_esc");

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

        public void Delete(instrumento instrumento)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM instrumento WHERE id_esc = @id";

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


        public void Update(instrumento instrumento)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE instrumento SET " +
                "nome_fantasia_esc = @nome, razao_social_esc = @razao, cnpj_esc = @cnpj, insc_estadual_esc = @inscricao," +
                " tipo_esc = @tipo, data_criacao_esc = @data_criacao, responsavel_esc = @resp " +
                "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", instrumento.NomeFantasia);
                comando.Parameters.AddWithValue("@razao", instrumento.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", instrumento.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", instrumento.InscEstadual);
                comando.Parameters.AddWithValue("@tipo", instrumento.Tipo);
                comando.Parameters.AddWithValue("@data_criacao", instrumento.DataCriacao?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@resp", instrumento.Responsavel);

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
*/