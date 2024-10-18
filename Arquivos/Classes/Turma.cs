using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Turma
    {
        public int id_turm { get; set; }
        public string nome_turm { get; set; }
        public string quantidade_turm { get; set; }
        public string descricao_turm { get; set; }
        public int ano_turm { get; set; }

        public Turma(string nome_turm, string quantidade_turm, string descricao_turm, int ano_turm)
        {
            this.nome_turm = nome_turm;
            this.quantidade_turm = quantidade_turm;
            this.descricao_turm = descricao_turm;
            this.ano_turm = ano_turm;
        }
    }
}
