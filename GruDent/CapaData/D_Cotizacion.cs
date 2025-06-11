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
   public class D_Cotizacion
    {

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para insertar Cotizaciones
        public void CD_InsertarCotizacion(E_Cotizacion cotizacion)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertCotizacion", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numeroCotizacion", cotizacion.numeroCotizacion);
            cmd.Parameters.AddWithValue("@nombrePaciente", cotizacion.nombrePaciente);
            cmd.Parameters.AddWithValue("@correo", cotizacion.correo);
            cmd.Parameters.AddWithValue("@telefono", cotizacion.telefono);
            cmd.Parameters.AddWithValue("@fecha", cotizacion.Fecha);
            cmd.Parameters.AddWithValue("@condicion", cotizacion.condicion);
            cmd.Parameters.AddWithValue("@descripcion", cotizacion.descripcion);
            cmd.Parameters.AddWithValue("@cantidad", cotizacion.cantidad);
            cmd.Parameters.AddWithValue("@precio", cotizacion.precio);
            cmd.Parameters.AddWithValue("@subtotal", cotizacion.subtotal);
            cmd.Parameters.AddWithValue("@descuento", cotizacion.descuento);
            cmd.Parameters.AddWithValue("@total", cotizacion.total);


            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}
