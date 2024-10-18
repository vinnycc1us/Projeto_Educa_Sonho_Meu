using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    internal class Livro
    {
         public int id_liv { get; set; }
        public string nome_liv { get; set; }
        public int quantidade_liv { get; set; }
        public string descricao_liv { get; set; }
        public double valor_liv { get; set; }
        public int num_paginas_liv { get; set; }
        public string autor_liv { get; set; }
        public string editora_liv { get; set; }
        public int ano_aplicacao_liv { get; set; }
        public int ano_impressao_liv { get; set; }
        public string area_aplicacao_liv { get; set; }

        public Livro(string nome_liv, int quantidade_liv, string descricao_liv, double valor_liv, int num_paginas_liv, string autor_liv, string editora_liv, int ano_aplicacao_liv, int ano_impressao_liv, string area_aplicacao_liv)
        {
            this.nome_liv = nome_liv;
            this.quantidade_liv = quantidade_liv;
            this.descricao_liv = descricao_liv;
            this.valor_liv = valor_liv;
            this.num_paginas_liv = num_paginas_liv;
            this.autor_liv = autor_liv;
            this.editora_liv = editora_liv;
            this.ano_aplicacao_liv = ano_aplicacao_liv;
            this.ano_impressao_liv = ano_impressao_liv;
            this.area_aplicacao_liv = area_aplicacao_liv;
        }
    }
}
