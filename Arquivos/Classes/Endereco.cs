using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Endereco
    {
        public int Id {  get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }

        public Endereco(int Id, string uf_end, string cidade_end, string bairro_end, string numero_end, string cep_end)
        {
            this.Id = Id;
            this.Uf = uf_end;
            this.Cidade = cidade_end;
            this.Bairro = bairro_end;
            this.Numero = numero_end;
            this.Cep = cep_end;
        }

        public Endereco()
        {
        }
    }
}
