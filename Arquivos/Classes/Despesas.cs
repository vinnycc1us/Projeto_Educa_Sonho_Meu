using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Despesas
    {
        public int Id {  get; set; }
        public string Doador { get; set; }
        public double Valor { get; set; }
        public string Destino { get; set; }
        public DateTime? Data { get; set; }

        public Despesas(int id_desp, string doador_desp, double valor_desp, string destino_desp, DateTime? data_desp)
        {
            this.Id = id_desp;
            this.Doador = doador_desp;
            this.Valor = valor_desp;
            this.Destino = destino_desp;
            this.Data = data_desp;
        }

        public Despesas()
        {
        }
    }
}
