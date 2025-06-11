using CapaEntidad;
using CapaNegocio;
using DentSoft.Formularios_de_edicion;
using DentSoft.Model;
using DentSoft.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_Facturacion.Formularios_de_seleccion
{
    public partial class FListadoFactura : Form
    {
        public FListadoFactura()
        {
            InitializeComponent();
        }

        E_Factura objEntidad = new E_Factura();
        N_Factura objNegocio = new N_Factura();

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarFactura();
            dgvFactura.DataSource = dt;
            deudas();
        }
        #endregion

        #region Metodo para calcular deudas
        private void deudas()
        {
            #region Calculo deuda pendiente
            try
            {
                double deuda = 0;
                foreach (DataGridViewRow item in dgvFactura.Rows)
                {
                    deuda += Convert.ToDouble(item.Cells["Total"].Value);
                }
                CultureInfo DR = CultureInfo.CreateSpecificCulture("es-DO");
                DR.NumberFormat.CurrencySymbol = "RD$";
                lblpendiente.Text = deuda.ToString("C2", DR);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion

            #region Calculo cantidad de facturas pendientes
            try
            {
                int contar = 0;
                foreach (DataGridViewRow item in dgvFactura.Rows)
                {
                    if (item.Cells["Estatus"].Value.ToString().Contains("Pendiente"))
                    {
                        contar = contar + 1;
                    }
                }
                lblcantpendiente.Text = Convert.ToString(contar);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion
        } 
        #endregion

        private void FListadoFactura_Load(object sender, EventArgs e)
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

        #region Filtro
        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (cmbcampo.Text != "")
                {
                    string campo = "";

                    if (cmbcampo.Text == "Paciente")
                    {
                        campo = "NombreCliente";
                    }
                    else if (cmbcampo.Text == "Doctor")
                    {
                        campo = "NombreDoctor";
                    }
                    else if (cmbcampo.Text == "Estatus")
                    {
                        campo = "Estatus";
                    }

                    conexion.Open();
                    SqlCommand cmd = conexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Facturas where (" + campo + ") like ('" + txtbusqueda.Text + "%')";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dgvFactura.DataSource = dt;
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        #endregion

        #region Eliminar factura
        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (dgvFactura.Rows[e.RowIndex].Cells["Eliminar"].Selected)
                {
                    int eliminar = Convert.ToInt32(dgvFactura.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    DialogResult resultado = MessageBox.Show("Realmente deseas eliminar esta factura", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                    objNegocio.CN_EliminarFactura(eliminar);
                    RellenarDgv();

                }

               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        #endregion


        private void dgvFactura_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFactura.Rows[e.RowIndex].Cells["Estatus"].Value.ToString() == "Saldado")
                {
                    MessageBox.Show("No puede efectuar un pago, ya que esta deuda esta saldada", "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Abono fmp = new Abono();

                    fmp.lblpaciente.Text = dgvFactura.CurrentRow.Cells["NombreCliente"].Value.ToString();
                    fmp.lbledad.Text = dgvFactura.CurrentRow.Cells["EdadCliente"].Value.ToString();
                    fmp.lblsexo.Text = dgvFactura.CurrentRow.Cells["SexoCliente"].Value.ToString();
                    fmp.lbldoctor.Text = dgvFactura.CurrentRow.Cells["NombreDoctor"].Value.ToString();
                    fmp.lblespecialidad.Text = dgvFactura.CurrentRow.Cells["EspecialidadDoctor"].Value.ToString();
                    fmp.lblprocesos.Text = dgvFactura.CurrentRow.Cells["Procesos"].Value.ToString();
                    fmp.lblpendiente.Text = dgvFactura.CurrentRow.Cells["Total"].Value.ToString();
                    fmp.idfactura = Convert.ToInt16(dgvFactura.CurrentRow.Cells["ID"].Value.ToString());
                    fmp.pago = Convert.ToDouble(dgvFactura.CurrentRow.Cells["Pago"].Value.ToString());

                    fmp.FormClosed += Fmp_FormClosed;

                    fmp.ShowDialog();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fmp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fmpedit = sender as Form;
            RellenarDgv();
        }

        private void dgvFactura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dgvFactura.Columns[e.ColumnIndex].Name == "Total")
                {
                    if (Convert.ToInt32(e.Value) > 0)
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                }
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }

        #region Generar factura cliente
        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DetalleFactura df = new DetalleFactura();
                df.lblnombre.Text = dgvFactura.CurrentRow.Cells["NombreCliente"].Value.ToString();
                df.lblsexo.Text = dgvFactura.CurrentRow.Cells["SexoCliente"].Value.ToString();
                df.lbledad.Text = dgvFactura.CurrentRow.Cells["EdadCliente"].Value.ToString();
                df.lbldoctor.Text = dgvFactura.CurrentRow.Cells["NombreDoctor"].Value.ToString();
                df.lblstatus.Text = dgvFactura.CurrentRow.Cells["Estatus"].Value.ToString();
                df.lblfecha.Text = Convert.ToDateTime(dgvFactura.CurrentRow.Cells["Fecha"].Value.ToString()).ToString("dd-MM-yyyy");
                df.lblProcedimientos.Text = dgvFactura.CurrentRow.Cells["Procesos"].Value.ToString();
                df.lblcosto.Text = dgvFactura.CurrentRow.Cells["Costo"].Value.ToString();
                df.lblsubtotal.Text = dgvFactura.CurrentRow.Cells["Costo"].Value.ToString();
                df.lblprocesofactura.Text = dgvFactura.CurrentRow.Cells["Costo"].Value.ToString();
                df.lblDescuento.Text = dgvFactura.CurrentRow.Cells["Descuento"].Value.ToString();
                df.lblpagosfactura.Text = dgvFactura.CurrentRow.Cells["Pago"].Value.ToString();
                df.lbldescuentofactura.Text = dgvFactura.CurrentRow.Cells["Descuento"].Value.ToString();
                df.lblPago.Text = dgvFactura.CurrentRow.Cells["Pago"].Value.ToString();
                df.lblDescuento.Text = dgvFactura.CurrentRow.Cells["Descuento"].Value.ToString();
                df.lbltotalfactura.Text = dgvFactura.CurrentRow.Cells["Total"].Value.ToString();
                df.idc = Convert.ToInt32(dgvFactura.CurrentRow.Cells["IdCliente"].Value.ToString());
                df.idf = Convert.ToInt32(dgvFactura.CurrentRow.Cells["ID"].Value.ToString());


                if (dgvFactura.Rows[e.RowIndex].Cells["Factura"].Selected)
                {

                    int id = Convert.ToInt32(dgvFactura.CurrentRow.Cells["IdCliente"].Value.ToString());
                    using (GRUDENTEntities db = new GRUDENTEntities())
                    {

                        var oImage = db.Facturas.Find(id);
                        df.Show();

                    }

                }

                if (dgvFactura.Rows[e.RowIndex].Cells["Historico"].Selected)
                {
                    try
                    {
                        HistoricoPago hp = new HistoricoPago();
                        hp.idh = Convert.ToInt32(dgvFactura.CurrentRow.Cells["ID"].Value.ToString());
                        hp.paciente = dgvFactura.CurrentRow.Cells["NombreCliente"].Value.ToString();
                       
                            hp.Show();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        } 
        #endregion

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
               FacturaReport fr = new FacturaReport();
                fr.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
