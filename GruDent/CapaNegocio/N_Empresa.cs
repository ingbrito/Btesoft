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
    public class N_Empresa
    {
        D_Empresa objData = new D_Empresa();

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarEmpresa()
        {
            return objData.CD_RellenarEmpresa();
        }
        #endregion

        #region Metodo para actualizar empresa
        public void CN_UpdateEmpresa(E_Empresa empresa)
        {
            objData.CD_UpdateEmpresa(empresa);
        }
        #endregion

    }
}
