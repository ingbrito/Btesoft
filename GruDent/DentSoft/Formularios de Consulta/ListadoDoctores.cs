using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using System.Configuration;
using DentSoft.Formularios_de_edicion;
using DentSoft.Reportes;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class ListadoDoctores : Form
    {
        public ListadoDoctores()
        {
            InitializeComponent();
        }

        E_Doctores objEntidad = new E_Doctores();
        N_Doctores objNegocio = new N_Doctores();

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarDoctores();
            dgvDoctores.DataSource = dt;
        }
        #endregion

        private void ListadoDoctores_Load(object sender, EventArgs e)
        {
            try
            {
                RellenarDgv();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #region Filtro
        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbcampo.Text != "")
                {
                    string parametro = cmbcampo.Text;
                    parametro = parametro.Replace(" ", "");

                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Doctores where (" + parametro + ") like ('%" + txtbusqueda.Text + "%')";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvDoctores.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        } 
        #endregion
        #region Eliminar Doctore
        private void dgvDoctores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgvDoctores.Rows[e.RowIndex].Cells["Eliminar"].Selected)
                {
                    int eliminar = Convert.ToInt32(dgvDoctores.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    DialogResult resultado = MessageBox.Show("Realmente deseas eliminar este paciente", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                    objNegocio.CN_EliminarDoctor(eliminar);
                    RellenarDgv();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion

        private void dgvDoctores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                FormMantDoctores fmDo = new FormMantDoctores();

                fmDo.txtid.Text = dgvDoctores.CurrentRow.Cells["ID"].Value.ToString();
                fmDo.txtnombre.Text = dgvDoctores.CurrentRow.Cells["Nombres"].Value.ToString();
                fmDo.txtPapellido.Text = dgvDoctores.CurrentRow.Cells["PrimerApellido"].Value.ToString();
                fmDo.txtSapellido.Text = dgvDoctores.CurrentRow.Cells["SegundoApellido"].Value.ToString();
                fmDo.txtCorreo.Text = dgvDoctores.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                fmDo.txtEspecialidad.Text = dgvDoctores.CurrentRow.Cells["Especialidad"].Value.ToString();
                fmDo.txtTelefono.Text = dgvDoctores.CurrentRow.Cells["Telefono"].Value.ToString();
                fmDo.txtCelular.Text = dgvDoctores.CurrentRow.Cells["Celular"].Value.ToString();
                fmDo.txtDireccion.Text = dgvDoctores.CurrentRow.Cells["Direccion"].Value.ToString();
                fmDo.FormClosed += FmDo_FormClosed;

                fmDo.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FmDo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
            {
                RellenarDgv();
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                DoctorReport mr = new DoctorReport();
                mr.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
