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
    public partial class UcRegProcedimientos : UserControl
    {
        public UcRegProcedimientos()
        {
            InitializeComponent();
        }

        E_Procedimientos objEntidad = new E_Procedimientos();
        N_Procedimientos objNegocio = new N_Procedimientos();

        #region Limpiar txt

        void LimpiarCampos()
        {
            txtNombreProcedimientos.Clear();
            txtDescProcedimientos.Clear();
            txtCostoProcedimiento.Clear();

        }

        #endregion

        #region Metodo Insertar Procedimientos
        void Insertar()
        {

            objEntidad.Nombre = txtNombreProcedimientos.Text;
            objEntidad.Descripcion = txtDescProcedimientos.Text;
            objEntidad.Costo = Convert.ToInt32(txtCostoProcedimiento.Text);


            objNegocio.CN_InsertarProcedimiento(objEntidad);
            MessageBox.Show("Registro Insertado Satisfactoriamente", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }
        #endregion
        private void btnGuardadReg_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNombreProcedimientos.Text != "") && (txtCostoProcedimiento.Text != ""))
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
