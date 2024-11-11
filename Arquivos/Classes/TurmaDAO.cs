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

                comando.CommandText = "INSERT INTO Turma VALUES " +
                "(null, @nome, @quabtidade, @descricao, @ano)";


                comando.Parameters.AddWithValue("@nome", obj.Nome);
                comando.Parameters.AddWithValue("@quantidade", obj.Quantidade);
                comando.Parameters.AddWithValue("@descricao", obj.Descricao);
                comando.Parameters.AddWithValue("@ano", obj.Ano);

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
                var lista = new List<Turma>();
                var comando = _conn.Query();


                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var Turma = new Turma();

                    Turma.Id = reader.GetInt32("id_turm");
                    Turma.Nome = DAOHelper.GetString(reader, "nome_turm");
                    Turma.Quantidade = DAOHelper.GetString(reader, "quantidade_turm");
                    Turma.Descricao = DAOHelper.GetString(reader, "descricao_turm");
                    Turma.Ano = reader.GetInt32("ano_turm");
                    
                    lista.Add(Turma);
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

                comando.CommandText = "DELETE FROM Turma WHERE Id = @id";

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
                "Nome = @nome, Quantidade = @quantidade, Descricao = @descricao, Ano = @ano," +
                "WHERE Id = @id";

                
                comando.Parameters.AddWithValue("@nome", obj.Nome);
                comando.Parameters.AddWithValue("@quantidade", obj.Quantidade);
                comando.Parameters.AddWithValue("@descricao", obj.Descricao);
                comando.Parameters.AddWithValue("@ano", obj.Ano);


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

