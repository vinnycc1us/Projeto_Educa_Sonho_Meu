using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Evento
    {
        public int id_even {  get; set; }
        public string nome_even { get; set; }
        public DateTime dat_even { get; set; }
        public int id_end_fk { get; set; }
        public string descricao_even { get; set; }

        public Evento(int id_even, string nome_even, DateTime dat_even, int id_end_fk, string descricao_even)
        {
            this.id_even = id_even;
            this.nome_even = nome_even;
            this.dat_even = dat_even;
            this.id_end_fk = id_end_fk;
            this.descricao_even = descricao_even;
        }

        public Evento()
        {
        }
    }
}
