using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Responsavel
    {
        public int Id { get; set; }
        public string Nome_Completo { get; set; }
        public string Cpf {  get; set; }
        public string Rg { get; set; }
        public string Orgao_Expeditor { get; set; }
        public string Telefone { get; set; }
        public string Telefone_Alternativo { get; set; }
        public string Telefone_Fixo { get; set; }
        public string telefone_recado_resp { get; set; }

        public Responsavel(string Nome_Completo, string Cpf, string Rg, string Orgao_Expeditor, 
            string Telefone, string Telefone_Alternativo, string Telefone_Fixo, string telefone_recado_resp)
        {
            this.Nome_Completo = Nome_Completo;
            this.Cpf = Cpf;
            this.Rg = Rg;
            this.Orgao_Expeditor = Orgao_Expeditor;
            this.Telefone = Telefone;
            this.Telefone_Alternativo = Telefone_Alternativo;
            this.Telefone_Fixo = Telefone_Fixo;
            this.telefone_recado_resp = telefone_recado_resp;
        }

        public Responsavel()
        {
        }
    }
}
