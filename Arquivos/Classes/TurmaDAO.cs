using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class TurmaDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Turma obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO turma VALUES " +
                "(null, @nome, @quabtidade, @descricao, @ano)";


                comando.Parameters.AddWithValue("@nome", obj.nome_turm);
                comando.Parameters.AddWithValue("@descricao", obj.quantidade_turm);
                comando.Parameters.AddWithValue("@carga", obj.descricao_turm);
                comando.Parameters.AddWithValue("@turno", obj.ano_turm);

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

        public List<Turma> List()
        {
            try
            {
                var lista = new List<turma>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM turma, Escola WHERE turma.id_esc_fk = Escola.id_esc";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var turma = new turma();

                    turma.Id = reader.GetInt32("id_cur");
                    turma.Nome = DAOHelper.GetString(reader, "nome_cur");
                    turma.Descricao = DAOHelper.GetString(reader, "descricao_cur");
                    turma.Turno = DAOHelper.GetString(reader, "turno_cur");
                    turma.Escola.Id = reader.GetInt32("id_esc_fk");
                    turma.Escola.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");

                    lista.Add(turma);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Turma obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM turma WHERE id_cur = @id";

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

        public void Update(Turma obj)
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

