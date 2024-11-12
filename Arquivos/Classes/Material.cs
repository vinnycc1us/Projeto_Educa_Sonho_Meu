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
        
        public int id_mate {  get; set; }
        public string nome_mate {  get; set; }
        public int quantidade_mate {  get; set; }
        public string descricao_mate {  get; set; }
        public double valor_mate {  get; set; }
        public int Id_fk {  get; set; }
    }
}
