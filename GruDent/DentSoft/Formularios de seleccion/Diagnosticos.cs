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

namespace DentSoft.Formularios_de_Consulta
{
    public partial class Diagnostic : Form
    {
        public Diagnostic()
        {
            InitializeComponent();
        }

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        #region Metodo de rellenar datagrid

        E_Diagnostico objEnditad = new E_Diagnostico();
        N_Diagnostico objNegocio = new N_Diagnostico();

        void RellenarDgv()
        {
            DataTable dtd = objNegocio.CN_RellenarDiagnostico();
            dgvDiagConsulta.DataSource = dtd;
           
        }
        #endregion

        #region Limpiar txt

        void LimpiarCampos()
        {
            txtNombreProce.Clear();
            txtDescripcion.Clear();

        }

        #endregion

        #region Metodo Insertar Diagnostico
        void Insertar()
        {
            objEnditad.Nombre = txtNombreProce.Text;
            objEnditad.Descripcion = txtDescripcion.Text;

            objNegocio.CN_InsertarDiagnostico(objEnditad);
            MessageBox.Show("Registro Insertado Satisfactoriamente", "Transacción  exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

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
                    cmd.CommandText = "SELECT * FROM Diagnostico where (" + cmbcampo.Text + ") like ('" + txtbusqueda.Text + "%')";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvDiagConsulta.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void dgvDiagConsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FichaConsulta fc = Owner as FichaConsulta;
                fc.lbDiag.Items.Add(dgvDiagConsulta.CurrentRow.Cells[1].Value.ToString());
                fc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Diagnostic_Load(object sender, EventArgs e)
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
                if ((txtNombreProce.Text != "") && (txtDescripcion.Text != ""))
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

        private void rdbtDiagnost_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbtDiagnost.Checked)
                {
                    txtNombreProce.Visible = true;
                    txtDescripcion.Visible = true;
                    lblNombre.Visible = true;
                    lblDesc.Visible = true;
                    btnAgregar.Visible = true;
                    dgvDiagConsulta.Location = new Point(23, 174);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
