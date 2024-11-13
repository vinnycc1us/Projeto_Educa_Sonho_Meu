using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Num_Paginas { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Ano_Aplicacao { get; set; }
        public int Ano_Impressao { get; set; }
        public string Area_Aplicacao { get; set; }

        public Livro(string Nome, int Quantidade, string Descricao, double Valor, int Num_Paginas, string Autor, string Editora, int Ano_Aplicacao, int Ano_Impressao, string Area_Aplicacao)
        {
            this.Nome = Nome;
            this.Quantidade = Quantidade;
            this.Descricao = Descricao;
            this.Valor = Valor;
            this.Num_Paginas = Num_Paginas;
            this.Autor = Autor;
            this.Editora = Editora;
            this.Ano_Aplicacao = Ano_Aplicacao;
            this.Ano_Impressao = Ano_Impressao;
            this.Area_Aplicacao = Area_Aplicacao;
        }

        public Livro()
        {
        }
    }
}
