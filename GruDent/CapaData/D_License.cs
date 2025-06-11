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
   public class D_License
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para insertar Licencias
        public void CD_InsertarLicencia(E_ProductLicense licencia)
        {
            SqlCommand cmd = new SqlCommand("[sp_InsertLicencia]", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreEmpresa", licencia.NombreEmpresa);
            cmd.Parameters.AddWithValue("@ProductKey", licencia.ProductKey);
            //cmd.Parameters.AddWithValue("@TrialExpiryDate", licencia.TrialExpiryDate);


            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para actualizar Fecha Licencia

        public void CD_UpdateLicencia(E_ProductLicense licencia)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateLicencia", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TrialExpiryDate", DateTime.Now.Date.AddMonths(1));

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}
