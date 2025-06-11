using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaData
{
    public class D_Procedimiento
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarProcedimiento()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectProcedimientos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para insertar procedimiento
        public void CD_InsertarProcedimiento(E_Procedimientos procedimiento)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertProcedimientos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", procedimiento.Nombre);
            cmd.Parameters.AddWithValue("@descp", procedimiento.Descripcion);
            cmd.Parameters.AddWithValue("@costo", procedimiento.Costo);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para eliminar procedimiento
        public void CD_EliminarProcedimiento(int ID)
        {
            SqlCommand cmd = new SqlCommand("sp_DelProcedimientos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ID);
            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para actualizar procedimiento

        public void CD_UpdateProcedimiento(E_Procedimientos procedimiento)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateProcedimientos", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", procedimiento.ID);
            cmd.Parameters.AddWithValue("@nom", procedimiento.Nombre);
            cmd.Parameters.AddWithValue("@descp", procedimiento.Descripcion);
            cmd.Parameters.AddWithValue("@costo", procedimiento.Costo);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}
