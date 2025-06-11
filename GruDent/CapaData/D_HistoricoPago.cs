using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class D_HistoricoPago
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarHistorico( int historicop)
        {
            SqlCommand cmd = new SqlCommand("sp_SelectHistorico", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idb", historicop);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para rellenar el datagrid historico consulta
        public DataTable CD_RellenarHistoricoConsulta(int historico)
        {
            SqlCommand cmd = new SqlCommand("sp_HistCons", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idb", historico);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para insertar pago
        public void CD_InsertarPago(E_HistoricoPago historico)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertPago", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idfactura", historico.IdFactura);
            cmd.Parameters.AddWithValue("@deuda", historico.Deuda);
            cmd.Parameters.AddWithValue("@abono", historico.Abono);
            cmd.Parameters.AddWithValue("@resto", historico.Resto);
            cmd.Parameters.AddWithValue("@fecha", historico.Fecha);
            cmd.Parameters.AddWithValue("@comentario", historico.Comentario);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para eliminar pago
        public void CD_EliminarPago(int ID)
        {
            SqlCommand cmd = new SqlCommand("sp_DelPago", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ID);
            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

       

    }
}
