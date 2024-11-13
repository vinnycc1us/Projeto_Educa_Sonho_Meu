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
        public int Id_End_Fk {get; set; }

        public Escola(int Id, string nome_esc, int Id_End_Fk)
        {
            this.Id = Id;
            this.Nome = nome_esc;
            this.Id_End_Fk = Id_End_Fk;
        }

        public Escola()
        {
        }
    }
}
