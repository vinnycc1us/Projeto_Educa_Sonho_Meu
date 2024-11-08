using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class RerecursosDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Recursos obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO recursos VALUES " +
                "(null, @doador, @valor, @destino, @date)";


                comando.Parameters.AddWithValue("@doador", obj.doador_recu);
                comando.Parameters.AddWithValue("@valor", obj.valor_recu);
                comando.Parameters.AddWithValue("@destino", obj.destino_recu);
                comando.Parameters.AddWithValue("@date", obj.date_recu);

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

        public List<Recursos> List()
        {
            try
            {
                var lista = new List<Recursos>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM recursos, Escola WHERE recursos.id_esc_fk = Escola.id_esc";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var recursos = new recursos();

                    recursos.Id = reader.GetInt32("id_cur");
                    recursos.Nome = DAOHelper.GetString(reader, "nome_cur");
                    recursos.Descricao = DAOHelper.GetString(reader, "descricao_cur");
                    recursos.Turno = DAOHelper.GetString(reader, "turno_cur");
                    recursos.Escola.Id = reader.GetInt32("id_esc_fk");
                    recursos.Escola.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");

                    lista.Add(recursos);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Recursos obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM recursos WHERE id_cur = @id";

                comando.Parameters.AddWithValue("@id", obj.Id);

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

        public void Update(Recursos obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE Escola SET " +
                "nome_fantasia_esc = @nome, razao_social_esc = @razao, cnpj_esc = @cnpj, insc_estadual_esc = @inscricao," +
                " tipo_esc = @tipo, data_criacao_esc = @data_criacao, responsavel_esc = @resp " +
                "WHERE id_esc = @id";

                /*
                comando.Parameters.AddWithValue("@nome", escola.NomeFantasia);
                comando.Parameters.AddWithValue("@razao", escola.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", escola.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", escola.InscEstadual);
                comando.Parameters.AddWithValue("@tipo", escola.Tipo);
                comando.Parameters.AddWithValue("@data_criacao", escola.DataCriacao?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@resp", escola.Responsavel);

                comando.Parameters.AddWithValue("@id", escola.Id);
                */

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

