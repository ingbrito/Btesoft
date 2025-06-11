using CapaEntidad;
using CapaNegocio;
using DentSoft.Model;
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

namespace DentSoft.Formularios_de_Consulta
{
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        E_HistoricoPago objEntidad = new E_HistoricoPago();
        N_HistoricoPago objNegocio = new N_HistoricoPago();

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        #endregion


        #region Movilidad de barra en formulario 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        #endregion
        public int idb = 0;
        public int idbn = 0;
        public int idbmaster = 0;
        
        private void Historico_Load(object sender, EventArgs e)
        {
            try
            {
                if (idb > 0)
                {
                    RellenarDgv();
                }
                else
                {
                    RellenarDgvN();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarHistoricoConsulta(idb);
            dgvHistorico.DataSource = dt;
        }
        #endregion
        #region Metodo de rellenar datagrid
        void RellenarDgvN()
        {
            DataTable dt = objNegocio.CN_RellenarHistoricoConsulta(idbn);
            dgvHistorico.DataSource = dt;
        }
        #endregion


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DetalleConsultaH fco = new DetalleConsultaH();
                fco.lblname.Text = dgvHistorico.CurrentRow.Cells["NombrePaciente"].Value.ToString();
                fco.lblfecha.Text = Convert.ToDateTime(dgvHistorico.CurrentRow.Cells["Fecha"].Value.ToString()).ToString("dd-MM-yyyy");
                fco.lbldoctor.Text = dgvHistorico.CurrentRow.Cells["NombreDoctor"].Value.ToString();
                fco.lblmotivo.Text = dgvHistorico.CurrentRow.Cells["Motivo"].Value.ToString();
                fco.lblobservacion.Text = dgvHistorico.CurrentRow.Cells["Observaciones"].Value.ToString();
                fco.lbldiagnostico.Text = dgvHistorico.CurrentRow.Cells["Diagnostico"].Value.ToString();
                fco.lblprocedimiento.Text = dgvHistorico.CurrentRow.Cells["Procedimiento"].Value.ToString();
                fco.lblindicacion.Text = dgvHistorico.CurrentRow.Cells["Indicaciones"].Value.ToString();


                if (dgvHistorico.Rows[e.RowIndex].Cells["Ficha"].Selected)
                {

                    int id = Convert.ToInt16( dgvHistorico.CurrentRow.Cells["ID"].Value.ToString()) ;
                    using (GRUDENTEntities db = new GRUDENTEntities())
                    {

                        var oImage = db.Consulta.Find(id);

                        MemoryStream ms = new MemoryStream(oImage.Foto);
                        Bitmap bmp = new Bitmap(ms);

                        fco.pbDentagrama.Image = bmp;
                        fco.Show();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbusquedas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbcampos.Text != "")
                {
                    string parametro = cmbcampos.Text;
                    parametro = parametro.Replace(" ", "");

                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT ID,NombrePaciente,NombreDoctor,Motivo,Diagnostico,Procedimiento,Observaciones,Indicaciones,Fecha FROM Consulta where (" + parametro + ") like ('%" + txtbusquedas.Text + "%') and IdPaciente = ("+ idbmaster +")";
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
    }
}






