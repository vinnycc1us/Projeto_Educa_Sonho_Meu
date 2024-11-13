using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
     public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Quantidade { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }

        public Turma(string Nome, string Quantidade, string Descricao, int Ano)
        {
            this.Nome = Nome;
            this.Quantidade = Quantidade;
            this.Descricao = Descricao;
            this.Ano = Ano;
        }

        public Turma()
        {
        }
    }
}
