using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class ResponsavelDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Responsavel obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO responsavel VALUES " +
                "(null, @nome_completo, @cpf, @rg, @orgao_expedidor, @telefone, @telefone_alternativo, @telefone_fixo, @telefone_recado)";


                comando.Parameters.AddWithValue("@nome", obj.nome_completo_resp);
                comando.Parameters.AddWithValue("@descricao", obj.cpf_resp);
                comando.Parameters.AddWithValue("@carga", obj.rg_resp);
                comando.Parameters.AddWithValue("@turno", obj.orgao_expeditor_resp);
                comando.Parameters.AddWithValue("@turno", obj.telefone_resp);
                comando.Parameters.AddWithValue("@turno", obj.telefone_alternativo_resp);
                comando.Parameters.AddWithValue("@turno", obj.telefone_fixo_resp);
                comando.Parameters.AddWithValue("@turno", obj.telefone_recado_resp);

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

        public List<Responsavel> List()
        {
            try
            {
                var lista = new List<responsavel>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM responsavel, Escola WHERE responsavel.id_esc_fk = Escola.id_esc";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var responsavel = new responsavel();

                    responsavel.Id = reader.GetInt32("id_cur");
                    responsavel.Nome = DAOHelper.GetString(reader, "nome_cur");
                    responsavel.Descricao = DAOHelper.GetString(reader, "descricao_cur");
                    responsavel.Turno = DAOHelper.GetString(reader, "turno_cur");
                    responsavel.Escola.Id = reader.GetInt32("id_esc_fk");
                    responsavel.Escola.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");

                    lista.Add(responsavel);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Responsavel obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM responsavel WHERE id_cur = @id";

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

        public void Update(Responsavel obj)
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

