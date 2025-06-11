using DentSoft.Formularios_de_Facturacion;
using CapaNegocio;
using DentSoft.Formularios_de_Consulta;
using DentSoft.Formularios_de_seleccion;
using DentSoft.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_Facturacion
{
    public partial class Cotizaciones : Form
    {
        public Cotizaciones()
        {
            InitializeComponent();
        }


        //E_Cotizacion objEntidad = new E_Cotizacion();
        N_Cotizacion objNegocio = new N_Cotizacion();
        public int idcot = 0;

        #region Limpiar txt



        #endregion

        #region metodo para crear numeros aleatorios para facturas y cotizaciones 
        //private void auto()
        //{
        //    lblCotizacion.Text = "GD-" + GetUniqueKey(8);

        //}
        //public static string GetUniqueKey(int maxSize)
        //{
        //    char[] chars = new char[62];
        //    chars = "123456789".ToCharArray();
        //    byte[] data = new byte[1];
        //    RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
        //    crypto.GetNonZeroBytes(data);
        //    data = new byte[maxSize];
        //    crypto.GetNonZeroBytes(data);
        //    StringBuilder result = new StringBuilder(maxSize);
        //    foreach (byte b in data)
        //    {
        //        result.Append(chars[b % (chars.Length)]);
        //    }
        //    return result.ToString();
        //} 
        #endregion

        #region Boton buscar pacientes
        private void btnPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtnadulto.Checked)
                {
                    PacienteCotizaciones lp = new PacienteCotizaciones();
                    AddOwnedForm(lp);
                    lp.ShowDialog();
                }
                else if (rdbtnninos.Checked)
                {
                    NinosCotizaciones ln = new NinosCotizaciones();
                    AddOwnedForm(ln);
                    ln.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar si es niño o adulto antes de intentar realizar la búsqueda", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Buscar procedimientos
        private void btnProcedimientos_Click(object sender, EventArgs e)
        {
            try
            {
                FSCotizaciones listproce = new FSCotizaciones();
                AddOwnedForm(listproce);
                listproce.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Metodo limpiar campos
        private void limpiar()
        {
            lblproceso.Text = "";
            lblcosto.Text = "";
            lblsubtotal.Text = "";
            txtdescuento.Text = "0";
            txtcantidad.Clear();
            txtdescuento.Focus();
        }
        #endregion

        #region Limpiar campos factura

        private void limpiarlblfactura()
        {
            lblprocesofactura.Text = "00";
            lbldescuentofactura.Text = "00";
            lbltotalfactura.Text = "00";
        }
        #endregion

        #region Calcular costos y cantidad procedimientos
        private void txtdescuento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblcosto.Text != "" && txtcantidad.Text != "")
                {
                    decimal costo = Convert.ToDecimal(lblcosto.Text);
                    decimal descuento = Convert.ToDecimal(txtdescuento.Text);
                    decimal cantidad = Convert.ToDecimal(txtcantidad.Text);
                    lblsubtotal.Text = Convert.ToString(cantidad * costo - descuento);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Metodo para agregar datos al datagridview
        private void agregar()
        {
            try
            {
                if (txtNombrePaciente.Text != "")
                {
                    int labelsubtotal = Convert.ToInt16(lblsubtotal.Text);
                    int lblcostto = Convert.ToInt16(lblcosto.Text);
                    int lbldescuentto = Convert.ToInt16(txtdescuento.Text);
                    // int lblpago = Convert.ToInt16(txtpago.Text);
                    dgvCotizaciones.Rows.Add(lblproceso.Text,txtcantidad.Text, lblcostto, lbldescuentto, labelsubtotal);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un paciente", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Boton agregar datos al datagridview
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int labelsubtotal = Convert.ToInt16(lblsubtotal.Text);
                if (labelsubtotal < 0)
                {
                    MessageBox.Show("El subtotal no puede ser negativo", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtdescuento.Text == "" && txtcantidad.Text == "" || txtcantidad.Text == "")
                {
                    MessageBox.Show("Debe ingresar algun valor en la casilla cantidad", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int lblcostto = Convert.ToInt16(lblcosto.Text);
                    int lblcantidad = Convert.ToInt16(txtcantidad.Text);

                    if (lblcostto >= 0 && lblcantidad > 0)
                    {
                        agregar();
                        limpiarlblfactura();
                    }

                    else
                    {
                        MessageBox.Show("Debe agregar el costo y pago del procedimiento", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                double subtotal = 0;
                double costo = 0;
                double descuento = 0;
                double cantidad = 0;
                foreach (DataGridViewRow item in dgvCotizaciones.Rows)
                {
                    costo += Convert.ToDouble(item.Cells["Costo"].Value);
                }
                foreach (DataGridViewRow item in dgvCotizaciones.Rows)
                {
                    subtotal += Convert.ToDouble(item.Cells["STotal"].Value);
                }
                foreach (DataGridViewRow item in dgvCotizaciones.Rows)
                {
                    cantidad += Convert.ToDouble(item.Cells["Cantidad"].Value);
                }
                foreach (DataGridViewRow item in dgvCotizaciones.Rows)
                {
                    descuento += Convert.ToDouble(item.Cells["Descuento"].Value);
                }

                lblprocesofactura.Text = Convert.ToString(subtotal);
                lbldescuentofactura.Text = Convert.ToString(descuento);
                lbltotalfactura.Text = Convert.ToString(subtotal);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion


        private void generarcotizacion()
        {
            Cotization cotizacion = new Cotization();
            // E_Cotizacion cotizacion = new E_Cotizacion();
            FormCotizacion fcoti = new FormCotizacion(); 

            cotizacion.nombrePaciente = txtNombrePaciente.Text;
            cotizacion.correo = txtEmail.Text;
            cotizacion.telefono = txtTelefono.Text;

            for (int i = 0; i < dgvCotizaciones.Rows.Count-1; i++)
            {
                cotizacion.descripcion = dgvCotizaciones.Rows[i].Cells[0].Value.ToString();
                cotizacion.cantidad = Convert.ToInt32(dgvCotizaciones.Rows[i].Cells[1].Value);
                cotizacion.precio = Convert.ToInt32(dgvCotizaciones.Rows[i].Cells[2].Value);
                cotizacion.descuento = Convert.ToInt32(dgvCotizaciones.Rows[i].Cells[3].Value);
                cotizacion.total = Convert.ToInt32(dgvCotizaciones.Rows[i].Cells[4].Value);

                fcoti.cotizacion.Add(cotizacion);
            }
            fcoti.Show();

            //foreach (DataGridViewRow  row in dgvCotizaciones.Rows)
            //{
            //    cotizacion.descripcion = dgvCotizaciones.Rows[0].Cells["Descripcion"].Value.ToString();
            //    cotizacion.cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
            //    cotizacion.precio = Convert.ToInt32(row.Cells["Costo"].Value);
            //    cotizacion.descuento = Convert.ToInt32(row.Cells["Descuento"].Value);
            //    cotizacion.total = Convert.ToInt32(row.Cells["STotal"].Value);

            //    fcoti.cotizacion.Add(cotizacion);

            //}



        }
        #region Boton Imprimir cotizacion
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                generarcotizacion();

                         
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
