using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Aluno
    {
        public int id_alun { get; set; }
        public string nome_alun { get; set; }
        public string naturalidade_alun { get; set; }
        public DateTime data_nascimento_alun { get; set; }
        public string cpf_alun {  get; set; }
        public string rg_alun { get; set; }
        public int id_sex_fk { get; set; }
        public string doencas_especialidades {  get; set; }
        public string nis_alun { get; set; }
        public string beneficio_alun { get; set; }
        public string bolsa_familia_alun { get; set; }
        public int id_end_fk {  get; set; }
        public int id_resp_fk {  get; set; }
        public int id_esc_fk { get; set; }
        public string serie_alun { get; set; }
        public string parecer_social {  get; set; }
        public int nivel_prioridade_alun { get; set; }
        public Aluno(int id_alun, string nome_alun, string naturalidade_alun, DateTime data_nascimento_alun, string cpf_alun, string rg_alun, int id_sex_fk, string doencas_especialidades, string nis_alun, string beneficio_alun, string bolsa_familia_alun, int id_end_fk, int id_resp_fk, int id_esc_fk, string serie_alun, string parecer_social, int nivel_prioridade_alun)
        {
            this.id_alun = id_alun;
            this.nome_alun = nome_alun;
            this.naturalidade_alun = naturalidade_alun;
            this.data_nascimento_alun = data_nascimento_alun;
            this.cpf_alun = cpf_alun;
            this.rg_alun = rg_alun;
            this.id_sex_fk = id_sex_fk;
            this.doencas_especialidades = doencas_especialidades;
            this.nis_alun = nis_alun;
            this.beneficio_alun = beneficio_alun;
            this.bolsa_familia_alun = bolsa_familia_alun;
            this.id_end_fk = id_end_fk;
            this.id_resp_fk = id_resp_fk;
            this.id_esc_fk = id_esc_fk;
            this.serie_alun = serie_alun;
            this.parecer_social = parecer_social;
            this.nivel_prioridade_alun = nivel_prioridade_alun;
        }
    }
}
