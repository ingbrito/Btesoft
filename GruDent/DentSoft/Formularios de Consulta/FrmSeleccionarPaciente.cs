using CapaData;
using CapaEntidad;
using CapaNegocio;
using DentSoft.Formulario_de_Citas;
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

namespace DentSoft.Formularios_de_Consulta
{
    public partial class FrmSeleccionarPaciente : Form
    {
        public FrmSeleccionarPaciente()
        {
            InitializeComponent();
        }

        E_Paciente objEntidad = new E_Paciente();
        N_Paciente objNegocio = new N_Paciente();

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarPaciente();
            dgvPacienteSelect .DataSource = dt;
        }
        #endregion
        private void FrmSeleccionarPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPacientes(); // <-- ESTE SÍ FUNCIONA
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CargarPacientes()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                string query = "SELECT ID, Documento, Nombres, PrimerApellido, SegundoApellido, Sexo, FechaDeNacimiento FROM Paciente";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MessageBox.Show("Filas recuperadas: " + dt.Rows.Count); // Verificación

                dgvPacienteSelect.AutoGenerateColumns = true; // Importante si no defines columnas manualmente
                dgvPacienteSelect.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message);
            }
        }

        private void dgvPacienteSelect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvPacienteSelect.Rows[e.RowIndex].Cells["Nombres"].Value == null)
                {
                    MessageBox.Show("The selected row contains null values.");
                }
                else
                {
                    int id = Convert.ToInt32(dgvPacienteSelect.Rows[e.RowIndex].Cells["ID"].Value);
                    string nombre = dgvPacienteSelect.Rows[e.RowIndex].Cells["Nombres"].Value.ToString()
                                  + " " + dgvPacienteSelect.Rows[e.RowIndex].Cells["PrimerApellido"].Value.ToString() + " "
                                  + dgvPacienteSelect.Rows[e.RowIndex].Cells["SegundoApellido"].Value.ToString() + " "
                                  + dgvPacienteSelect.Rows[e.RowIndex].Cells["Sexo"].Value.ToString() + " "
                                  + dgvPacienteSelect.Rows[e.RowIndex].Cells["FechaDeNacimiento"].Value.ToString();

                    if (this.Owner is FrmRegistroCitas frmRegistro)
                    {
                        frmRegistro.SetPaciente(id, nombre);
                    }

                    this.Close();
                }
            }
        }
    }
}
