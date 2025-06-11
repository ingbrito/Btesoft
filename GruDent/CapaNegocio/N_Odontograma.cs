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
   public class N_Odontograma
    {
        D_Odontograma objData = new D_Odontograma();

        #region Metodo para insertar odontograma
        public void CN_InsertarOdontograma(E_Odontograma odontograma)
        {
            objData.CD_InsertarOdontograma(odontograma);
        }
        #endregion

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarPacienteConsulta()
        {
            return objData.CD_RellenarPacienteConsulta();
        }
        #endregion

        #region Metodo para actualizar paciente
        public void CN_UpdateConsulta(E_Odontograma odontograma)
        {
            objData.CD_UpdateConsulta(odontograma);
        }
        #endregion

            private D_Odontograma odontogramaDatos = new D_Odontograma();

            public E_Odontograma ObtenerPorPaciente(int idPaciente)
            {
                return odontogramaDatos.ObtenerPorPaciente(idPaciente);
            }

    }
}
