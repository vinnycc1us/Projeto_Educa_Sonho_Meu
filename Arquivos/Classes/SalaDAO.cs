using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class SalaDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Sala obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO sala VALUES " +
                "(null, @nome, @localizacao, @capacidade, @id_turma_fk)";


                comando.Parameters.AddWithValue("@nome", obj.nome_sal);
                comando.Parameters.AddWithValue("@descricao", obj.localizacao_sal);
                comando.Parameters.AddWithValue("@carga", obj.capacidade_sal);
                comando.Parameters.AddWithValue("@turno", obj.id_turma_fk);

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

        public List<Sala> List()
        {
            try
            {
                var lista = new List<sala>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM sala, Escola WHERE sala.id_esc_fk = Escola.id_esc";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var sala = new sala();

                    sala.Id = reader.GetInt32("id_cur");
                    sala.Nome = DAOHelper.GetString(reader, "nome_cur");
                    sala.Descricao = DAOHelper.GetString(reader, "descricao_cur");
                    sala.Turno = DAOHelper.GetString(reader, "turno_cur");
                    sala.Escola.Id = reader.GetInt32("id_esc_fk");
                    sala.Escola.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");

                    lista.Add(sala);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Sala obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM sala WHERE id_cur = @id";

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

        public void Update(Sala obj)
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

