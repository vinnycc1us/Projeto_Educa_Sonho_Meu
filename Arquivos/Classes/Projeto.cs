using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Projeto
    {
        public int id_proj {  get; set; }
        public string nome_proj {  get; set; }
        public string coordenador_proj { get; set; }
        public string descricao_proj {  get; set; }
        public int ano_inicio_proj { get; set; }

        public Projeto(int id_proj, string nome_proj, string coordenador_proj, string descricao_proj, int ano_inicio_proj)
        {
            this.id_proj = id_proj;
            this.nome_proj = nome_proj;
            this.coordenador_proj = coordenador_proj;
            this.descricao_proj = descricao_proj;
            this.ano_inicio_proj = ano_inicio_proj;
        }
    }
}
