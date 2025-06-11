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

using CapaEntidad;
using CapaNegocio;
using System.Configuration;
using DentSoft.Formularios_de_edicion;
using DentSoft.Reportes;
using DentSoft.Formularios_de_Facturacion;

namespace DentSoft.Formularios_de_Consulta
{


    public partial class ListadoPaciente : Form
    {
        public ListadoPaciente()
        {
            InitializeComponent();
        }

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
            dgvPaciente.DataSource = dt;
        }
        #endregion


        private void cantidadSex()
        {
            #region Calculo cantidad tipos de sexo
            int contar = 0;
            int count = 0;
            foreach (DataGridViewRow item in dgvPaciente.Rows)
            {
                if (item.Cells["Sexo"].Value.ToString().Contains("Femenino"))
                {
                    contar = contar + 1;
                }
            }

            foreach (DataGridViewRow item in dgvPaciente.Rows)
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
        private void ListadoPacientes_Load(object sender, EventArgs e)
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
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbcampo.Text != "")
                {
                    string parametro = cmbcampo.Text;
                    parametro = parametro.Replace(" ","");

                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT ID,Documento,Nombres,PrimerApellido,SegundoApellido,Sexo,FechaDeNacimiento,EstadoCivil,GrupoSanguineo,ARS,NSS,CorreoElectronico,Telefono,Celular,Direccion FROM Paciente where (" + parametro + ") like ('%" + txtbusqueda.Text + "%')";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvPaciente.DataSource = dt;
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
            
                if (dgvPaciente.Rows[e.RowIndex].Cells["Factura"].Selected)
                {
                    CrearFactura fmp = new CrearFactura();

                    #region Edad
                    DateTime nacimiento = Convert.ToDateTime(dgvPaciente.CurrentRow.Cells["FechaDeNacimiento"].Value.ToString());
                    int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                    #endregion

                    fmp.idpaciente = Convert.ToInt32(dgvPaciente.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    fmp.lblpaciente.Text = dgvPaciente.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dgvPaciente.CurrentRow.Cells["PrimerApellido"].Value.ToString() + " " + dgvPaciente.CurrentRow.Cells["SegundoApellido"].Value.ToString();
                    fmp.lbledad.Text = Convert.ToString( edad);
                    fmp.lblsexo.Text = dgvPaciente.Rows[e.RowIndex].Cells["Sexo"].Value.ToString();

                    fmp.ShowDialog();
                }

                if (dgvPaciente.Rows[e.RowIndex].Cells["Historico"].Selected)
                {
                    Historico ht = new Historico();

                   ht.idb = Convert.ToInt32(dgvPaciente.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                   ht.idbmaster = Convert.ToInt32(dgvPaciente.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                    ht.ShowDialog();
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
                FormMantPacientes frm = new FormMantPacientes();

                frm.txtid.Text = dgvPaciente.CurrentRow.Cells["ID"].Value.ToString();
                frm.txtDocumento.Text = dgvPaciente.CurrentRow.Cells["Documento"].Value.ToString();
                frm.txtnombre.Text = dgvPaciente.CurrentRow.Cells["Nombres"].Value.ToString();
                frm.txtPapellido.Text = dgvPaciente.CurrentRow.Cells["PrimerApellido"].Value.ToString();
                frm.txtSapellido.Text = dgvPaciente.CurrentRow.Cells["SegundoApellido"].Value.ToString();
                frm.cmbsexo.Text = dgvPaciente.CurrentRow.Cells["Sexo"].Value.ToString();
                frm.dtpfechanacimiento.Value = Convert.ToDateTime(dgvPaciente.CurrentRow.Cells["FechaDeNacimiento"].Value.ToString());
                frm.cmbestadocivil.Text = dgvPaciente.CurrentRow.Cells["EstadoCivil"].Value.ToString();
                frm.cmbgruposanguineo.Text = dgvPaciente.CurrentRow.Cells["GrupoSanguineo"].Value.ToString();
                frm.cmbars.Text = dgvPaciente.CurrentRow.Cells["ARS"].Value.ToString();
                frm.txtNSS.Text = dgvPaciente.CurrentRow.Cells["NSS"].Value.ToString();
                frm.txtCorreo.Text = dgvPaciente.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                frm.txtTelefono.Text = dgvPaciente.CurrentRow.Cells["Telefono"].Value.ToString();
                frm.txtCelular.Text = dgvPaciente.CurrentRow.Cells["Celular"].Value.ToString();
                frm.txtDireccion.Text = dgvPaciente.CurrentRow.Cells["Direccion"].Value.ToString();

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
            if(frm.DialogResult == DialogResult.OK)
            {
                RellenarDgv();
            }
        }

        #endregion

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                PatientReport pr = new PatientReport();
                pr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPaciente.Rows[e.RowIndex].Cells["Eliminar"].Selected)
                {
                    int eliminar = Convert.ToInt32(dgvPaciente.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    DialogResult resultado = MessageBox.Show("Realmente deseas eliminar este paciente", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                    objNegocio.CN_EliminarPaciente(eliminar);
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
