using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_Facturacion
{
    public partial class HistoricoPago : Form
    {

        
        public HistoricoPago()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        E_HistoricoPago objEntidad = new E_HistoricoPago();
        N_HistoricoPago objNegocio = new N_HistoricoPago();

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        public string paciente = "";
        public int idh = 0;


        #region Metodo de rellenar datagrid
        void RellenarDgvN()
        {
            try
            {
                DataTable dt = objNegocio.CN_RellenarHistorico(idh);
                dgvHistorico.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void HistoricoPago_Load(object sender, EventArgs e)
        {
            try
            {
                RellenarDgvN();
                groupBox1.Text = paciente;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbusquedas_KeyUp(object sender, KeyEventArgs e)
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
                    cmd.CommandText = "select Deuda,Abono,Resto,Fecha,Comentario from HistoricoPago where  (" + parametro + ") like ('%" + txtbusquedas.Text + "%') and IdFactura = ("+ idh+")";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvHistorico.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
