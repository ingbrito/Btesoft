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
using DentSoft.Formularios_de_Consulta;

namespace DentSoft.Formularios_de_edicion
{
    public partial class FormMantNinos : Form
    {
        public FormMantNinos()
        {
            InitializeComponent();
        }

        #region Movilidad de barra en formulario 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        #endregion

        E_PacienteN objEntidad = new E_PacienteN();
        N_PacienteN objNegocio = new N_PacienteN();

        #region Limpiar txt

        void LimpiarCampos()
        {
            txtnombre.Clear();
            txtDocumento.Clear();
            txtPapellido.Clear();
            txtSapellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtDireccion.Clear();
            txtNSS.Clear();
            txtNombreT.Clear();
            txtCedulaT.Clear();
            txtTelT.Clear();
            cmbgruposanguineo.SelectedIndex = -1;
            cmbestadocivil.SelectedIndex = -1;
            cmbsexo.SelectedIndex = -1;
            cmbars.SelectedIndex = -1;
        }
        #endregion

        #region Metodo actualizar Paciente
        void Actualizar()
        {
            if (dtpfechanacimiento.Value >= DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no debe ser posterior a la fecha actual: " + DateTime.Now, "Error en la operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objEntidad.ID = Convert.ToInt32(txtid.Text);
                objEntidad.Documento = txtDocumento.Text;
                objEntidad.Nombres = txtnombre.Text;
                objEntidad.PrimerApellido = txtPapellido.Text;
                objEntidad.SegundoApellido = txtSapellido.Text;
                objEntidad.Sexo = cmbsexo.Text;
                objEntidad.FechaDeNacimiento = dtpfechanacimiento.Value;
                objEntidad.EstadoCivil = cmbestadocivil.Text;
                objEntidad.GrupoSanguineo = cmbgruposanguineo.Text;
                objEntidad.ARS = cmbars.Text;
                objEntidad.NSS = txtNSS.Text;
                objEntidad.CorreoElectronico = txtCorreo.Text;
                objEntidad.Telefono = txtTelefono.Text;
                objEntidad.Celular = txtCelular.Text;
                objEntidad.Direccion = txtDireccion.Text;
                objEntidad.TutorNombre = txtNombreT.Text;
                objEntidad.TutorTelefono = txtTelT.Text;
                objEntidad.TutorCedula = txtCedulaT.Text;


                objNegocio.CN_UpdatePacienteN(objEntidad);
                MessageBox.Show("Registro Actualizado Satisfactoriamente", "Transaccion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        #endregion

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateCurrent = DateTime.Now;
                if (dtpfechanacimiento.Value.ToShortDateString() == dateCurrent.ToShortDateString())
                {
                    MessageBox.Show("La fecha de nacimiento debe ser inferior a la fecha actual: " + DateTime.Now, "Error en la operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((txtnombre.Text != "") && (txtPapellido.Text != "") && (txtDireccion.Text != "") &&
                (cmbestadocivil.Text != ""))
                {
                    Actualizar();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              
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
