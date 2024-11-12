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
                "(null, @nome_completo, @cpf, @rg, @orgao_expeditor, @telefone, @telefone_alternativo, @telefone_fixo, @telefone_recado)";


                comando.Parameters.AddWithValue("@nome", obj.Nome_Completo);
                comando.Parameters.AddWithValue("@cpf", obj.Cpf);
                comando.Parameters.AddWithValue("@rg", obj.Rg);
                comando.Parameters.AddWithValue("@orgao_expeditor", obj.Orgao_Expeditor);
                comando.Parameters.AddWithValue("@telefone", obj.Telefone);
                comando.Parameters.AddWithValue("@telefone_alternativo", obj.Telefone_Alternativo);
                comando.Parameters.AddWithValue("@telefone_fixo", obj.Telefone_Fixo);
                comando.Parameters.AddWithValue("@telefone_recado", obj.Telefone_Recado);

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
                var lista = new List<Responsavel>();
                var comando = _conn.Query();

                
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var responsavel = new Responsavel();

                    responsavel.Id = reader.GetInt32("id_resp");
                    responsavel.Nome_Completo = DAOHelper.GetString(reader, "nome_completo_resp");
                    responsavel.Cpf = DAOHelper.GetString(reader, "cpf_resp");
                    responsavel.Rg = DAOHelper.GetString(reader, "rg_resp");
                    responsavel.Orgao_Expeditor = reader.GetString("orgao_expeditor_resp");
                    responsavel.Telefone = DAOHelper.GetString(reader, "telefoe_resp");
                    responsavel.Telefone_Alternativo = DAOHelper.GetString(reader, "telefone-alternativo_resp");
                    responsavel.Telefone_Fixo = DAOHelper.GetString(reader, "telefone_fixo_resp");
                    responsavel.Telefone_Recado = DAOHelper.GetString(reader, "Telefone_Recado");

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

                comando.CommandText = "DELETE FROM responsavel WHERE Id = @id";

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

                comando.CommandText = "UPDATE Responsavel SET " +
                "Nome_Completo = @nome-completo, Cpf = @cpf, Rg = @rg, orgao-expeditor_resp = @orgao_expeditor," +
                " Telefone = @telefone, Telefone_Alternativo = @telefone_alternativo, Telefone_Fixo = @telefone_fixo, Telefone_Recado = @telefone_recado " +
                "WHERE Id = @id";

                
                comando.Parameters.AddWithValue("@nome", obj.Nome_Completo);
                comando.Parameters.AddWithValue("@cpf", obj.Cpf);
                comando.Parameters.AddWithValue("@rg", obj.Rg);
                comando.Parameters.AddWithValue("@orgao_expeditor", obj.Orgao_Expeditor);
                comando.Parameters.AddWithValue("@telefone", obj.Telefone);
                comando.Parameters.AddWithValue("@telefone_alternativo", obj.Telefone_Alternativo);
                comando.Parameters.AddWithValue("@telefone_fixo", obj.Telefone_Fixo);
                comando.Parameters.AddWithValue("@telefone_recado", obj.Telefone_Recado);

                comando.Parameters.AddWithValue("@id", obj.Id);
                

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

