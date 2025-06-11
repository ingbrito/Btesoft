using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class E_Cotizacion
    {
        public int ID { get; set; }
        public int idpaciente { get; set; }
        public int numeroCotizacion { get; set; }
        public string nombrePaciente { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public DateTime Fecha { get; set; }
        public string condicion { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public float precio { get; set; }
        public float subtotal { get; set; }
        public int  descuento { get; set; }
        public float total { get; set; }
    }

}
