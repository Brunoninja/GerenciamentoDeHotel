using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopedaJa
{
    public class reservas
    {
        public int idreserva { get; set; }
        public int idhospede { get; set; }
        public int idapartamento { get; set; }
        public string entrada { get; set; }
        public string saida { get; set; }
        public int apartamento { get; set; }
        public string categoria { get; set; }
        public int diarias { get; set; }
        public int adultos { get; set; }
        public int criancas { get; set; }
        public string situacao { get; set; }
        public string valortotal { get; set; }
    }
}
