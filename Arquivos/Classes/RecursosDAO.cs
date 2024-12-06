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


                comando.Parameters.AddWithValue("@doador", obj.Doador);
                comando.Parameters.AddWithValue("@valor", obj.Valor);
                comando.Parameters.AddWithValue("@destino", obj.Destino);
                comando.Parameters.AddWithValue("@date", obj.Date);

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

                    recursos.Id = reader.GetInt32("id_recu");
                    recursos.Doador = DAOHelper.GetString(reader, "doador_recu");
                    recursos.Valor = DAOHelper.GetDouble(reader, "valor_recu");
                    recursos.Destino = DAOHelper.GetString(reader, "destino_recu");
                    recursos.Date = reader.GetDateTime("date_recu");
                   
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

                comando.CommandText = "DELETE FROM recursos WHERE Id = @id";

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

                comando.CommandText = "UPDATE Recursos SET " +
                "Doador = @doador, Valor = @valor, Destino = @destino," +
                " Date = @date" + "WHERE Id = @id";

                           
                comando.Parameters.AddWithValue("@doador", obj.Doador);
                comando.Parameters.AddWithValue("@cnpj", obj.Valor);
                comando.Parameters.AddWithValue("@inscricao", obj.Destino);
                comando.Parameters.AddWithValue("@tipo", obj.Date);
;

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

