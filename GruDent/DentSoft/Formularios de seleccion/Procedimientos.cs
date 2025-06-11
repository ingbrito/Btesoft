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
    public partial class Procedimiento : Form
    {
        public Procedimiento()
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

        #region Limpiar txt

        void LimpiarCampos()
        {
            txtNombreProce.Clear();
            txtDescripcion.Clear();
            mkbCosto.Clear();

        }

        #endregion

        #region Metodo Insertar Procedimientos
        void Insertar()
        {


            objEntidad.Nombre = txtNombreProce.Text;
            objEntidad.Descripcion = txtDescripcion.Text;
            objEntidad.Costo = Convert.ToInt32(mkbCosto.Text);


            objNegocio.CN_InsertarProcedimiento(objEntidad);
            MessageBox.Show("Registro Insertado Satisfactoriamente", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }
        #endregion
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
            FichaConsulta fc = Owner as FichaConsulta;
            fc.lbProc.Items.Add(dgvProceConsulta.CurrentRow.Cells[1].Value.ToString());
            fc.Show();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNombreProce.Text != "") && (mkbCosto.Text != ""))
                {
                    Insertar();
                    RellenarDgv();
                }
                else
                {
                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdbtProcess_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (rdbtProcess.Checked)
                {
                    txtNombreProce.Visible = true;
                    mkbCosto.Visible = true;
                    txtDescripcion.Visible = true;
                    lblNombre.Visible = true;
                    lblCosto.Visible = true;
                    lblDesc.Visible = true;
                    btnAgregar.Visible = true;
                    dgvProceConsulta.Location = new Point(23, 174);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
