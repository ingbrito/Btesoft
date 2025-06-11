using CapaEntidad;
using CapaNegocio;
using DentSoft.Formularios_de_Consulta;
using DentSoft.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentSoft.Formularios_de_Registro;

namespace DentSoft.Formularios_de_Facturacion
{
    public partial class CrearFactura : Form
    {
        public CrearFactura()
        {
            InitializeComponent();
        }

        E_Factura objEntidad = new E_Factura();
        N_Factura objNegocio = new N_Factura();

        public int idpaciente = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                FSDoctores listdoct = new FSDoctores();
                AddOwnedForm(listdoct);
                listdoct.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FSProcedimientos listproce = new FSProcedimientos();
                AddOwnedForm(listproce);
                listproce.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CrearFactura_Load(object sender, EventArgs e)
        {
            try
            {
                if (lblproceso.Text == "")
                {
                    txtpago.Enabled = false;
                    txtdescuento.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void lblcosto_TextChanged(object sender, EventArgs e)
        {
            lblsubtotal.Text = lblcosto.Text;
        }

        private void txtdescuento_TextChanged(object sender, EventArgs e)
        {
            //if (lblcosto.Text != "" && txtpago.Text != "")
            //{
            //    decimal costo = Convert.ToDecimal(lblcosto.Text);
            //    decimal descuento = Convert.ToDecimal(txtdescuento.Text);
            //    decimal pago = Convert.ToDecimal(txtpago.Text);
            //    lblsubtotal.Text = Convert.ToString(costo - descuento - pago);
            //}
        }

        private void limpiar()
        {
            lblproceso.Text = "";
            lblcosto.Text = "0";
            txtpago.Text = "0";
            txtdescuento.Text = "0";
            txtpago.Focus();
        }

        #region Metodo para agregar procedimientos y costos al datagrid
        private void agregar()
        {
            try
            {
                if (lbldoctor.Text != "")
                {
                    int labelsubtotal = Convert.ToInt32(lblsubtotal.Text);
                    int lblcostto = Convert.ToInt32(lblcosto.Text);
                    if (txtdescuento.Text == "")
                    {
                        txtdescuento.Text = 0.ToString();
                    }
                    int lbldescuentto = Convert.ToInt32(txtdescuento.Text);
                    int lblpago = Convert.ToInt32(txtpago.Text);
                    dgvfactura.Rows.Add(lblproceso.Text, lblcostto, lbldescuentto, lblpago, labelsubtotal);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un doctor", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        } 
        #endregion

        #region metodo para agregar los procedimientos y costos a datagrid

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int labelsubtotal = Convert.ToInt32(lblsubtotal.Text);
            if (labelsubtotal < 0)
            {
                MessageBox.Show("El subtotal no puede ser negativo", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtdescuento.Text == "" && txtpago.Text == "" || txtpago.Text == "")
            {
                MessageBox.Show("Debe ingresar algun valor en la casilla pago", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int lblcostto = Convert.ToInt32(lblcosto.Text);
                int lblpago = Convert.ToInt32(txtpago.Text);

                if (lblcostto >= 0 && lblpago > 0)
                {
                    agregar();
                }

                else
                {
                    MessageBox.Show("Debe agregar el costo y pago del procedimiento", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            double subtotal = 0;
            double costo = 0;
            double descuento = 0;
            double pagos = 0;
            foreach (DataGridViewRow item in dgvfactura.Rows)
            {
                costo += Convert.ToDouble(item.Cells["Costo"].Value);
            }
            foreach (DataGridViewRow item in dgvfactura.Rows)
            {
                subtotal += Convert.ToDouble(item.Cells["STotal"].Value);
            }
            foreach (DataGridViewRow item in dgvfactura.Rows)
            {
                pagos += Convert.ToDouble(item.Cells["Pago"].Value);
            }
            foreach (DataGridViewRow item in dgvfactura.Rows)
            {
                descuento += Convert.ToDouble(item.Cells["Descuento"].Value);
            }

            lblprocesofactura.Text = Convert.ToString(costo);
            lbldescuentofactura.Text = Convert.ToString(descuento);
            lblpagosfactura.Text = Convert.ToString(pagos);
            lbltotalfactura.Text = Convert.ToString(subtotal);
            if (lblproceso.Text == "")
            {
                txtdescuento.Enabled = false;
                txtpago.Enabled = false;
            }

        } 
        #endregion

        #region metodo para cambio en campo calcular descuento y pago 
        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            double costo = 0;
            double descuento = 0;
            double pago = 0;

            if (lblcosto.Text == "")
            {
                costo = 0;
            }
            else if (Convert.ToDouble(lblcosto.Text) > 0)
            {
                costo = Convert.ToDouble(lblcosto.Text);
            }


            if (txtdescuento.Text == "")
            {
                descuento = 0;
            }
            else if (Convert.ToDouble(txtdescuento.Text) > 0)
            {
                descuento = Convert.ToDouble(txtdescuento.Text);
            }


            if (txtpago.Text == "")
            {
                pago = 0;
            }
            else if (Convert.ToDouble(txtpago.Text) > 0)
            {
                pago = Convert.ToDouble(txtpago.Text);
            }

            lblsubtotal.Text = Convert.ToString(costo - descuento - pago);

            //if (lblcosto.Text != "" && txtpago.Text != "")
            //{
            //    double costo = Convert.ToDouble(lblcosto.Text);
            //    double descuento = Convert.ToDouble(txtdescuento.Text);
            //    double pago = Convert.ToDouble(txtpago.Text);
            //    lblsubtotal.Text = Convert.ToString(costo - descuento - pago);
            //}
        } 
        #endregion

        #region Metodo Insertar Paciente
        void Insertar()
        {
            StringBuilder procedimientos = new StringBuilder();
            procedimientos.Clear();

            foreach (DataGridViewRow item in dgvfactura.Rows)
            {
                procedimientos.Append(item.Cells["Proceso"].Value);
                procedimientos.Append("---");
            }

            string estatus = "";

            if (Convert.ToDouble(lbltotalfactura.Text) > 0)
            {
                estatus = "Pendiente";
              
            }
            else if (Convert.ToDouble(lbltotalfactura.Text) == 0)
            {
                estatus = "Saldado";
            }

            objEntidad.IdCliente = idpaciente;
            objEntidad.NombreCliente = lblpaciente.Text;
            objEntidad.EdadCliente = Convert.ToInt16( lbledad.Text);
            objEntidad.SexoCliente = lblsexo.Text;
            objEntidad.NombreDoctor = lbldoctor.Text;
            objEntidad.EspecialidadDoctor = lblespecialidad.Text;
            objEntidad.Procesos = Convert.ToString( procedimientos);
            objEntidad.Costo = Convert.ToDouble( lblprocesofactura.Text);
            objEntidad.Descuento =Convert.ToDouble( lbldescuentofactura.Text );
            objEntidad.Pago = Convert.ToDouble(lblpagosfactura.Text) ;
            objEntidad.Estatus = estatus;
            objEntidad.Total = Convert.ToDouble( lbltotalfactura.Text);
            objEntidad.Fecha = DateTime.Now;

            objNegocio.CN_InsertarFactura(objEntidad);
            MessageBox.Show("Registro Insertado Satisfactoriamente", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Limpiar Campos Facturas
        private void limpiarlblfactura()
        {
            lblprocesofactura.Text = "00";
            lbldescuentofactura.Text = "00";
            lblpagosfactura.Text = "00";
            lblsubtotal.Text = "00";
            lbltotalfactura.Text = "00";
        }
        #endregion

        #region Boton para guardar factura
        private void btnGuardarReg__Click(object sender, EventArgs e)
        {
            try
            {
                if (lbldoctor.Text == "")
                {
                    MessageBox.Show("Por favor seleccione el doctor", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dgvfactura.Rows.Count == 0)
                    {
                        MessageBox.Show("Debe ingresar almenos un procedimiento", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Insertar();
                        limpiarlblfactura();
                        Close();
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region metodo para habilitar e inhabilitar campos pago y descuento
        private void lblproceso_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (lblproceso.Text == "")
                {
                    txtpago.Enabled = false;
                    txtdescuento.Enabled = false;
                }
                txtpago.Enabled = true;
                txtdescuento.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Boton para eliminar procedimientos de datagrid
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Realmente deseas eliminar este procedimiento", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                dgvfactura.Rows.RemoveAt(dgvfactura.CurrentRow.Index);
                double subtotal = 0;
                double costo = 0;
                double descuento = 0;
                double pagos = 0;
                foreach (DataGridViewRow item in dgvfactura.Rows)
                {
                    costo += Convert.ToDouble(item.Cells["Costo"].Value);
                }
                foreach (DataGridViewRow item in dgvfactura.Rows)
                {
                    subtotal += Convert.ToDouble(item.Cells["STotal"].Value);
                }
                foreach (DataGridViewRow item in dgvfactura.Rows)
                {
                    pagos += Convert.ToDouble(item.Cells["Pago"].Value);
                }
                foreach (DataGridViewRow item in dgvfactura.Rows)
                {
                    descuento += Convert.ToDouble(item.Cells["Descuento"].Value);
                }

                lblprocesofactura.Text = Convert.ToString(costo);
                lbldescuentofactura.Text = Convert.ToString(descuento);
                lblpagosfactura.Text = Convert.ToString(pagos);
                lbltotalfactura.Text = Convert.ToString(subtotal);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un procedimiento a eliminar", "Transaccion erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
    #endregion
}
