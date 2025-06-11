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
    public class D_Empresa
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarEmpresa()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectEmpresa", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para actualizar empresa

        public void CD_UpdateEmpresa(E_Empresa empresa)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateEmpresa", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", empresa.ID);
            cmd.Parameters.AddWithValue("@nombre", empresa.Nombre);
            cmd.Parameters.AddWithValue("@direccion", empresa.Direccion);
            cmd.Parameters.AddWithValue("@telefono", empresa.Telefono);
            cmd.Parameters.AddWithValue("@correo", empresa.Correo);
            cmd.Parameters.AddWithValue("@rnc", empresa.RNC);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}

