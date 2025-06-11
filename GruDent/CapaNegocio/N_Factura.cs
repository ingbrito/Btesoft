using CapaData;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Factura
    {
        D_Factura objData = new D_Factura();

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarFactura()
        {
            return objData.CD_RellenarFactura();
        }
        #endregion

        #region Metodo para insertar factura
        public void CN_InsertarFactura(E_Factura factura)
        {
            objData.CD_InsertarFactura(factura);
        }
        #endregion

        #region Metodo para eliminar factura
        public void CN_EliminarFactura(int ID)
        {
            objData.CD_EliminarFactura(ID);
        }
        #endregion

        #region Metodo para actualizar factura
        public void CN_UpdateFactura(E_Factura factura)
        {
            objData.CD_UpdateFactura(factura);
        }
        #endregion
    }
}
