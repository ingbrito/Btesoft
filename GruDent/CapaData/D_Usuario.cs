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
   public class D_Usuario
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion


        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarUsuario()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
        #endregion

        #region Metodo para insertar Usuario
        public void CD_InsertarUsuario(E_Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@loginName", usuario.LoginName);
            cmd.Parameters.AddWithValue("@password", usuario.Password);
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@IdRol", usuario.IdRol);
            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para eliminar usuario
        public void CD_EliminarUsuario(int ID)
        {
            SqlCommand cmd = new SqlCommand("sp_DelUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ID);
            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para actualizar Usuario
        public void CD_UpdateUsuario(E_Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateUsuario", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", usuario.Id);
            cmd.Parameters.AddWithValue("@loginName", usuario.LoginName);
            cmd.Parameters.AddWithValue("@password", usuario.Password);
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
            cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
           cmd.Parameters.AddWithValue("IdRol", usuario.IdRol);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}
