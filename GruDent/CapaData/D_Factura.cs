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
    public class D_Factura
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarFactura()
        {
            SqlCommand cmd = new SqlCommand("Sp_SelectFacturas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para insertar factura
        public void CD_InsertarFactura(E_Factura factura)
        {
            SqlCommand cmd = new SqlCommand("Sp_InsertFactura", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcte", factura.IdCliente);
            cmd.Parameters.AddWithValue("@nomcte", factura.NombreCliente);
            cmd.Parameters.AddWithValue("@edad", factura.EdadCliente);
            cmd.Parameters.AddWithValue("@sexo", factura.SexoCliente);
            cmd.Parameters.AddWithValue("@nomdoctor", factura.NombreDoctor);
            cmd.Parameters.AddWithValue("@especialidad", factura.EspecialidadDoctor);
            cmd.Parameters.AddWithValue("@procesos", factura.Procesos);
            cmd.Parameters.AddWithValue("@costo", factura.Costo);
            cmd.Parameters.AddWithValue("@descuento", factura.Descuento);
            cmd.Parameters.AddWithValue("@pago", factura.Pago);
            cmd.Parameters.AddWithValue("@total", factura.Total);
            cmd.Parameters.AddWithValue("@estatus", factura.Estatus);
            cmd.Parameters.AddWithValue("@fecha", factura.Fecha);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para eliminar factura
        public void CD_EliminarFactura(int ID)
        {
            SqlCommand cmd = new SqlCommand("sp_DelFactura", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ID);
            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para actualizar factura

        public void CD_UpdateFactura(E_Factura factura)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateFactura", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", factura.ID);
            cmd.Parameters.AddWithValue("@pago", factura.Pago);
            cmd.Parameters.AddWithValue("@total", factura.Total);
            cmd.Parameters.AddWithValue("@estatus", factura.Estatus);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}
