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
    public class D_Diagnostico
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarDiagnostico()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectDiagnostico", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para insertar diagnostico
        public void CD_InsertarDiagnostico(E_Diagnostico diagnostico)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertDiagnostico", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", diagnostico.Nombre);
            cmd.Parameters.AddWithValue("@descp", diagnostico.Descripcion);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para eliminar diagnostico
        public void CD_EliminarDiagnostico(int ID)
        {
            SqlCommand cmd = new SqlCommand("sp_DelDiagnostico", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ID);
            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para actualizar diagnostico

        public void CD_UpdateDiagnostico(E_Diagnostico diagnostico)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateDiagnostico", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", diagnostico.ID);
            cmd.Parameters.AddWithValue("@nom", diagnostico.Nombre);
            cmd.Parameters.AddWithValue("@descp", diagnostico.Descripcion);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}
