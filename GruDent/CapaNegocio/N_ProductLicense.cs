using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaData;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_ProductLicense
    {
        D_License objData = new D_License();

        #region Metodo para insertar Licencia
        public void CN_InsertarLicencia(E_ProductLicense licencia)
        {
            objData.CD_InsertarLicencia(licencia);
        }
        #endregion

        #region Metodo para actualizar Fecha Licencia
        public void CN_UpdateLicencia(E_ProductLicense licencia)
        {
            objData.CD_UpdateLicencia(licencia);
        }
        #endregion

    }
}
