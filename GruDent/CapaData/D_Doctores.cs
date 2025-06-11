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
    public class D_Doctores
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarDoctor()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectDoctores", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para insertar doctor
        public void CD_InsertarDoctor(E_Doctores doctor)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertDoctores", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", doctor.Nombres);
            cmd.Parameters.AddWithValue("@papellido", doctor.PrimerApellido);
            cmd.Parameters.AddWithValue("@sapellido", doctor.SegundoApellido);
            cmd.Parameters.AddWithValue("@email", doctor.CorreoElectronico);
            cmd.Parameters.AddWithValue("@esp", doctor.Especialidad);
            cmd.Parameters.AddWithValue("@tel", doctor.Telefono);
            cmd.Parameters.AddWithValue("@cel", doctor.Celular);
            cmd.Parameters.AddWithValue("@dir", doctor.Direccion);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para eliminar doctor
        public void CD_EliminarDoctor(int ID)
        {
            SqlCommand cmd = new SqlCommand("sp_DelDoctores", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ID);
            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
        #region Metodo para actualizar doctores

        public void CD_UpdateDoctores(E_Doctores doctores)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateDoctores", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", doctores.ID);
            cmd.Parameters.AddWithValue("@nom", doctores.Nombres);
            cmd.Parameters.AddWithValue("@papellido", doctores.PrimerApellido);
            cmd.Parameters.AddWithValue("@sapellido", doctores.SegundoApellido);
            cmd.Parameters.AddWithValue("@email", doctores.CorreoElectronico);
            cmd.Parameters.AddWithValue("@esp", doctores.Especialidad);
            cmd.Parameters.AddWithValue("@tel", doctores.Telefono);
            cmd.Parameters.AddWithValue("@cel", doctores.Celular);
            cmd.Parameters.AddWithValue("@dir", doctores.Direccion);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

    public List<E_Doctores> CD_ListarDoctores()
        {
            List<E_Doctores> lista = new List<E_Doctores>();

            SqlCommand cmd = new SqlCommand("sp_SelectDoctores", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new E_Doctores
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Nombres = dr["Nombres"].ToString(),
                    PrimerApellido = dr["PrimerApellido"].ToString()
                });
            }

            conexion.Close();
            return lista;
        }

    }
}
