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
    public partial class FormMantDoctores : Form
    {
        public FormMantDoctores()
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


        E_Doctores objEntidad = new E_Doctores();
        N_Doctores objNegocio = new N_Doctores();

      

        #region Metodo actualizar Doctores
        void Actualizar()
        {
           
            objEntidad.ID = Convert.ToInt32(txtid.Text);
            objEntidad.Nombres = txtnombre.Text;
            objEntidad.PrimerApellido = txtPapellido.Text;
            objEntidad.SegundoApellido = txtSapellido.Text;
            objEntidad.CorreoElectronico = txtCorreo.Text;
            objEntidad.Especialidad = txtEspecialidad.Text;
            objEntidad.Telefono = txtTelefono.Text;
            objEntidad.Celular = txtCelular.Text;
            objEntidad.Direccion = txtDireccion.Text;


            objNegocio.CN_UpdateDoctores(objEntidad);
            MessageBox.Show("Registro Actualizado Satisfactoriamente", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        #endregion

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                if ((txtnombre.Text != "") && (txtPapellido.Text != "") && (txtDireccion.Text != "") &&
                (txtEspecialidad.Text != "") && (txtSapellido.Text != ""))
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
