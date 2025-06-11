using System;
using CapaEntidad; // Ensure this namespace is correctly referenced
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaData.D_CargarCitas;

namespace CapaData
{
    public class D_CargarCitas
    {
        #region Conexion a la base de datos
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        private DataGridView dgvCitas;

        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarCitas()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectPaciente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion
        public void CD_InsertarCita(E_CargarCitas citas)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Citas (IdPaciente, IdDoctor, Fecha, Hora, Observacion, EstadoCita, FechaRegistro) VALUES (@IdPaciente, @IdDoctor, @Fecha, @Hora, @Observacion, @EstadoCita, @FechaRegistro)", conexion))
                {
                    cmd.Parameters.AddWithValue("@IdPaciente", citas.IdPaciente);
                    cmd.Parameters.AddWithValue("@IdDoctor", citas.IdDoctor);
                    cmd.Parameters.AddWithValue("@Fecha", citas.Fecha);
                    cmd.Parameters.AddWithValue("@Hora", citas.Hora);
                    cmd.Parameters.AddWithValue("@Observacion", citas.Observacion);
                    cmd.Parameters.AddWithValue("@EstadoCita", citas.EstadoCita);
                    cmd.Parameters.AddWithValue("@FechaRegistro", citas.FechaRegistro);

                    if (conexion.State == ConnectionState.Open) conexion.Close();
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la cita: " + ex.Message);
            }
        }

        public DataTable CD_ObtenerCitas()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                        c.IdCita,
                        p.Nombres + ' ' + p.PrimerApellido AS NombrePaciente,
                        d.Nombres + ' ' + d.PrimerApellido AS NombreDoctor,
                        c.Fecha,
                        CONVERT(varchar(5), c.Hora, 108) AS Hora,
                        c.Observacion,
                        c.EstadoCita,
                        c.FechaRegistro
                    FROM Citas c
                    INNER JOIN Paciente p ON c.IdPaciente = p.ID
                    INNER JOIN Doctores d ON c.IdDoctor = d.ID
                    ORDER BY c.Fecha DESC, c.Hora ASC", conexion))
                {
                    if (conexion.State == ConnectionState.Open) conexion.Close();
                    conexion.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las citas: " + ex.Message);
            }

            return dt;
        }

        public DataTable ObtenerCitas()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Citas", conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las citas: " + ex.Message);
            }

            return tabla;
        }
    }
}


