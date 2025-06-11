using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using CapaEntidad;
using CapaNegocio;
using System.Configuration;
using DentSoft.Formularios_de_edicion;
using DentSoft.Formularios_de_Consulta;
using System.IO;
using DentSoft.Formularios_de_Facturacion;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class ListadoPacienteConsulta : Form
    {
        public ListadoPacienteConsulta()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        E_Paciente objEntidad = new E_Paciente();
        N_Paciente objNegocio = new N_Paciente();

        #region Conexion a la base de datos

        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarPaciente();
            dgvPacienteConsulta.DataSource = dt;
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
                    parametro = parametro.Replace(" ", "");

                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT ID,Documento,Nombres,PrimerApellido,SegundoApellido,Sexo,FechaDeNacimiento,EstadoCivil,GrupoSanguineo,ARS,NSS,CorreoElectronico,Telefono,Celular,Direccion FROM Paciente where (" + parametro + ") like ('%" + txtbusqueda.Text + "%')";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvPacienteConsulta.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void ListadoPacienteConsulta_Load(object sender, EventArgs e)
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

        #region mostrar datos en form consulta paciente   
        private void dgvPacienteConsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvPacienteConsulta.AutoGenerateColumns = false;
                // metodo para hacer que un form sea dueno y mostrar datos desde otro 
                FichaConsulta fc = Owner as FichaConsulta;
               


                #region Edad
                DateTime nacimiento = Convert.ToDateTime(dgvPacienteConsulta.CurrentRow.Cells[6].Value.ToString());
                int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                #endregion

                fc.idp = Convert.ToInt32(dgvPacienteConsulta.CurrentRow.Cells[0].Value.ToString());
                fc.lblpaciente.Text = dgvPacienteConsulta.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dgvPacienteConsulta.CurrentRow.Cells["PrimerApellido"].Value.ToString() + " " + dgvPacienteConsulta.CurrentRow.Cells["SegundoApellido"].Value.ToString();
                fc.lblsexo.Text = dgvPacienteConsulta.CurrentRow.Cells[5].Value.ToString();
                fc.lbledad.Text = Convert.ToString(edad);

                if (dgvPacienteConsulta.Rows.Count > 0)
                {
                    int id = int.Parse(dgvPacienteConsulta.Rows[dgvPacienteConsulta.CurrentRow.Index].Cells[0].Value.ToString());
                    using (Model.GRUDENTEntities db = new Model.GRUDENTEntities())
                    {
                        var oImage = db.Paciente.Find(id);

                        MemoryStream ms = new MemoryStream(oImage.Foto);
                        Bitmap bmp = new Bitmap(ms);

                        fc.drawpaint.Image = bmp;
                        fc.Show();
                    }
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Metodo para abrir ListadoPacienteConsulta desde FichaConsulta
        public static void AbrirListadoPacienteConsulta(FichaConsulta fichaConsulta)
        {
            var listadoPacienteConsulta = new ListadoPacienteConsulta();
            listadoPacienteConsulta.Owner = fichaConsulta;
            listadoPacienteConsulta.Show();
        }
        #endregion
    }
}
