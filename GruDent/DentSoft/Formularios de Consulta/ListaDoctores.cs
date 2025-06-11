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
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
using CapaNegocio;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class ListaDoctores : Form
    {
        public ListaDoctores()
        {
            InitializeComponent();
        }

        E_Doctores objEntidad = new E_Doctores();
        N_Doctores objNegocio = new N_Doctores();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void ListaDoctores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPrincipal.sp_SelectDoctores' table. You can move, or remove it, as needed.
            //this.sp_SelectDoctoresTableAdapter.Fill(this.dataSetPrincipal.sp_SelectDoctores);
            RellenarDgv();
        }

        private void dgvDoctores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FichaConsulta fc = Owner as FichaConsulta;
            fc.idd = Convert.ToInt32( dgvDoctores.CurrentRow.Cells[0].Value.ToString());
            fc.txtNombreDoctor.Text = dgvDoctores.CurrentRow.Cells[1].Value.ToString();
            
            Close();
        }
    }
}
