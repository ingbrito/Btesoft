using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Odontograma
    {
        public int ID { get; set; }
        public int IdDoctor { get; set; }
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaConsult { get; set; }
        public string NombreDoctor { get; set; }
        public string Motivo { get; set; }
        public string Plan_Tratamiento { get; set; }
        public string Observaciones { get; set; }
        public string Diagnostic { get; set; }
        public string Process { get; set; }
        public string Indicacion { get; set; }
        public byte[] Foto { get; set; }
        public byte[] ImagenOdontograma { get; set; }
        public string FichaConsult { get; set; }

    }
}
