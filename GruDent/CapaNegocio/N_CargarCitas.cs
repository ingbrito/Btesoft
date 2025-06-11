using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaData;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class N_CargarCitas
    {
        D_CargarCitas objData = new D_CargarCitas();

        public void CN_InsertarCita(E_CargarCitas cita)
        {
            objData.CD_InsertarCita(cita);
        }

        public DataTable CN_ObtenerCitas()
        {
            return objData.CD_ObtenerCitas();
        }
    }
}
