using CapaEntidad;
using CapaNegocio;
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

namespace DentSoft.Formularios_de_edicion
{
    public partial class Abono : Form
    {
        public Abono()
        {
            InitializeComponent();
        }

        #region Movilidad de barra en formulario 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }


        #endregion

        E_HistoricoPago objEntidad = new E_HistoricoPago();
        N_HistoricoPago objNegocio = new N_HistoricoPago();

        E_Factura objEntidadF = new E_Factura();
        N_Factura objNegocioF = new N_Factura();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int idfactura = 0;
        public double pago = 0;

        #region Metodo Insertar Pago
        void Insertar()
        {
            double pendiente = Convert.ToDouble(lblpendiente.Text);
            double abono = Convert.ToInt32(txtabono.Text);
            double resto = pendiente-abono;

            objEntidad.IdFactura = idfactura;
            objEntidad.Deuda = pendiente;
            objEntidad.Abono = abono ;
            objEntidad.Resto = resto;
            objEntidad.Fecha = DateTime.Now;
            objEntidad.Comentario = txtcomentario.Text;


            objNegocio.CN_InsertarPago(objEntidad);
            MessageBox.Show("Pago efectuado satisfactoriamente", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region actualizar datagrid al realizar abono y/o saldo de factura
        void Actualizar()
        {
            double pendiente = Convert.ToDouble(lblpendiente.Text);
            double abono = Convert.ToInt32(txtabono.Text);
            double resto = pendiente - abono;

            string estatus = "";

            objEntidadF.ID = idfactura;
            objEntidadF.Pago = pago + abono;
            objEntidadF.Total = resto;
            if (resto > 0)
            {
                estatus = "Pendiente";
            }
            else if (resto == 0)
            {
                estatus = "Saldado";
            }
            objEntidadF.Estatus = estatus;

            objNegocioF.CN_UpdateFactura(objEntidadF);
        }
        #endregion

        #region Metodo para guardar abono y/o saldo de facturas
        private void btnGuardarReg__Click(object sender, EventArgs e)
        {
            try
            {
                if (txtabono.Text != "")
                {
                    double pendiente = Convert.ToDouble(lblpendiente.Text);
                    double abono = Convert.ToInt32(txtabono.Text);
                    double resultado = pendiente - abono;

                    if (resultado < 0)
                    {
                        MessageBox.Show("No puede efectuar un pago mayor a la deuda", "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Insertar();
                        Actualizar();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar una cantidad", "Error en la operación ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtabono.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    } 
    #endregion
}
