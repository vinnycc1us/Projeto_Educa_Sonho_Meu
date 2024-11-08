using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Endereco
    {
        public int id_end {  get; set; }
        public string uf_end { get; set; }
        public string cidade_end { get; set; }
        public string bairro_end { get; set; }
        public string numero_end { get; set; }
        public string cep_end { get; set; }

        public Endereco(string uf_end, string cidade_end, string bairro_end, string numero_end, string cep_end)
        {
            this.uf_end = uf_end;
            this.cidade_end = cidade_end;
            this.bairro_end = bairro_end;
            this.numero_end = numero_end;
            this.cep_end = cep_end;
        }

        public Endereco()
        {
        }
    }
}
