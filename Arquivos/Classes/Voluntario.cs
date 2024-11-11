using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Voluntario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { set; get; }
        public string Rg {get; set;}
        public int Numero_Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public int Id_End_Fk {get; set;}

        public Voluntario(string Nome, string Cpf, string Rg, int Numero_Telefone, int Id_End_Fk)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Rg = Rg;
            this.Numero_Telefone = Numero_Telefone;
            this.Id_End_Fk = Id_End_Fk;
        }

        public Voluntario()
        {
        }
    }
}
