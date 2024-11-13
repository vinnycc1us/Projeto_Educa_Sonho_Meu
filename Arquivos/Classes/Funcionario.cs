using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Funcionario
    {
        public int Id {  get; set; }
        public string Nome {  get; set; }
        public string Cpf { get; set; }
        public string Ctps {  get; set; }
        public string Rg {  get; set; }
        public string Funcao {  get; set; }
        public Sala Sala { get; set; }
        public int Id_Sal_Fk {  get; set; }
        public string Numero {  get; set; }
        public Endereco Endereco { get; set; }
        public int Id_End_Fk {  get; set; }

        public Funcionario(int Id, string Nome, string Cpf, string Ctps, string Rg, string Funcao, int Id_Sal_Fk, string Numero, int Id_End_Fk)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Ctps = Ctps;
            this.Rg = Rg;
            this.Funcao = Funcao;
            this.Id_Sal_Fk = Id_Sal_Fk;
            this.Numero = Numero;
            this.Id_End_Fk = Id_End_Fk;
        }

        public Funcionario()
        {
        }
    }
}
