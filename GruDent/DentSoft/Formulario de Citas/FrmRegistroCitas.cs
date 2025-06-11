using CapaData;
using CapaEntidad;
using CapaNegocio;
using DentSoft.FormInicio;
using DentSoft.Formularios_de_Consulta;
using DentSoft.Formularios_de_seleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formulario_de_Citas
{
    public partial class FrmRegistroCitas : Form
    {

        public FrmRegistroCitas()
        {
            InitializeComponent();
        }

        private int idPaciente = 0;
        private int idDoctor = 1; // Puedes cambiar esto si lo seleccionas dinámicamente
        private int idDoctores = 0;
        private N_Doctores objNegDoctores = new N_Doctores();

        N_CargarCitas objNegocioCita = new N_CargarCitas();
        N_CargarCitas objCargCita = new N_CargarCitas();
        N_Doctores objNegDoctor = new N_Doctores();
        E_CargarCitas objCargarCita = new E_CargarCitas();


        public void SetPaciente(int id, string nombre)
        {
            idPaciente = id;
            lblPaciente.Text = nombre;
        }

        #region Limpiar txt

        private void LimpiarCampos()
        {
            lblPaciente.Text = "";
            txtObservacion.Clear();
            idPaciente = 0;
            // Opcional: limpiar selección de hora, calendario, etc.
        }

        #endregion

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid
        //private void RellenarDgv()
        //{
        //    DataTable dt = objNegocioCita.CN_ObtenerCitas();
        //    dgvCitas.DataSource = dt;
        //}

        //public DataTable CN_ObtenerCitas()
        //{
        //    return objData.CD_ObtenerCitas();
        //}

        #endregion

        private void btnBuscarPacientes_Click(object sender, EventArgs e)
        {

            if (!rdbtnadulto.Checked && !rdbtnninos.Checked)
            {
                MessageBox.Show("Debe seleccionar si es niño o adulto antes de intentar realizar la búsqueda", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmSeleccionarPaciente frm = new FrmSeleccionarPaciente();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cancelar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                FrmMainContent frmp = new FrmMainContent();
                frmp.Show();
            }
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            if (idPaciente == 0)
            {
                MessageBox.Show("Debe seleccionar un paciente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDoctores.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un doctor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idDoctorSeleccionado = Convert.ToInt32(cmbDoctores.SelectedValue);

            DateTime fecha = mCalendario.SelectionStart.Date;
            DateTime hora = dtpHora.Value;

            DateTime fechaHora = new DateTime(
                fecha.Year,
                fecha.Month,
                fecha.Day,
                hora.Hour,
                hora.Minute,
                0
            );

            var nuevaCita = new E_CargarCitas
            {
                IdPaciente = idPaciente,
                IdDoctor = idDoctorSeleccionado,
                Fecha = fechaHora.Date,
                Hora = fechaHora.ToString("HH:mm"), // usamos string como se espera
                Observacion = txtObservacion.Text.Trim(),
                EstadoCita = "Pendiente",
                FechaRegistro = DateTime.Now
            };

            try
            {
                objCargCita.CN_InsertarCita(nuevaCita);
                MessageBox.Show("Cita registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCitas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CargarCitas()
        {
            try
            {
                DataTable dt = objNegocioCita.CN_ObtenerCitas();

                dgvCitas.AutoGenerateColumns = true;
                dgvCitas.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay citas registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dgvCitas.Columns.Contains("NombrePaciente"))
                    dgvCitas.Columns["NombrePaciente"].HeaderText = "Paciente";
                if (dgvCitas.Columns.Contains("NombreDoctor"))
                    dgvCitas.Columns["NombreDoctor"].HeaderText = "Doctor";
                if (dgvCitas.Columns.Contains("Fecha"))
                    dgvCitas.Columns["Fecha"].HeaderText = "Fecha";
                if (dgvCitas.Columns.Contains("Hora"))
                    dgvCitas.Columns["Hora"].HeaderText = "Hora";
                if (dgvCitas.Columns.Contains("Observacion"))
                    dgvCitas.Columns["Observacion"].HeaderText = "Observación";
                if (dgvCitas.Columns.Contains("EstadoCita"))
                    dgvCitas.Columns["EstadoCita"].HeaderText = "Estado";
                if (dgvCitas.Columns.Contains("FechaRegistro"))
                    dgvCitas.Columns["FechaRegistro"].HeaderText = "Registrado el";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmRegistroCitas_Load(object sender, EventArgs e)
        {
            CargarComboDoctores();
            CargarCitas();
        }
        private void CargarComboDoctores()
        {
            List<E_Doctores> doctores = objNegDoctor.CN_ListarDoctores();
            cmbDoctores.DataSource = doctores;
            cmbDoctores.DisplayMember = "NombreCompleto";
            cmbDoctores.ValueMember = "ID";

            if (cmbDoctores.Items.Count > 0)
            {
                cmbDoctores.SelectedIndex = 0; // Selecciona el primero por defecto para evitar errores
            }
        }
        

        
    }
}
