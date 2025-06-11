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
    public partial class ListadoProcedimientos : Form
    {
        public ListadoProcedimientos()
        {
            InitializeComponent();
        }

        E_Procedimientos objEntidad = new E_Procedimientos();
        N_Procedimientos objNegocio = new N_Procedimientos();

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarProcedimiento();
            dgvProcedimientos.DataSource = dt;
        }
        #endregion

        #region Filtro
        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbcampo.Text != "")
                {
                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Procedimientos where (" + cmbcampo.Text + ") like ('%" + txtbusqueda.Text + "%')";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvProcedimientos.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Eliminar paciente
        private void dgvProcedimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProcedimientos.Rows[e.RowIndex].Cells["Eliminar"].Selected)
                {
                    int eliminar = Convert.ToInt32(dgvProcedimientos.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    DialogResult resultado = MessageBox.Show("Realmente deseas eliminar este procedimiento", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                    objNegocio.CN_EliminarProcedimiento(eliminar);
                    RellenarDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion
        private void ListadoProcedimientos_Load(object sender, EventArgs e)
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

        private void dgvProcedimientos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormMantProcedimientos fmp = new FormMantProcedimientos();

                fmp.txtid.Text = dgvProcedimientos.CurrentRow.Cells["ID"].Value.ToString();
                fmp.txtnombre.Text = dgvProcedimientos.CurrentRow.Cells["Nombre"].Value.ToString();
                fmp.txtDescProce.Text = dgvProcedimientos.CurrentRow.Cells["Descripcion"].Value.ToString();
                fmp.txtcosto.Text = dgvProcedimientos.CurrentRow.Cells["Costo"].Value.ToString();

                fmp.FormClosed += Fmp_FormClosed;

                fmp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fmpedit = sender as Form;
            if (fmpedit.DialogResult == DialogResult.OK)
                RellenarDgv();
        }


        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessReport pr = new ProcessReport();
                pr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            StringBuilder procedimientos = new StringBuilder();
            double total = 0;
            procedimientos.Clear();
            foreach (DataGridViewRow item in dgvProcedimientos.Rows)
            {
                procedimientos.Append(item.Cells["Nombre"].Value);
                procedimientos.Append("----");
            }

            foreach (DataGridViewRow item in dgvProcedimientos.Rows)
            {
                total += Convert.ToDouble(item.Cells["Costo"].Value);
                
            }

            MessageBox.Show(Convert.ToString(procedimientos));
            MessageBox.Show(Convert.ToString(total));
        }
    }
}
