using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Sala
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public string Capacidade {get; set; }
        public Turma Turma {  get; set; }
        public int Id_Turm_Fk {get; set; }

        public Sala(string Nome, string Localizacao, string Capacidade, int Id_Sal_Fk)
        {
            this.Nome = Nome;
            this.Localizacao = Localizacao;
            this.Capacidade = Capacidade;
            this.Id_Turm_Fk = Id_Turm_Fk;
        }

        public Sala()
        {
        }
    }
}
