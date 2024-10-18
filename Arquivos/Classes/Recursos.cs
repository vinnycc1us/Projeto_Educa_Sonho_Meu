using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Recursos
    {
        public int id_recu {get; set;}
        public string doador_recu {  get; set;} 
        public double valor_recu { get;set;}
        public string destino_recu { get; set;}
        public DateTime date_recu { get; set;}

        public Recursos(int id_recu, string doador_recu, double valor_recu, string destino_recu, DateTime date_recu)
        {
            this.id_recu = id_recu;
            this.doador_recu = doador_recu;
            this.valor_recu = valor_recu;
            this.destino_recu = destino_recu;
            this.date_recu = date_recu;
        }
    }
 
}
