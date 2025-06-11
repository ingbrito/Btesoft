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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProceConsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FichaConsulta fc = new FichaConsulta();
            fc.lbProce.Text = dgvProceConsulta.CurrentRow.Cells[1].Value.ToString();
        }

        private void Procedimiento_Load(object sender, EventArgs e)
        {
            RellenarDgv();
        }
    }
}
