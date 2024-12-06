using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class LivroDAO
    {
        private static Conexao _conn = new Conexao();

        public void Insert(Livro livro)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "INSERT INTO livro VALUES " +
                "(null, @nome, @quantidade, @descricao, @valor, @num_paginas, @autor, @editora, @ano_aplicacao, " +
                "@ano_impressao, @area_aplicacao);";

                comando.Parameters.AddWithValue("@nome", livro.Nome);
                comando.Parameters.AddWithValue("@quantidade", livro.Quantidade);
                comando.Parameters.AddWithValue("@descricao", livro.Descricao);
                comando.Parameters.AddWithValue("@valor", livro.Valor);
                comando.Parameters.AddWithValue("@num_paginas", livro.Num_Paginas);
                comando.Parameters.AddWithValue("@autor", livro.Autor);
                comando.Parameters.AddWithValue("@editora", livro.Editora);
                comando.Parameters.AddWithValue("@ano_aplicacao", livro.Ano_Aplicacao);
                comando.Parameters.AddWithValue("@ano_impressao", livro.Ano_Impressao);
                comando.Parameters.AddWithValue("@area_aplicacao", livro.Area_Aplicacao);

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

        public List<Livro> List()
        {
            try
            {
                var lista = new List<Livro>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM livro";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var livro = new Livro();

                    livro.Id = reader.GetInt32("id_esc");
                    livro.Nome = DAOHelper.GetString(reader, "nome_fantasia_esc");
                    livro.Quantidade = reader.GetInt32("razao_social_esc");
                    livro.Descricao = DAOHelper.GetString(reader, "cnpj_esc");
                    livro.Valor = reader.GetInt32("insc_estadual_esc");
                    livro.Num_Paginas = reader.GetInt32("tipo_esc");
                    livro.Autor = DAOHelper.GetString(reader, "email_esc");
                    livro.Editora = DAOHelper.GetString(reader, "telefone_esc");
                    livro.Ano_Aplicacao = reader.GetInt32("responsavel_esc");
                    livro.Ano_Impressao = reader.GetInt32("responsavel_telefone_esc");
                    livro.Area_Aplicacao = DAOHelper.GetString(reader, "data_criacao_esc");

                    lista.Add(livro);
                }

                reader.Close();

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        public void Delete(Livro livro)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM livro WHERE id_liv = @id";

                comando.Parameters.AddWithValue("@id", livro.Id);

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
        

        

        public void Update(Livro livro)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE livro SET " +
                "nome_liv = @nome, quantidade_liv = @quantidade, descricao_liv = @descricao, valor_çiv = @valor," +
                " num_paginas_liv = @num_paginas, autor_liv = @autor, editora_liv = @editora, ano_aplicacao_liv = @ano_aplicacao, ano_impressao_liv = @ano_impressao, area_aplicacao_liv = @area_aplicacao" +
                "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", livro.Nome);
                comando.Parameters.AddWithValue("@quantidade", livro.Quantidade);
                comando.Parameters.AddWithValue("@descricao", livro.Descricao);
                comando.Parameters.AddWithValue("@valor", livro.Valor);
                comando.Parameters.AddWithValue("@num_paginas", livro.Num_Paginas);
                comando.Parameters.AddWithValue("@autor", livro.Autor);
                comando.Parameters.AddWithValue("@editora", livro.Editora);
                comando.Parameters.AddWithValue("@ano_aplicacao", livro.Ano_Aplicacao);
                comando.Parameters.AddWithValue("@ano_mpressao", livro.Ano_Impressao);
                comando.Parameters.AddWithValue("@area_aplicacao", livro.Area_Aplicacao);

                comando.Parameters.AddWithValue("@id", livro.Id);

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
