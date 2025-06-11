using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaData;
using System.Data;
using System.Data.SqlClient;

namespace CapaData
{
   public class D_PacienteN
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarPacienteN()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectPacienteN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para insertar pacienteN
        public void CD_InsertarPacienteN(E_PacienteN paciente)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertPacienteN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@doc", paciente.Documento);
            cmd.Parameters.AddWithValue("@nom", paciente.Nombres);
            cmd.Parameters.AddWithValue("@papellido", paciente.PrimerApellido);
            cmd.Parameters.AddWithValue("@sapellido", paciente.SegundoApellido);
            cmd.Parameters.AddWithValue("@sexo", paciente.Sexo);
            cmd.Parameters.AddWithValue("@fechanac", paciente.FechaDeNacimiento);
            cmd.Parameters.AddWithValue("@estadoc", paciente.EstadoCivil);
            cmd.Parameters.AddWithValue("@gposanguineo", paciente.GrupoSanguineo);
            cmd.Parameters.AddWithValue("@ars", paciente.ARS);
            cmd.Parameters.AddWithValue("@nss", paciente.NSS);
            cmd.Parameters.AddWithValue("@email", paciente.CorreoElectronico);
            cmd.Parameters.AddWithValue("@telefono", paciente.Telefono);
            cmd.Parameters.AddWithValue("@celular", paciente.Celular);
            cmd.Parameters.AddWithValue("@direccion", paciente.Direccion);
            cmd.Parameters.AddWithValue("@tutorn", paciente.TutorNombre);
            cmd.Parameters.AddWithValue("@tutort", paciente.TutorTelefono);
            cmd.Parameters.AddWithValue("@tutorc", paciente.TutorCedula); ;

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para eliminar paciente
        public void CD_EliminarPacienteN(int ID)
        {
            SqlCommand cmd = new SqlCommand("sp_DelPacienteN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ID);
            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para actualizar paciente
        public void CD_UpdatePacienteN(E_PacienteN paciente)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdatePacienteN", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", paciente.ID);
            cmd.Parameters.AddWithValue("@doc", paciente.Documento);
            cmd.Parameters.AddWithValue("@nom", paciente.Nombres);
            cmd.Parameters.AddWithValue("@papellido", paciente.PrimerApellido);
            cmd.Parameters.AddWithValue("@sapellido", paciente.SegundoApellido);
            cmd.Parameters.AddWithValue("@sexo", paciente.Sexo);
            cmd.Parameters.AddWithValue("@fechanac", paciente.FechaDeNacimiento);
            cmd.Parameters.AddWithValue("@estadoc", paciente.EstadoCivil);
            cmd.Parameters.AddWithValue("@gposanguineo", paciente.GrupoSanguineo);
            cmd.Parameters.AddWithValue("@ars", paciente.ARS);
            cmd.Parameters.AddWithValue("@nss", paciente.NSS);
            cmd.Parameters.AddWithValue("@email", paciente.CorreoElectronico);
            cmd.Parameters.AddWithValue("@telefono", paciente.Telefono);
            cmd.Parameters.AddWithValue("@celular", paciente.Celular);
            cmd.Parameters.AddWithValue("@direccion", paciente.Direccion);
            cmd.Parameters.AddWithValue("@tutorn", paciente.TutorNombre);
            cmd.Parameters.AddWithValue("@tutort", paciente.TutorTelefono);
            cmd.Parameters.AddWithValue("@tutorc", paciente.TutorCedula);
            

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion
    }
}
