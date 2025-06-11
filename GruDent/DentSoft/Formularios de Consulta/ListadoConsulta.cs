using CapaEntidad;
using CapaNegocio;
using DentSoft.Formularios_de_edicion;
using DentSoft.Formularios_de_Facturacion;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class ListadoConsulta : Form
    {
        public ListadoConsulta()
        {
            InitializeComponent();
        }

        E_Odontograma objEntidad = new E_Odontograma();
        N_Odontograma objNegocio = new N_Odontograma();

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarPacienteConsulta();
            dgvPacienteConsulta.DataSource = dt;
        }
        #endregion


        private void ListadoConsulta_Load(object sender, EventArgs e)
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
                    cmd.CommandText = "SELECT ID,NombrePaciente,Edad,Sexo,Fecha,NombreDoctor,Motivo,Plan_Tratamiento,Observaciones,Diagnostico,Procedimiento,Indicaciones FROM Consulta where (" + parametro + ") like ('%" + txtbusqueda.Text + "%')";
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

        private void dgvPacienteConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DetalleConsulta fco = new DetalleConsulta();
                fco.lblnombre.Text = dgvPacienteConsulta.CurrentRow.Cells["NombrePaciente"].Value.ToString();
                fco.lbledad.Text = dgvPacienteConsulta.CurrentRow.Cells["Edad"].Value.ToString();
                fco.lblsexo.Text = dgvPacienteConsulta.CurrentRow.Cells["Sexo"].Value.ToString();
                fco.lblfecha.Text = Convert.ToDateTime(dgvPacienteConsulta.CurrentRow.Cells["Fecha"].Value.ToString()).ToString("dd-MM-yyyy");
                fco.lbldoctor.Text = dgvPacienteConsulta.CurrentRow.Cells["NombreDoctor"].Value.ToString();
                fco.lblmotivo.Text = dgvPacienteConsulta.CurrentRow.Cells["Motivo"].Value.ToString();
                fco.lblobservacion.Text = dgvPacienteConsulta.CurrentRow.Cells["Observaciones"].Value.ToString();
                fco.lbldiagnostico.Text = dgvPacienteConsulta.CurrentRow.Cells["Diagnostico"].Value.ToString();
                fco.lblprocedimiento.Text = dgvPacienteConsulta.CurrentRow.Cells["Procedimiento"].Value.ToString();
                fco.lblindicacion.Text = dgvPacienteConsulta.CurrentRow.Cells["Indicaciones"].Value.ToString();


                try
                {
                    if (dgvPacienteConsulta.Rows[e.RowIndex].Cells["Ficha"].Selected)
                    {

                        int id = Convert.ToInt16(dgvPacienteConsulta.CurrentRow.Cells["ID"].Value.ToString());
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
                catch (Exception ex )
                {

                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPacienteConsulta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormMantConsulta  fmc = new FormMantConsulta();

                fmc.lblPaciente.Text = dgvPacienteConsulta.CurrentRow.Cells["NombrePaciente"].Value.ToString();
                fmc.txtid.Text = dgvPacienteConsulta.CurrentRow.Cells["ID"].Value.ToString();
                fmc.txtmotivo.Text = dgvPacienteConsulta.CurrentRow.Cells["Motivo"].Value.ToString();
                fmc.txtobservaciones.Text = dgvPacienteConsulta.CurrentRow.Cells["Observaciones"].Value.ToString();
                fmc.txtindicaciones.Text = dgvPacienteConsulta.CurrentRow.Cells["Indicaciones"].Value.ToString();
                fmc.txtPlanTratamiento.Text = dgvPacienteConsulta.CurrentRow.Cells["Plan_Tratamiento"].Value.ToString();

                fmc.FormClosed += Frm_FormClosed;

                if (dgvPacienteConsulta.Rows[e.RowIndex].Cells["Actualizar"].Selected)
                    {

                        int id = Convert.ToInt16(dgvPacienteConsulta.CurrentRow.Cells["ID"].Value.ToString());
                        using (GRUDENTEntities db = new GRUDENTEntities())
                        {

                            var oImage = db.Consulta.Find(id);

                            MemoryStream ms = new MemoryStream(oImage.Foto);
                            Bitmap bmp = new Bitmap(ms);

                            fmc.pbDentagrama.Image = bmp;
                            fmc.ShowDialog();

                        }

                    }
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
    }
}

