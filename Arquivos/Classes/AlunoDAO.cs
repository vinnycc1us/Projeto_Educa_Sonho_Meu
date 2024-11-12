using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class AlunoDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Aluno aluno)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO aluno VALUES " +
                "(null, @nome, @naturalidade, @nacionalidade, @data_nascimento, @cpf, @rg, @id_sex_fk, @doencas_especialidades, @nis, " +
                "@beneficio, @bolsa_familia, @id_end_fk, @Id_fk, @id_esc_fk, @serie, @parecer_social, @nivel_prioridade);";

                comando.Parameters.AddWithValue("@nome", aluno.nome_alun);
                comando.Parameters.AddWithValue("@naturalidade", aluno.naturalidade_alun);
                comando.Parameters.AddWithValue("@nacionalidade", aluno.nacionalidade_alun);
                comando.Parameters.AddWithValue("@data_nascimento", aluno.data_nascimento_alun);
                comando.Parameters.AddWithValue("@cpf", aluno.cpf_alun);
                comando.Parameters.AddWithValue("@rg", aluno.rg_alun);
                comando.Parameters.AddWithValue("@id_sex_fk", aluno.id_sex_fk);
                comando.Parameters.AddWithValue("@doencas_especialidades", aluno.doencas_especialidades_alun);
                comando.Parameters.AddWithValue("@nis", aluno.nis_alun);
                comando.Parameters.AddWithValue("@beneficio", aluno.beneficio_alun);
                comando.Parameters.AddWithValue("@bolsa_familia", aluno.bolsa_familia_alun);
                comando.Parameters.AddWithValue("@id_end_fk", aluno.id_end_fk);
                comando.Parameters.AddWithValue("@Id_fk", aluno.Id_fk);
                comando.Parameters.AddWithValue("@id_esc_fk", aluno.id_esc_fk);
                comando.Parameters.AddWithValue("@serie", aluno.serie_alun);
                comando.Parameters.AddWithValue("@parecer_social", aluno.parecer_social_alun);
                comando.Parameters.AddWithValue("@nivel_prioridade", aluno.nivel_prioridade_alun);

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

        public List<Escola> List()
        {
            try
            {
                var lista = new List<Escola>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Escola";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var aluno = new Escola();

                    aluno.Id = reader.GetInt32("id_esc");
                    aluno.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");
                    aluno.RazaoSocial = DAOHelper.GetString(reader, "razao_social_esc");
                    aluno.Cnpj = DAOHelper.GetString(reader, "cnpj_esc");
                    aluno.InscEstadual = DAOHelper.GetString(reader, "insc_estadual_esc");
                    aluno.Tipo = DAOHelper.GetString(reader, "tipo_esc");
                    aluno.Email = DAOHelper.GetString(reader, "email_esc");
                    aluno.Telefone = DAOHelper.GetString(reader, "telefone_esc");
                    aluno.Responsavel = DAOHelper.GetString(reader, "responsavel_esc");
                    aluno.ResponsavelTelefone = DAOHelper.GetString(reader, "responsavel_telefone_esc");
                    aluno.DataCriacao = DAOHelper.GetDateTime(reader, "data_criacao_esc");

                    lista.Add(aluno);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Escola aluno)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM Escola WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@id", aluno.Id);

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


        public void Update(Escola aluno)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE Escola SET " +
                "nome_fantasia_esc = @nome, razao_social_esc = @razao, cnpj_esc = @cnpj, insc_estadual_esc = @inscricao," +
                " tipo_esc = @tipo, data_criacao_esc = @data_criacao, responsavel_esc = @resp " +
                "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", aluno.NomeFantasia);
                comando.Parameters.AddWithValue("@razao", aluno.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", aluno.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", aluno.InscEstadual);
                comando.Parameters.AddWithValue("@tipo", aluno.Tipo);
                comando.Parameters.AddWithValue("@data_criacao", aluno.DataCriacao?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@resp", aluno.Responsavel);

                comando.Parameters.AddWithValue("@id", aluno.Id);

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
