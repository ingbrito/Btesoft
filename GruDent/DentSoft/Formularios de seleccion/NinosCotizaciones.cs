using CapaEntidad;
using CapaNegocio;
using DentSoft.Formularios_de_Consulta;
using DentSoft.Formularios_de_Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_seleccion
{
    public partial class NinosCotizaciones : Form
    {
        public NinosCotizaciones()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        E_PacienteN objEntidad = new E_PacienteN();
        N_PacienteN objNegocio = new N_PacienteN();

        #region Conexion a la base de datos

        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion
        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarPacienteN();
            dgvNinosConsulta.DataSource = dt;
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        #region Filtro
        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbcampo.Text != "")
                {
                    string parametro = cmbcampo.Text;

                    if (cmbcampo.Text == "Tutor")
                    {
                        parametro = "TutorNombre";
                    }
                    else
                    {
                        parametro = parametro.Replace(" ", "");
                    }

                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT ID,Documento,Nombres,PrimerApellido,SegundoApellido,Sexo,FechaDeNacimiento,EstadoCivil,GrupoSanguineo,ARS,NSS,CorreoElectronico,Telefono,Celular,Direccion,TutorNombre,TutorTelefono,TutorCedula FROM PacienteN where (" + parametro + ") like ('%" + txtbusqueda.Text + "%')";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvNinosConsulta.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void ListadoNinosConsulta_Load(object sender, EventArgs e)
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

        private void dgvNinosConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvNinosConsulta.AutoGenerateColumns = false;
                Cotizaciones cot = Owner as Cotizaciones;

                cot.idcot = Convert.ToInt32(dgvNinosConsulta.CurrentRow.Cells["ID"].Value.ToString());
                cot.txtNombrePaciente.Text = dgvNinosConsulta.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dgvNinosConsulta.CurrentRow.Cells["PrimerApellido"].Value.ToString() + " " + dgvNinosConsulta.CurrentRow.Cells["SegundoApellido"].Value.ToString();
                cot.txtEmail.Text = dgvNinosConsulta.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                cot.txtTelefono.Text = dgvNinosConsulta.CurrentRow.Cells["Telefono"].Value.ToString();
                Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }

}



