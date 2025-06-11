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
    public class N_Procedimientos
    {
        D_Procedimiento objData = new D_Procedimiento();

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarProcedimiento()
        {
            return objData.CD_RellenarProcedimiento();
        }
        #endregion

        #region Metodo para insertar procedimiento
        public void CN_InsertarProcedimiento(E_Procedimientos procedimiento)
        {
            objData.CD_InsertarProcedimiento(procedimiento);
        }
        #endregion

        #region Metodo para eliminar procedimiento
        public void CN_EliminarProcedimiento(int ID)
        {
            objData.CD_EliminarProcedimiento(ID);
        }
        #endregion

        #region Metodo para actualizar procedimiento
        public void CN_UpdateProcedimiento(E_Procedimientos procedimiento)
        {
            objData.CD_UpdateProcedimiento(procedimiento);
        }
        #endregion
    }
}
