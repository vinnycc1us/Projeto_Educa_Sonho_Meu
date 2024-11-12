using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Funcionario
    {
        public int id_func {  get; set; }
        public string nome_func {  get; set; }
        public string cpf_func { get; set; }
        public string ctps_func {  get; set; }
        public string rg_func {  get; set; }
        public string funcao_func {  get; set; }
        public int Id_fk {  get; set; }
        public string num_telefone_func {  get; set; }
        public int id_end_fk {  get; set; }

        public Funcionario(int id_func, string nome_func, string cpf_func, string ctps_func, string rg_func, string funcao_func, int Id_fk, string num_telefone_func, int id_end_fk)
        {
            this.id_func = id_func;
            this.nome_func = nome_func;
            this.cpf_func = cpf_func;
            this.ctps_func = ctps_func;
            this.rg_func = rg_func;
            this.funcao_func = funcao_func;
            this.Id_fk = Id_fk;
            this.num_telefone_func = num_telefone_func;
            this.id_end_fk = id_end_fk;
        }
    }
}
