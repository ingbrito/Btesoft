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
    public class N_PacienteN
    {
        D_PacienteN objData = new D_PacienteN();

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarPacienteN()
        {
            return objData.CD_RellenarPacienteN();
        }
        #endregion

        #region Metodo para insertar paciente
        public void CN_InsertarPacienteN(E_PacienteN paciente)
        {
            objData.CD_InsertarPacienteN(paciente);
        }
        #endregion

        #region Metodo para eliminar paciente
        public void CN_EliminarPacienteN(int ID)
        {
            objData.CD_EliminarPacienteN(ID);
        }
        #endregion

        #region Metodo para actualizar paciente
        public void CN_UpdatePacienteN(E_PacienteN paciente)
        {
            objData.CD_UpdatePacienteN(paciente);
        }
        #endregion
    }
}
