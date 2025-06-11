using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_HistoricoPago
    {
        public int ID { get; set; }
        public int IdFactura { get; set; }
        public double Deuda { get; set; }
        public double Abono { get; set; }
        public double Resto { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }

    }
}
