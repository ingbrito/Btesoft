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
    public class N_Usuario
    {

        D_Usuario objData = new D_Usuario();

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarUsuario()
        {
            return objData.CD_RellenarUsuario();
        }
        #endregion

        #region Metodo para insertar Usuarios
        public void CN_InsertarUsuario(E_Usuario usuario)
        {
            objData.CD_InsertarUsuario(usuario);
        }
        #endregion

        #region Metodo para eliminar Usuario
        public void CN_EliminarUsuario(int ID)
        {
            objData.CD_EliminarUsuario(ID);
        }
        #endregion

        #region Metodo para actualizar Usuario
        public void CN_UpdateUsuario(E_Usuario usuario)
        {
            objData.CD_UpdateUsuario(usuario);
        }
        #endregion
    }
}
