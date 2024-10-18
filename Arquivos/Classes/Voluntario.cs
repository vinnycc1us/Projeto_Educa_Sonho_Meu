using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Voluntario
    {
        public int id_volu { get; set; }
        public string nome_volu { get; set; }
        public string cpf_volu { set; get; }
        public string rg_volu {get; set;}
        public string numero_telefone_volu { get; set; }
        public int id_end_fk {get; set;}

        public Voluntario(string nome_volu, string cpf_volu, string rg_volu, string numero_telefone_volu, int id_end_fk)
        {
            this.nome_volu = nome_volu;
            this.cpf_volu = cpf_volu;
            this.rg_volu = rg_volu;
            this.numero_telefone_volu = numero_telefone_volu;
            this.id_end_fk = id_end_fk;
        }
    }
}
