using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CapaEntidad;
using CapaData;

namespace CapaData
{
  public  class D_Odontograma
    {
        #region Conexion a la base de datos
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para rellenar el datagrid Paciente Consulta
        public DataTable CD_RellenarPacienteConsulta()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectConsulta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para Guardar datos e imagen odontograma
        public void CD_InsertarOdontograma(E_Odontograma odontograma)
        {

            SqlCommand cmd = new SqlCommand("sp_InsertfichaConsult", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", odontograma.Nombre);
            cmd.Parameters.AddWithValue("@edad", odontograma.Edad);
            cmd.Parameters.AddWithValue("@sexo", odontograma.Sexo);
            cmd.Parameters.AddWithValue("@fechaconsulta", odontograma.FechaConsult);
            cmd.Parameters.AddWithValue("@motivo", odontograma.Motivo);
            cmd.Parameters.AddWithValue("@plan_tratamiento", odontograma.Plan_Tratamiento);
            //cmd.Parameters.AddWithValue("@fichaconsulta", odontograma.FichaConsult);
            cmd.Parameters.AddWithValue("@fichaconsulta", string.IsNullOrEmpty(odontograma.FichaConsult) ? "" : odontograma.FichaConsult);
            cmd.Parameters.AddWithValue("@indicacion", odontograma.Indicacion);
            cmd.Parameters.AddWithValue("@process", odontograma.Process);
            cmd.Parameters.AddWithValue("@diagnosti", odontograma.Diagnostic);
            cmd.Parameters.AddWithValue("@imagen_odontograma",odontograma.ImagenOdontograma ?? (object)DBNull.Value);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para actualizar consulta
        public void CD_UpdateConsulta(E_Odontograma odontograma)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateConsulta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", odontograma.ID);
            cmd.Parameters.AddWithValue("@motivo", odontograma.Motivo);
            cmd.Parameters.AddWithValue("@observaciones", odontograma.Observaciones);
            cmd.Parameters.AddWithValue("@indicaciones", odontograma.Indicacion);
            cmd.Parameters.AddWithValue("@plan_tratamiento", odontograma.Plan_Tratamiento);

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region metodo para devolver odontograma 
        public E_Odontograma ObtenerPorPaciente(int idPaciente)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString))
            {
                string query = "SELECT TOP 1 * FROM Odontograma WHERE IdPaciente = @id ORDER BY FechaConsult DESC";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@id", idPaciente);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return new E_Odontograma
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        IdPaciente = Convert.ToInt32(dr["IdPaciente"]),
                        IdDoctor = Convert.ToInt32(dr["IdDoctor"]),
                        Nombre = dr["Nombre"].ToString(),
                        Edad = Convert.ToInt32(dr["Edad"]),
                        ImagenOdontograma = (byte[])dr["ImagenOdontograma"],
                        // Agrega el resto de campos según tu base de datos
                    };
                }
                return null;
            }
        }

        #endregion

    }
}
