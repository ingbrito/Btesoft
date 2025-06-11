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
   public class D_Paciente
    {
        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo para rellenar el datagrid
        public DataTable CD_RellenarPaciente()
        {
            SqlCommand cmd = new SqlCommand("sp_SelectPaciente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion

        #region Metodo para insertar paciente
        public void CD_InsertarPaciente(E_Paciente paciente)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertPaciente", conexion);
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

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para eliminar paciente
        public void CD_EliminarPaciente(int ID)
        {
            SqlCommand cmd = new SqlCommand("sp_DelPaciente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", ID);
            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion

        #region Metodo para actualizar paciente
        public void CD_UpdatePaciente(E_Paciente paciente)
        {
            SqlCommand cmd = new SqlCommand("sp_UpdatePaciente", conexion);
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

            if (conexion.State == ConnectionState.Open) conexion.Close();
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        #endregion


    }
}
