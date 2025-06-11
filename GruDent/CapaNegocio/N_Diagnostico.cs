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
    public class N_Diagnostico
    {
        D_Diagnostico objData = new D_Diagnostico();

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarDiagnostico()
        {
            return objData.CD_RellenarDiagnostico();
        }
        #endregion

        #region Metodo para insertar diagnostico
        public void CN_InsertarDiagnostico(E_Diagnostico diagnostico)
        {
            objData.CD_InsertarDiagnostico(diagnostico);
        }
        #endregion

        #region Metodo para eliminar diagnostico
        public void CN_EliminarDiagnostico(int ID)
        {
            objData.CD_EliminarDiagnostico(ID);
        }
        #endregion

        #region Metodo para actualizar diagnostico
        public void CN_UpdateDiagnostico(E_Diagnostico diagnostico)
        {
            objData.CD_UpdateDiagnostico(diagnostico);
        }
        #endregion
    }
}
