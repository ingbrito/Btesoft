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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDiagConsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FichaConsulta fc = new FichaConsulta();
            //var row = dgvDiagConsulta.CurrentRow;
            //fc.txtDiagnostic.Text = row.Cells[1].Value.ToString();
            //fc.lbDiag.Items.Add(row.Cells[1].Value.ToString());

            //listBox1.DataSource = dataGridView1.CurrentRow.Cells[8].Value.ToString().Split(',').ToList()
            //dataGridView1.CurrentRow.Cells[8].Value.ToString().Split(',').ToList().ForEach(r => listBox1.Items.Add(r.Trim()));

            //fc.lbDiag.DataSource = dgvDiagConsulta.CurrentRow.Cells[1].Value.ToString().Split(',').ToList();
            //dgvDiagConsulta.CurrentRow.Cells[2].Value.ToString().Split(',').ToList().ForEach(r => fc.lbDiag.Items.Add(r.Trim()));
            //fc.lbDiag.SelectedValue = dgvDiagConsulta.CurrentRow.Cells[1].Value.ToString();
            //fc.lbDiag.SelectedItems.Add(dgvDiagConsulta.CurrentRow.Cells[1].Value.ToString());
            fc.lbDiag.Items.Add(dgvDiagConsulta.CurrentRow.Cells[1].Value.ToString());

            fc.Close();
        }

        private void Diagnostic_Load(object sender, EventArgs e)
        {
            RellenarDgv();
        }
    }
}
