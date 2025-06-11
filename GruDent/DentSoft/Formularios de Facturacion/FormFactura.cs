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

namespace DentSoft.Formularios_de_Facturacion
{
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        #region variables para calcular precios factura
            int costo_procedimiento = 0;
            int pago_procedimiento = 0;
            int pendiente_procedimiento = 0;

        #endregion

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

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
           

        }

        private void dgvFactura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


		if (dgvFactura.Columns[e.ColumnIndex].Name == "Estatus")
            {
               
                costo_procedimiento = Convert.ToInt32(dgvFactura.Rows[e.RowIndex].Cells[2].Value);
                pago_procedimiento = Convert.ToInt32(dgvFactura.Rows[e.RowIndex].Cells[3].Value);
                pendiente_procedimiento = costo_procedimiento - pago_procedimiento;
                dgvFactura.Rows[e.RowIndex].Cells[4].Value = pendiente_procedimiento;
		
	         if (pendiente_procedimiento <= 0 )
                {
                    dgvFactura[5, e.RowIndex].Style.ForeColor = Color.White;
                  	dgvFactura[5, e.RowIndex].Style.BackColor = Color.Green;
                    dgvFactura[5, e.RowIndex].Value = "Terminado";


                }
                else
                {
                    dgvFactura[5, e.RowIndex].Style.ForeColor = Color.White;
                    dgvFactura[5, e.RowIndex].Style.BackColor = Color.Red;
                    dgvFactura[5, e.RowIndex].Value = "En proceso";
                
                }


            }

            
        }
    }
}
