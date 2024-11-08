using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Recursos
    {
        public int Id {get; set;}
        public string Doador {  get; set;} 
        public double Valor { get;set;}
        public string Destino { get; set;}
        public DateTime Date { get; set;}

        public Recursos(int Id, string Doador, double Valor, string Destino, DateTime Date)
        {
            this.Id = Id;
            this.Doador = Doador;
            this.Valor = Valor;
            this.Destino = Destino;
            this.Date = Date;
        }

        public Recursos()
        {
        }
    }
 
}
