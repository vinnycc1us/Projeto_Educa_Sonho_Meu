using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class AlunoDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Aluno aluno)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "INSERT INTO Aluno (nome_alun, naturalidade_alun, nacionalidade_alun, data_nascimento_alun, cpf_alun, rg_alun, id_sex_fk, doencas_especialidades_alun, nis_alun, beneficio_alun, bolsa_familia_alun, Id_End_Fk, id_resp_fk, id_esc_fk, serie_alun, parecer_social_alun, nivel_prioridade_alun) VALUES (@nome, @naturalidade, @nacionalidade, @dataNascimento, @cpf, @rg, @idSex, @doencas, @nis, @beneficio, @bolsaFamilia, @idEnd, @idResp, @idEsc, @serie, @parecerSocial, @nivelPrioridade)";
                comando.Parameters.AddWithValue("@nome", aluno.Nome);
                comando.Parameters.AddWithValue("@naturalidade", aluno.Naturalidade);
                comando.Parameters.AddWithValue("@nacionalidade", aluno.Nacionalidade);
                comando.Parameters.AddWithValue("@dataNascimento", aluno.Data_nascimento);
                comando.Parameters.AddWithValue("@cpf", aluno.Cpf);
                comando.Parameters.AddWithValue("@rg", aluno.Rg);
                comando.Parameters.AddWithValue("@idSex", aluno.id_sex_fk);
                comando.Parameters.AddWithValue("@doencas", aluno.Doencas_especialidades);
                comando.Parameters.AddWithValue("@nis", aluno.Nis);
                comando.Parameters.AddWithValue("@beneficio", aluno.Beneficio);
                comando.Parameters.AddWithValue("@bolsaFamilia", aluno.Bolsa_familia);
                comando.Parameters.AddWithValue("@idEnd", aluno.Id_End_Fk);
                comando.Parameters.AddWithValue("@idResp", aluno.id_resp_fk);
                comando.Parameters.AddWithValue("@idEsc", aluno.id_esc_fk);
                comando.Parameters.AddWithValue("@serie", aluno.Serie);
                comando.Parameters.AddWithValue("@parecerSocial", aluno.Parecer_social);
                comando.Parameters.AddWithValue("@nivelPrioridade", aluno.Nivel_prioridade);

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

        public void Update(Aluno aluno)
        {
            try
            {
                var comando = _conn.Query();
                comando.CommandText = "UPDATE Aluno SET nome_alun = @nome, naturalidade_alun = @naturalidade, nacionalidade_alun = @nacionalidade, data_nascimento_alun = @dataNascimento, cpf_alun = @cpf, rg_alun = @rg, id_sex_fk = @idSex, doencas_especialidades_alun = @doencas, nis_alun = @nis, beneficio_alun = @beneficio, bolsa_familia_alun = @bolsaFamilia, Id_End_Fk = @idEnd, id_resp_fk = @idResp, id_esc_fk = @idEsc, serie_alun = @serie, parecer_social_alun = @parecerSocial, nivel_prioridade_alun = @nivelPrioridade WHERE id_alun = @id";
                comando.Parameters.AddWithValue("@id", aluno.Id);
                comando.Parameters.AddWithValue("@nome", aluno.Nome);
                comando.Parameters.AddWithValue("@naturalidade", aluno.Naturalidade);
                comando.Parameters.AddWithValue("@nacionalidade", aluno.Nacionalidade);
                comando.Parameters.AddWithValue("@dataNascimento", aluno.Data_nascimento);
                comando.Parameters.AddWithValue("@cpf", aluno.Cpf);
                comando.Parameters.AddWithValue("@rg", aluno.Rg);
                comando.Parameters.AddWithValue("@idSex", aluno.id_sex_fk);
                comando.Parameters.AddWithValue("@doencas", aluno.Doencas_especialidades);
                comando.Parameters.AddWithValue("@nis", aluno.Nis);
                comando.Parameters.AddWithValue("@beneficio", aluno.Beneficio);
                comando.Parameters.AddWithValue("@bolsaFamilia", aluno.Bolsa_familia);
                comando.Parameters.AddWithValue("@idEnd", aluno.Id_End_Fk);
                comando.Parameters.AddWithValue("@idResp", aluno.id_resp_fk);
                comando.Parameters.AddWithValue("@idEsc", aluno.id_esc_fk);
                comando.Parameters.AddWithValue("@serie", aluno.Serie);
                comando.Parameters.AddWithValue("@parecerSocial", aluno.Parecer_social);
                comando.Parameters.AddWithValue("@nivelPrioridade", aluno.Nivel_prioridade);

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

        public void Delete(Aluno aluno)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM Aluno WHERE id_alun = @id";
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

        public List<Aluno> List()
        {
            try
            {
                var lista = new List<Aluno>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM Aluno";
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var aluno = new Aluno();
                    aluno.Id = reader.GetInt32("id_alun");
                    aluno.Nome = DAOHelper.GetString(reader, "nome_alun");
                    aluno.Naturalidade = DAOHelper.GetString(reader, "naturalidade_alun");
                    aluno.Nacionalidade = DAOHelper.GetString(reader, "nacionalidade_alun");
                    aluno.Data_nascimento = DAOHelper.GetDateTime(reader, "data_nascimento_alun");
                    aluno.Cpf = DAOHelper.GetString(reader, "cpf_alun");
                    aluno.Rg = DAOHelper.GetString(reader, "rg_alun");
                    aluno.id_sex_fk = reader.GetInt32("id_sex_fk");
                    aluno.Doencas_especialidades = DAOHelper.GetString(reader, "doencas_especialidades_alun");
                    aluno.Nis = DAOHelper.GetString(reader, "nis_alun");
                    aluno.Beneficio = DAOHelper.GetString(reader, "beneficio_alun");
                    aluno.Bolsa_familia = DAOHelper.GetString(reader, "Bolsa_familia");
                    aluno.Id_End_Fk = reader.GetInt32("Id_End_Fk");
                    aluno.id_resp_fk = reader.GetInt32("id_resp_fk");
                    aluno.id_esc_fk = reader.GetInt32("id_esc_fk");
                    aluno.Serie = DAOHelper.GetString(reader, "Serie");
                    aluno.Parecer_social = DAOHelper.GetString(reader, "parecer_social_alun");
                    aluno.Nivel_prioridade = reader.GetInt32("nivel_prioridade_alun");
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
    }
}
