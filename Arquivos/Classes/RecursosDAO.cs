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


                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var recursos = new Recursos();

                    recursos.id_recu = reader.GetInt32("id_recu");
                    recursos.doador_recu = DAOHelper.GetString(reader, "doador_recu");
                    recursos.valor_recu = DAOHelper.GetDouble(reader, "valor_recu");
                    recursos.destino_recu = DAOHelper.GetString(reader, "destino_recu");
                    recursos.date_recu = reader.GetDateTime("date_recu");
                   
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

                comando.CommandText = "DELETE FROM recursos WHERE id_recu = @id";

                comando.Parameters.AddWithValue("@id", obj.id_recu);

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
                "WHERE id_recu = @id";

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

