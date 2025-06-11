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
    public partial class FormMantConsulta : Form
    {
        public FormMantConsulta()
        {
            InitializeComponent();
        }

        E_Odontograma objEntidad = new E_Odontograma();
        N_Odontograma objNegocio = new N_Odontograma();

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

        #region Metodo actualizar Consulta
        void Actualizar()
        {

            try
            {
                objEntidad.ID = Convert.ToInt32(txtid.Text);
                objEntidad.Motivo = txtmotivo.Text;
                objEntidad.Observaciones = txtobservaciones.Text;
                objEntidad.Indicacion = txtindicaciones.Text;
                objEntidad.Plan_Tratamiento = txtPlanTratamiento.Text;

                objNegocio.CN_UpdateConsulta(objEntidad);
                MessageBox.Show("Registro Actualizado Satisfactoriamente", "Transaccion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtmotivo.Text != "") && (txtobservaciones.Text != ""))
                {
                    Actualizar();
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
