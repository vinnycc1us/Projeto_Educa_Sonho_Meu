using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Instrumento
    {
        public int id_inst {get;set;}
        public string nome_inst { get; set; }
        public int quantidade_inst { get; set; }
        public string descricao_inst { get; set; }
        public double valor_inst { get; set; }

        public Instrumento(string nome_inst, int quantidade_inst, string descricao_inst, double valor_inst
            )
        {
            this.nome_inst = nome_inst;
            this.quantidade_inst = quantidade_inst;
            this.descricao_inst = descricao_inst;
            this.valor_inst = valor_inst;
        }
    }
}
