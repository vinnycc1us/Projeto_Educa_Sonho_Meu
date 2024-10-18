using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Despesas
    {
        public int id_desp {  get; set; }
        public string doador_desp { get; set; }
        public double valor_desp { get; set; }
        public string destino_desp { get; set; }
        public DateTime data_desp { get; set; }

        public Despesas(int id_desp, string doador_desp, double valor_desp, string destino_desp, DateTime data_desp)
        {
            this.id_desp = id_desp;
            this.doador_desp = doador_desp;
            this.valor_desp = valor_desp;
            this.destino_desp = destino_desp;
            this.data_desp = data_desp;
        }
    }
}
