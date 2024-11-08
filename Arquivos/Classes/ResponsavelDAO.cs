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
                var lista = new List<Responsavel>();
                var comando = _conn.Query();

                
                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var responsavel = new Responsavel();

                    responsavel.id_resp = reader.GetInt32("id_resp");
                    responsavel.nome_completo_resp = DAOHelper.GetString(reader, "nome_completo_resp");
                    responsavel.cpf_resp = DAOHelper.GetString(reader, "cpf_resp");
                    responsavel.rg_resp = DAOHelper.GetString(reader, "rg_resp");
                    responsavel.orgao_expeditor_resp = reader.GetString("orgao_expeditor_resp");
                    responsavel.telefone_resp = DAOHelper.GetString(reader, "telefoe_resp");
                    responsavel.telefone_alternativo_resp = DAOHelper.GetString(reader, "telefone-alternativo_resp");
                    responsavel.telefone_fixo_resp = DAOHelper.GetString(reader, "telefone_fixo_resp");
                    responsavel.telefone_recado_resp = DAOHelper.GetString(reader, "telefone_recado_resp");

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

                comando.CommandText = "DELETE FROM responsavel WHERE id_resp = @id";

                comando.Parameters.AddWithValue("@id", obj.id_resp);

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
                "nome_completo_resp = @nome-completo, cpf_resp = @cpf, rg_resp = @rg, orgao-expeditor_resp = @orgao_expeditor," +
                " telefone_resp = @telefone, telefone_alternativo_resp = @telefone_alternativo, telefone_fixo_resp = @telefone_fixo, telefone_recado_resp = @telefone_recado " +
                "WHERE id_resp = @id";

                
                comando.Parameters.AddWithValue("@nome", obj.nome_completo_resp);
                comando.Parameters.AddWithValue("@cpf", obj.cpf_resp);
                comando.Parameters.AddWithValue("@rg", obj.rg_resp);
                comando.Parameters.AddWithValue("@orgao_expeditor", obj.orgao_expeditor_resp);
                comando.Parameters.AddWithValue("@telefone", obj.telefone_resp);
                comando.Parameters.AddWithValue("@telefone_alternativo", obj.telefone_alternativo_resp);
                comando.Parameters.AddWithValue("@telefone_fixo", obj.telefone_fixo_resp);
                comando.Parameters.AddWithValue("@telefone_recado", obj.telefone_recado_resp);

                comando.Parameters.AddWithValue("@id", obj.id_resp);
                

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

