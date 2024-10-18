using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Responsavel
    {
        public int id_resp { get; set; }
        public string nome_completo_resp { get; set; }
        public string cpf_resp {  get; set; }
        public string rg_resp { get; set; }
        public string orgao_expeditor_resp { get; set; }
        public string telefone_resp { get; set; }
        public string telefone_alternativo_resp { get; set; }
        public string telefone_fixo_resp { get; set; }
        string telefone_recado_resp { get; set; }

        public Responsavel(string nome_completo_resp, string cpf_resp, string rg_resp, string orgao_expeditor_resp, string telefone_resp, string telefone_alternativo_resp, string telefone_fixo_resp, string telefone_recado_resp)
        {
            this.nome_completo_resp = nome_completo_resp;
            this.cpf_resp = cpf_resp;
            this.rg_resp = rg_resp;
            this.orgao_expeditor_resp = orgao_expeditor_resp;
            this.telefone_resp = telefone_resp;
            this.telefone_alternativo_resp = telefone_alternativo_resp;
            this.telefone_fixo_resp = telefone_fixo_resp;
            this.telefone_recado_resp = telefone_recado_resp;
        }
    }
}
