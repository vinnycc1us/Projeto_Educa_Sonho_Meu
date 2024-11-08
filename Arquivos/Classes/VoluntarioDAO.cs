using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class VoluntarioDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Voluntario obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO voluntario VALUES " +
                "(null, @nome, @cpf, @rg, @numero_telefone, @id_end_fk)";


                comando.Parameters.AddWithValue("@nome", obj.nome_volu);
                comando.Parameters.AddWithValue("@descricao", obj.cpf_volu);
                comando.Parameters.AddWithValue("@carga", obj.rg_volu);
                comando.Parameters.AddWithValue("@turno", obj.numero_telefone_volu);
                comando.Parameters.AddWithValue("@turno", obj.id_end_fk);
               

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

        public List<Voluntario> List()
        {
            try
            {
                var lista = new List<voluntario>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM voluntario, Escola WHERE voluntario.id_esc_fk = Escola.id_esc";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var voluntario = new voluntario();

                    voluntario.Id = reader.GetInt32("id_cur");
                    voluntario.Nome = DAOHelper.GetString(reader, "nome_cur");
                    voluntario.Descricao = DAOHelper.GetString(reader, "descricao_cur");
                    voluntario.Turno = DAOHelper.GetString(reader, "turno_cur");
                    voluntario.Escola.Id = reader.GetInt32("id_esc_fk");
                    voluntario.Escola.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");

                    lista.Add(voluntario);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Voluntario obj)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM voluntario WHERE id_cur = @id";

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

        public void Update(Voluntario obj)
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

