using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Sala
    {
        public int id_sal {  get; set; }
        public string nome_sal { get; set; }
        public string localizacao_sal { get; set; }
        public string capacidade_sal {get; set; }
        public Turma turma {  get; set; }
        public int id_turma_fk {get; set; }

        public Sala(string nome_sal, string localizacao_sal, string capacidade_sal, int id_turm_fk)
        {
            this.nome_sal = nome_sal;
            this.localizacao_sal = localizacao_sal;
            this.capacidade_sal = capacidade_sal;
            this.id_turma_fk = id_turma_fk;
        }

        public Sala()
        {
        }
    }
}
