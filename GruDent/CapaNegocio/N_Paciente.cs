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
   public class N_Paciente
    {
        D_Paciente objData = new D_Paciente();

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarPaciente()
        {
            return objData.CD_RellenarPaciente();
        }
        #endregion

        #region Metodo para insertar paciente
        public void CN_InsertarPaciente(E_Paciente paciente)
        {
            objData.CD_InsertarPaciente(paciente);
        }
        #endregion

        #region Metodo para eliminar paciente
        public void CN_EliminarPaciente(int ID)
        {
            objData.CD_EliminarPaciente(ID);
        }
        #endregion

        #region Metodo para actualizar paciente
        public void CN_UpdatePaciente(E_Paciente paciente)
        {
            objData.CD_UpdatePaciente(paciente);
        }
        #endregion
    }
}
