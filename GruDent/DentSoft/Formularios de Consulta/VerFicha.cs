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
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class VerFicha : Form
    {



        Consulta model = new Consulta();
        E_HistoricoPago objEntidad = new E_HistoricoPago();
        N_HistoricoPago objNegocio = new N_HistoricoPago();

        E_Paciente objEntidadd = new E_Paciente();
        N_Paciente objNegocioo = new N_Paciente();
        public int idb = 0;
        public int idbn = 0;

        public VerFicha()
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Metodo de rellenar datagrid consulta adultos
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarHistoricoConsulta(idb);
            dgvHistorico.DataSource = dt;
        }
        #endregion
        #region Metodo de rellenar datagrid consulta ninos
        void RellenarDgvN()
        {
            DataTable dt = objNegocio.CN_RellenarHistoricoConsulta(idbn);
            dgvHistorico.DataSource = dt;
        }
        #endregion
        #region Metodo de rellenar datagrid pacientes 
        void RellenarDg()
        {
            DataTable dt = objNegocioo.CN_RellenarPaciente();
            dgvHistorico.DataSource = dt;
        }
        #endregion

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void VerFicha_Load(object sender, EventArgs e)
        {
            try
            {
                if (idb > 0)
                {
                    RellenarDg();
                }
                else
                {
                    RellenarDgvN();
                }

                RellenarDg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DetalleConsulta fco = new DetalleConsulta();
                //fco.lblnombre.Text = dgvHistorico.CurrentRow.Cells["NombrePaciente"].Value.ToString();
                //fco.lbledad.Text = dgvHistorico.CurrentRow.Cells["Edad"].Value.ToString();
                //fco.lblsexo.Text = dgvHistorico.CurrentRow.Cells["Sexo"].Value.ToString();
                  lblfecha.Text = Convert.ToDateTime(dgvHistorico.CurrentRow.Cells["Fecha"].Value.ToString()).ToString("dd-MM-yyyy");
                //fco.lbldoctor.Text = dgvHistorico.CurrentRow.Cells["NombreDoctor"].Value.ToString();
               // fco.lblmotivo.Text = dgvHistorico.CurrentRow.Cells["Motivo"].Value.ToString();
                 lblobservacion.Text = dgvHistorico.CurrentRow.Cells["Observaciones"].Value.ToString();
                 lbldiagnostico.Text = dgvHistorico.CurrentRow.Cells["Diagnostico"].Value.ToString();
                 lblprocedimiento.Text = dgvHistorico.CurrentRow.Cells["Procedimiento"].Value.ToString();
               // fco.lblindicacion.Text = dgvHistorico.CurrentRow.Cells["Indicaciones"].Value.ToString();


                if (dgvHistorico.Rows[e.RowIndex].Cells["Ficha"].Selected)
                {

                    int id = Convert.ToInt16(dgvHistorico.CurrentRow.Cells["ID"].Value.ToString());
                    using (GRUDENTEntities db = new GRUDENTEntities())
                    {

                        var oImage = db.Consulta.Find(id);

                        MemoryStream ms = new MemoryStream(oImage.Foto);
                        Bitmap bmp = new Bitmap(ms);

                        pbficha.Image = bmp;
                        

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }
    }
}