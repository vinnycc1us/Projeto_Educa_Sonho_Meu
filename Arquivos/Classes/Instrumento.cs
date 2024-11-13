using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Instrumento
    {
        public int Id {get;set;}
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Instrumento(string Nome, int Quantidade, string Descricao, double Valor
            )
        {
            this.Nome = Nome;
            this.Quantidade = Quantidade;
            this.Descricao = Descricao;
            this.Valor = Valor;
        }

        public Instrumento()
        {
        }
    }
}
