using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class ProjetoDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Projeto projeto)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO projeto VALUES " +
                "(null, @nome, @coordenador, @descricao, @ano_inicio);";

                comando.Parameters.AddWithValue("@nome", projeto.nome_proj);
                comando.Parameters.AddWithValue("@coordenador", projeto.coordenador_proj);
                comando.Parameters.AddWithValue("@descricao", projeto.descricao_proj);
                comando.Parameters.AddWithValue("@ano_inicio", projeto.ano_inicio_proj);

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

        public List<projeto> List()
        {
            try
            {
                var lista = new List<projeto>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM projeto";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var projeto = new projeto();

                    projeto.Id = reader.GetInt32("id_esc");
                    projeto.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");
                    projeto.RazaoSocial = DAOHelper.GetString(reader, "razao_social_esc");
                    projeto.Cnpj = DAOHelper.GetString(reader, "cnpj_esc");
                    projeto.InscEstadual = DAOHelper.GetString(reader, "insc_estadual_esc");
                    projeto.Tipo = DAOHelper.GetString(reader, "tipo_esc");
                    projeto.Email = DAOHelper.GetString(reader, "email_esc");
                    projeto.Telefone = DAOHelper.GetString(reader, "telefone_esc");
                    projeto.Responsavel = DAOHelper.GetString(reader, "responsavel_esc");
                    projeto.ResponsavelTelefone = DAOHelper.GetString(reader, "responsavel_telefone_esc");
                    projeto.DataCriacao = DAOHelper.GetDateTime(reader, "data_criacao_esc");

                    lista.Add(projeto);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(projeto projeto)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM projeto WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@id", projeto.Id);

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


        public void Update(projeto projeto)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE projeto SET " +
                "nome_fantasia_esc = @nome, razao_social_esc = @razao, cnpj_esc = @cnpj, insc_estadual_esc = @inscricao," +
                " tipo_esc = @tipo, data_criacao_esc = @data_criacao, responsavel_esc = @resp " +
                "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", projeto.NomeFantasia);
                comando.Parameters.AddWithValue("@razao", projeto.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", projeto.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", projeto.InscEstadual);
                comando.Parameters.AddWithValue("@tipo", projeto.Tipo);
                comando.Parameters.AddWithValue("@data_criacao", projeto.DataCriacao?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@resp", projeto.Responsavel);

                comando.Parameters.AddWithValue("@id", projeto.Id);

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
