using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DentSoft.Formularios_de_Consulta;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using CapaNegocio;
using DentSoft.Formularios_de_Consulta;
using DentSoft.Formularios_de_Facturacion;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class FSProcedimientos : Form
    {
        public FSProcedimientos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid

        E_Procedimientos objEntidad = new E_Procedimientos();
        N_Procedimientos objNegocio = new N_Procedimientos();

        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarProcedimiento();
            dgvProceConsulta.DataSource = dt;

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
                    cmd.CommandText = "SELECT * FROM Procedimientos where (" + cmbcampo.Text + ") like ('" + txtbusqueda.Text + "%')";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvProceConsulta.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProceConsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CrearFactura fc = Owner as CrearFactura;
                fc.lblproceso.Text = dgvProceConsulta.CurrentRow.Cells["Nombre"].Value.ToString();
                fc.lblcosto.Text = dgvProceConsulta.CurrentRow.Cells["Costo"].Value.ToString();

                Close();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }

        private void Procedimiento_Load(object sender, EventArgs e)
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
    }
}
