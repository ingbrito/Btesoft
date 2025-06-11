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
    public class N_HistoricoPago
    {
        D_HistoricoPago objData = new D_HistoricoPago();

        #region Llamar metodo de rellenar dgv
        public DataTable CN_RellenarHistorico(int historicop)
        {
            return objData.CD_RellenarHistorico(historicop);
        }
        
        #endregion

        #region Llamar metodo de rellenar dgv historicoconsu
        public DataTable CN_RellenarHistoricoConsulta(int historico)
        {
            return objData.CD_RellenarHistoricoConsulta(historico);
        }
        #endregion

        #region Metodo para insertar pago
        public void CN_InsertarPago(E_HistoricoPago historico)
        {
            objData.CD_InsertarPago(historico);
        }
        #endregion

        #region Metodo para eliminar pago
        public void CN_EliminarPago(int ID)
        {
            objData.CD_EliminarPago(ID);
        }
        #endregion

    }
}
