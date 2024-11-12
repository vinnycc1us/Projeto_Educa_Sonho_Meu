using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Evento
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public DateTime? Data { get; set; }
        public int id_end_fk { get; set; }
        public string Descricao { get; set; }

        public Evento(int id_even, string nome_even, DateTime? dat_even, int id_end_fk, string descricao_even)
        {
            this.Id = id_even;
            this.Nome = nome_even;
            this.Data = dat_even;
            this.id_end_fk = id_end_fk;
            this.Descricao = descricao_even;
        }

        public Evento()
        {
        }
    }
}
