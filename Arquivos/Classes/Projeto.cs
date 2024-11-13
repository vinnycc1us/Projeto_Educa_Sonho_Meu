using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Projeto
    {
        public int Id {  get; set; }
        public string Nome {  get; set; }
        public string Coordenador { get; set; }
        public string Descricao {  get; set; }
        public int Ano_Inicio { get; set; }

        public Projeto(int id_proj, string nome_proj, string coordenador_proj, string descricao_proj, int Ano_Inicio_proj)
        {
            this.Id = id_proj;
            this.Nome = nome_proj;
            this.Coordenador = coordenador_proj;
            this.Descricao = descricao_proj;
            this.Ano_Inicio = Ano_Inicio_proj;
        }

        public Projeto()
        {
        }
    }
}
