using CapaData;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class N_Cotizacion   
    {
        D_Cotizacion objData = new D_Cotizacion();

        #region Metodo para insertar pago
        public void CN_InsertarCotizacion(E_Cotizacion cotizacion)
        {
            objData.CD_InsertarCotizacion(cotizacion);
        }
        #endregion
    }
}
