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
                "(null, @nome, @coordenador, @descricao, @Ano_Inicio);";

                comando.Parameters.AddWithValue("@nome", projeto.Nome);
                comando.Parameters.AddWithValue("@coordenador", projeto.Coordenador);
                comando.Parameters.AddWithValue("@descricao", projeto.Descricao);
                comando.Parameters.AddWithValue("@Ano_Inicio", projeto.Ano_Inicio);

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

        public List<Projeto> List()
        {
            try
            {
                var lista = new List<Projeto>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM projeto";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var projeto = new Projeto();

                    projeto.Id = reader.GetInt32("id_proj");
                    projeto.Nome = DAOHelper.GetString(reader, "nome_proj");
                    projeto.Coordenador = DAOHelper.GetString(reader, "coordenador_proj");
                    projeto.Descricao = DAOHelper.GetString(reader, "descricao_proj");
                    projeto.Ano_Inicio = reader.GetInt32("Ano_Inicio_proj");

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

        /*
        public void Delete(Projeto projeto)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM projeto WHERE id_proj = @id";

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

        */

        /*
        public void Update(Projeto projeto)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE projeto SET " +
                "nome_fantasia_esc = @nome, razao_social_esc = @razao, cnpj_esc = @cnpj, insc_estadual_esc = @inscricao," +
                " tipo_esc = @tipo, data_criacao_esc = @data_criacao, responsavel_esc = @resp " +
                "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", projeto.Nome);
                comando.Parameters.AddWithValue("@coordenador", projeto.Coordenador);
                comando.Parameters.AddWithValue("@descricao", projeto.Descricao);
                comando.Parameters.AddWithValue("@Ano_Inicio", projeto.Ano_Inicio);

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
        */
    }
}
