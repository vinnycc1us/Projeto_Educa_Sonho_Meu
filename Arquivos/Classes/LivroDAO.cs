using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
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

                comando.Parameters.AddWithValue("@nome", livro.nome_liv);
                comando.Parameters.AddWithValue("@quantidade", livro.quantidade_liv);
                comando.Parameters.AddWithValue("@descricao", livro.descricao_liv);
                comando.Parameters.AddWithValue("@valor", livro.valor_liv);
                comando.Parameters.AddWithValue("@num_paginas", livro.num_paginas_liv);
                comando.Parameters.AddWithValue("@autor", livro.autor_liv);
                comando.Parameters.AddWithValue("@editora", livro.editora_liv);
                comando.Parameters.AddWithValue("@ano_aplicacao", livro.ano_aplicacao_liv);
                comando.Parameters.AddWithValue("@ano_impressao", livro.ano_impressao_liv);
                comando.Parameters.AddWithValue("@area_aplicacao", livro.area_aplicacao_liv);

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

        public List<livro> List()
        {
            try
            {
                var lista = new List<livro>();
                var comando = _conn.Query();

                comando.CommandText = "SELECT * FROM livro";

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    var livro = new livro();

                    livro.Id = reader.GetInt32("id_esc");
                    livro.NomeFantasia = DAOHelper.GetString(reader, "nome_fantasia_esc");
                    livro.RazaoSocial = DAOHelper.GetString(reader, "razao_social_esc");
                    livro.Cnpj = DAOHelper.GetString(reader, "cnpj_esc");
                    livro.InscEstadual = DAOHelper.GetString(reader, "insc_estadual_esc");
                    livro.Tipo = DAOHelper.GetString(reader, "tipo_esc");
                    livro.Email = DAOHelper.GetString(reader, "email_esc");
                    livro.Telefone = DAOHelper.GetString(reader, "telefone_esc");
                    livro.Responsavel = DAOHelper.GetString(reader, "responsavel_esc");
                    livro.ResponsavelTelefone = DAOHelper.GetString(reader, "responsavel_telefone_esc");
                    livro.DataCriacao = DAOHelper.GetDateTime(reader, "data_criacao_esc");

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

        public void Delete(livro livro)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "DELETE FROM livro WHERE id_esc = @id";

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


        public void Update(livro livro)
        {
            try
            {
                var comando = _conn.Query();

                comando.CommandText = "UPDATE livro SET " +
                "nome_fantasia_esc = @nome, razao_social_esc = @razao, cnpj_esc = @cnpj, insc_estadual_esc = @inscricao," +
                " tipo_esc = @tipo, data_criacao_esc = @data_criacao, responsavel_esc = @resp " +
                "WHERE id_esc = @id";

                comando.Parameters.AddWithValue("@nome", livro.NomeFantasia);
                comando.Parameters.AddWithValue("@razao", livro.RazaoSocial);
                comando.Parameters.AddWithValue("@cnpj", livro.Cnpj);
                comando.Parameters.AddWithValue("@inscricao", livro.InscEstadual);
                comando.Parameters.AddWithValue("@tipo", livro.Tipo);
                comando.Parameters.AddWithValue("@data_criacao", livro.DataCriacao?.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@resp", livro.Responsavel);

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
*/