using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{

    public class E_CargarCitas
    {
        public int IdCita { get; set; }
        public int IdPaciente { get; set; }
        public int IdDoctor { get; set; } = 1; // Default value, can be changed later
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Observacion { get; set; }
        public string EstadoCita { get; set; } = "Pendiente"; // Default value
        public DateTime FechaRegistro { get; set; } = DateTime.Now; // Default to current date and time

    }
}
