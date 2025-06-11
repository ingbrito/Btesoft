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
using CapaData;
using CapaNegocio;
using CapaEntidad;

namespace DentSoft.Formularios_de_edicion
{
    public partial class FormMantProcedimientos : Form
    {
        public FormMantProcedimientos()
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

        E_Procedimientos objEntidad = new E_Procedimientos();
        N_Procedimientos objNegocio = new N_Procedimientos();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Metodo actualizar procedimiento
        void Actualizar()
        {
            objEntidad.ID = Convert.ToInt32(txtid.Text);
            objEntidad.Nombre = txtnombre.Text;
            objEntidad.Descripcion = txtDescProce.Text;
            objEntidad.Costo = Convert.ToDouble( txtcosto.Text);


            objNegocio.CN_UpdateProcedimiento(objEntidad);
            MessageBox.Show("Registro Actualizado Satisfactoriamente", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnombre.Text != "") && (txtDescProce.Text != "") && (txtcosto.Text != ""))
                {
                    Actualizar();

                }
                else
                {
                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
