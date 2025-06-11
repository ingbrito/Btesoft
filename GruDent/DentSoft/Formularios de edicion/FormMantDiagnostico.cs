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
    public partial class FormMantDiagnostico : Form
    {
        public FormMantDiagnostico()
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

        E_Diagnostico objEntidad = new E_Diagnostico();
        N_Diagnostico objNegocio = new N_Diagnostico();

        #region Limpiar txt

        void LimpiarCampos()
        {
            txtnombre.Clear();
            txtDescDiagnostico.Clear();
        }

        #endregion

        #region Metodo actualizar diagnostico
        void Actualizar()
        {
            objEntidad.ID = Convert.ToInt32(txtid.Text);
            objEntidad.Nombre = txtnombre.Text;
            objEntidad.Descripcion = txtDescDiagnostico.Text;


            objNegocio.CN_UpdateDiagnostico(objEntidad);
            MessageBox.Show("Registro Actualizado Satisfactoriamente", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnombre.Text != "") && (txtDescDiagnostico.Text != ""))
                {
                    Actualizar();

                }
                else
                {
                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
