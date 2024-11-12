using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Escola
    {
        public int Id { get; set; }
        public string Nome {get; set; }
        public int id_end_fk {get; set; }

        public Escola(int Id, string nome_esc, int id_end_fk)
        {
            this.Id = Id;
            this.Nome = nome_esc;
            this.id_end_fk = id_end_fk;
        }

        public Escola()
        {
        }
    }
}
