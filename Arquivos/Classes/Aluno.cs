using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Naturalidade { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime? Data_nascimento { get; set; }
        public string Cpf {  get; set; }
        public string Rg { get; set; }
        public int id_sex_fk { get; set; }
        public string Doencas_especialidades {  get; set; }
        public string Nis { get; set; }
        public string Beneficio { get; set; }
        public string Bolsa_familia { get; set; }
        public int id_end_fk {  get; set; }
        public int Id_fk {  get; set; }
        public int id_esc_fk { get; set; }
        public string Serie { get; set; }
        public string Parecer_social {  get; set; }
        public int Nivel_prioridade { get; set; }
        public Aluno(int id_alun, string nome_alun, string naturalidade_alun, string nacionalidade_alun, DateTime? data_nascimento_alun, string cpf_alun, string rg_alun, int id_sex_fk, string doencas_especialidades, string nis_alun, string beneficio_alun, string bolsa_familia_alun, int id_end_fk, int id_resp_fk, int id_esc_fk, string serie_alun, string parecer_social, int nivel_prioridade_alun)
        {
            this.Id = id_alun;
            this.Nome = nome_alun;
            this.Naturalidade = naturalidade_alun;
            this.Nacionalidade = nacionalidade_alun;
            this.Data_nascimento = data_nascimento_alun;
            this.Cpf = cpf_alun;
            this.Rg = rg_alun;
            this.id_sex_fk = id_sex_fk;
            this.Doencas_especialidades = doencas_especialidades;
            this.Nis = nis_alun;
            this.Beneficio = beneficio_alun;
            this.Bolsa_familia = bolsa_familia_alun;
            this.id_end_fk = id_end_fk;
            this.Id_fk = Id_fk;
            this.id_esc_fk = id_esc_fk;
            this.Serie = serie_alun;
            this.Parecer_social = parecer_social;
            this.Nivel_prioridade = nivel_prioridade_alun;
        }

        public Aluno()
        {
        }
    }
}
