using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaData;
using CapaNegocio;
using CapaEntidad;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class Diagnostico : Form
    {
        public Diagnostico()
        {
            InitializeComponent();
        }

        E_Diagnostico objEntidad = new E_Diagnostico();
        N_Diagnostico objNegocio = new N_Diagnostico();

        #region Limpiar txt

        void LimpiarCampos()
        {
            txtDescDiagnostico.Clear();
            txtNombreDiagnostico.Clear();
        }

        #endregion

        #region Metodo Insertar Diagnostico
        void Insertar()
        {
            objEntidad.Nombre = txtNombreDiagnostico.Text;
            objEntidad.Descripcion = txtDescDiagnostico.Text;

            objNegocio.CN_InsertarDiagnostico(objEntidad);
            MessageBox.Show("Registro Insertado Satisfactoriamente", "Transacción  exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }
        #endregion

        #region Validar Campos ErrorProvider
        private bool ValidarCampos()
        {
            bool validar = true;
            if (txtNombreDiagnostico.Text != null)
            {
                validar = false;
                
            }
            if (txtDescDiagnostico.Text != null)

            {
                validar = false;
               
            }

            return validar;
        }
        #endregion

       
        private void btnGuardadReg_Click(object sender, EventArgs e)
        {
            try
            {
              
                if ((txtNombreDiagnostico.Text != "") && (txtDescDiagnostico.Text != ""))
                {
                    Insertar();
                }
                else
                {
                    ValidarCampos();
                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
