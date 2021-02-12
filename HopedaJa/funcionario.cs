using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopedaJa
{
   public class funcionario
    {
        public int idfunc { set; get; }
        public string nome { set; get; }
        public string cpf { set; get; }
        public string datanasc { set; get; }
        public string telefone { set; get; }
        public string cargo { set; get; }
        public string turno { set; get; }
        public string admissao { set; get; }
        public Image imagem { set; get; }
        public string senha { get; set; }
    }
}
