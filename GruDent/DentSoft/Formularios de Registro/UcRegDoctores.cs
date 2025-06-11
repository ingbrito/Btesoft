using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_Registro
{
    public partial class UcRegDoctores : UserControl
    {
        public UcRegDoctores()
        {
            InitializeComponent();
        }

        E_Doctores objEntidad = new E_Doctores();
        N_Doctores objNegocio = new N_Doctores();

        #region Limpiar campos

        void LimpiarCampos()
        {
            txtnombre.Clear();
            txtpapellido.Clear();
            txtsapellido.Clear();
            txtcelular.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtcorreoelectronico.Clear();
            txtEspecialidad.Clear();
        }

        #endregion

        #region Metodo Insertar Doctores
        void Insertar()
        {

            objEntidad.Nombres = txtnombre.Text;
            objEntidad.PrimerApellido = txtpapellido.Text;
            objEntidad.SegundoApellido = txtsapellido.Text;
            objEntidad.CorreoElectronico = txtcorreoelectronico.Text;
            objEntidad.Telefono = txttelefono.Text;
            objEntidad.Celular = txtcelular.Text;
            objEntidad.Direccion = txtdireccion.Text;
            objEntidad.Especialidad = txtEspecialidad.Text;


            objNegocio.CN_InsertarDoctores(objEntidad);
            MessageBox.Show("Registro Insertado Satisfactoriamente", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }
        #endregion
        private void btnGuardadReg_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnombre.Text != "") && (txtpapellido.Text != "") && (txtdireccion.Text != "") &&
                     (txtEspecialidad.Text != ""))
                {
                    Insertar();
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
