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
    public class N_Doctores
    {
        D_Doctores objData = new D_Doctores();

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarDoctores()
        {
            return objData.CD_RellenarDoctor();
        }
        #endregion

        #region Metodo para insertar doctores
        public void CN_InsertarDoctores(E_Doctores doctores)
        {
            objData.CD_InsertarDoctor(doctores);
        }
        #endregion

        #region Metodo para eliminar doctores
        public void CN_EliminarDoctor(int ID)
        {
            objData.CD_EliminarDoctor(ID);
        }
        #endregion

        #region Metodo para actualizar doctores
        public void CN_UpdateDoctores(E_Doctores doctores)
        {
            objData.CD_UpdateDoctores(doctores);
        }
        #endregion


    public List<E_Doctores> CN_ListarDoctores()
        {
            DataTable dt = objData.CD_RellenarDoctor();
            List<E_Doctores> lista = new List<E_Doctores>();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new E_Doctores
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Nombres = row["Nombres"].ToString(),
                    PrimerApellido = row["PrimerApellido"].ToString(),
                    SegundoApellido = row["SegundoApellido"].ToString()
                });
            }

            return lista;
        }

    }
}
