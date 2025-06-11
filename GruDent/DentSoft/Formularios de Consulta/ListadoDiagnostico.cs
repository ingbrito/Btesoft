using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using System.Configuration;
using System.Data.SqlClient;
using DentSoft.Formularios_de_edicion;
using DentSoft.Reportes;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class ListadoDiagnostico : Form
    {
        public ListadoDiagnostico()
        {
            InitializeComponent();
        }

        E_Diagnostico objEntidad = new E_Diagnostico();
        N_Diagnostico objNegocio = new N_Diagnostico();

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarDiagnostico();
            dgvDiagnostico.DataSource = dt;
        }
        #endregion


        private void ListadoDiagnostico_Load(object sender, EventArgs e)
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

        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbcampo.Text != "")
                {
                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Diagnostico where (" + cmbcampo.Text + ") like ('%" + txtbusqueda.Text + "%')";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvDiagnostico.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Eliminar paciente
        private void dgvDiagnostico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            try
            {
                if (dgvDiagnostico.Rows[e.RowIndex].Cells["Eliminar"].Selected)
                {
                    int eliminar = Convert.ToInt32(dgvDiagnostico.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    DialogResult resultado = MessageBox.Show("Realmente deseas eliminar este procedimiento", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                    objNegocio.CN_EliminarDiagnostico(eliminar);
                    RellenarDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void dgvDiagnostico_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormMantDiagnostico fmd = new FormMantDiagnostico();

                fmd.txtid.Text = dgvDiagnostico.CurrentRow.Cells["ID"].Value.ToString();
                fmd.txtnombre.Text = dgvDiagnostico.CurrentRow.Cells["Nombre"].Value.ToString();
                fmd.txtDescDiagnostico.Text = dgvDiagnostico.CurrentRow.Cells["Descripcion"].Value.ToString();
                fmd.FormClosed += Fmd_FormClosed;

                fmd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fmd_FormClosed(object sender, FormClosedEventArgs e)
        {
           Form fmpedit = sender as Form;
            if (fmpedit.DialogResult == DialogResult.OK)
                RellenarDgv();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                DiagnosticReport dr = new DiagnosticReport();
                dr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

