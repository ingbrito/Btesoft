using CapaEntidad;
using CapaNegocio;
using DentSoft.Formularios_de_edicion;
using DentSoft.Formularios_de_Facturacion;
using DentSoft.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class ListadoPacientesNinos : Form
    {
        public ListadoPacientesNinos()
        {
            InitializeComponent();
        }

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
            dgvPacienteN.DataSource = dt;
        }
        #endregion

        private void cantidadSex()
        {
            #region Calculo cantidad tipos de sexo
            int contar = 0;
            int count = 0;
            foreach (DataGridViewRow item in dgvPacienteN.Rows)
            {
                if (item.Cells["Sexo"].Value.ToString().Contains("Femenino"))
                {
                    contar = contar + 1;
                }
                
            }
            foreach (DataGridViewRow item in dgvPacienteN.Rows)
            {
                if (item.Cells["Sexo"].Value.ToString().Contains("Masculino"))
                {
                    count = count + 1;
                }

            }


            lblFemenino.Text = Convert.ToString(contar);
            lblMasculino.Text = Convert.ToString(count);

            #endregion
        }
        private void ListadoPacientesNinos_Load(object sender, EventArgs e)
        {
            try
            {
                RellenarDgv();
                cantidadSex();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                    dgvPacienteN.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void dgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvPacienteN.Rows[e.RowIndex].Cells["Historico"].Selected)
                {
                    Historico ht = new Historico();

                    ht.idbn = Convert.ToInt32(dgvPacienteN.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    ht.idbmaster = Convert.ToInt32(dgvPacienteN.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                    ht.ShowDialog();
                }

                if (dgvPacienteN.Rows[e.RowIndex].Cells["Factura"].Selected)
                {
                    CrearFactura fmp = new CrearFactura();

                    #region Edad
                    DateTime nacimiento = Convert.ToDateTime(dgvPacienteN.CurrentRow.Cells["FechaDeNacimiento"].Value.ToString());
                    int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                    #endregion

                    fmp.idpaciente = Convert.ToInt32(dgvPacienteN.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    fmp.lblpaciente.Text = dgvPacienteN.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dgvPacienteN.CurrentRow.Cells["PrimerApellido"].Value.ToString() + " " + dgvPacienteN.CurrentRow.Cells["SegundoApellido"].Value.ToString();
                    fmp.lbledad.Text = Convert.ToString(edad);
                    fmp.lblsexo.Text = dgvPacienteN.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();

                    fmp.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        #region Editar
        private void dgvPaciente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormMantNinos frm = new FormMantNinos();

                frm.txtid.Text = dgvPacienteN.CurrentRow.Cells["ID"].Value.ToString();
                frm.txtDocumento.Text = dgvPacienteN.CurrentRow.Cells["Documento"].Value.ToString();
                frm.txtnombre.Text = dgvPacienteN.CurrentRow.Cells["Nombres"].Value.ToString();
                frm.txtPapellido.Text = dgvPacienteN.CurrentRow.Cells["PrimerApellido"].Value.ToString();
                frm.txtSapellido.Text = dgvPacienteN.CurrentRow.Cells["SegundoApellido"].Value.ToString();
                frm.cmbsexo.Text = dgvPacienteN.CurrentRow.Cells["Sexo"].Value.ToString();
                frm.dtpfechanacimiento.Value = Convert.ToDateTime(dgvPacienteN.CurrentRow.Cells["FechaDeNacimiento"].Value.ToString());
                frm.cmbestadocivil.Text = dgvPacienteN.CurrentRow.Cells["EstadoCivil"].Value.ToString();
                frm.cmbgruposanguineo.Text = dgvPacienteN.CurrentRow.Cells["GrupoSanguineo"].Value.ToString();
                frm.cmbars.Text = dgvPacienteN.CurrentRow.Cells["ARS"].Value.ToString();
                frm.txtNSS.Text = dgvPacienteN.CurrentRow.Cells["NSS"].Value.ToString();
                frm.txtCorreo.Text = dgvPacienteN.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                frm.txtTelefono.Text = dgvPacienteN.CurrentRow.Cells["Telefono"].Value.ToString();
                frm.txtCelular.Text = dgvPacienteN.CurrentRow.Cells["Celular"].Value.ToString();
                frm.txtDireccion.Text = dgvPacienteN.CurrentRow.Cells["Direccion"].Value.ToString();
                frm.txtNombreT.Text = dgvPacienteN.CurrentRow.Cells["TutorNombre"].Value.ToString();
                frm.txtTelT.Text = dgvPacienteN.CurrentRow.Cells["TutorTelefono"].Value.ToString();
                frm.txtCedulaT.Text = dgvPacienteN.CurrentRow.Cells["TutorCedula"].Value.ToString();
                frm.FormClosed += Frm_FormClosed;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if (frm.DialogResult == DialogResult.OK)
            {
                RellenarDgv();
            }
        }

        #endregion

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                ChildrensReport cr = new ChildrensReport();
                cr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPacienteN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPacienteN.Rows[e.RowIndex].Cells["Eliminar"].Selected)
                {
                    int eliminar = Convert.ToInt32(dgvPacienteN.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    DialogResult resultado = MessageBox.Show("Realmente deseas eliminar este paciente", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                    objNegocio.CN_EliminarPacienteN(eliminar);
                    RellenarDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
