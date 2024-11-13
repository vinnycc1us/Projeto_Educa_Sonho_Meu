using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Educa_Sonho_Meu.Arquivos.Classes
{
    public class Material
    {
        
        public int Id {  get; set; }
        public string Nome {  get; set; }
        public int Quantidade {  get; set; }
        public string Descricao {  get; set; }
        public double Valor {  get; set; }
        public Sala sala { get; set; }
        public int Id_Sal_Fk {  get; set; }

        public Material(int id, string nome, int quantidade, string descricao, double valor, int id_Sal_Fk)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
            Descricao = descricao;
            Valor = valor;
            Id_Sal_Fk = id_Sal_Fk;
        }

        public Material()
        {
        }
    }

  

}
