using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Escola
    {
        public int id_esc { get; set; }
        public string nome_esc {get; set; }
        public int id_end_fk {get; set; }

        public Escola(string nome_esc, int id_end_fk)
        {
            this.nome_esc = nome_esc;
            this.id_end_fk = id_end_fk;
        }
    }
}
