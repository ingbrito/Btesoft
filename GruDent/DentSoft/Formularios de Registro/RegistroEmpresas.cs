using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using DentSoft.Reportes.DetailsFactDataSetTableAdapters;

namespace DentSoft.Formularios_de_Registro
{
    public partial class RegistroEmpresas : Form
    {
        public RegistroEmpresas()
        {
            InitializeComponent();
        }

        E_Empresa objEntidad = new E_Empresa();
        N_Empresa objNegocio = new N_Empresa();
        public int iduser = 0;

        #region Limpiar txt

        void LimpiarCampos()
        {
            txtnombre.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtcorreoelectronico.Clear();
            txtrnc.Clear();
        }

        #endregion

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            DataTable dt = objNegocio.CN_RellenarEmpresa();
            dgvEmpresa.DataSource = dt;
        }
        #endregion

        #region Metodo actualizar Usuario
        void Actualizar()
        {
            objEntidad.ID = iduser;
            objEntidad.Nombre = txtnombre.Text;
            objEntidad.Telefono = txttelefono.Text;
            objEntidad.Direccion = txtdireccion.Text;
            objEntidad.RNC = txtrnc.Text;
            objEntidad.Correo = txtcorreoelectronico.Text;

            objNegocio.CN_UpdateEmpresa(objEntidad);
            MessageBox.Show("Datos Actualizados Satisfactoriamente", "Transacción  exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RellenarDgv();
            LimpiarCampos();
        }
        #endregion

        private void btnGuardadReg_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtnombre.Text != "") && (txtrnc.Text != "") && (txttelefono.Text != "") && (txtdireccion.Text != ""))
                {
                    Actualizar();
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
        #region Actualizar datos empresa en formularios reportes y factura
        //private void ActualizarFact()
        //    {
        //    foreach(DataGridViewRow row in dataGridView1.Rows)
        //    {
        //         );
        //    }

        //}

            #endregion

        private void RegistroEmpresas_Load(object sender, EventArgs e)
        {
            try
            {
                RellenarDgv();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEmpresa_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            iduser = Convert.ToInt16(dgvEmpresa.CurrentRow.Cells["ID"].Value.ToString());
            txtnombre.Text = dgvEmpresa.CurrentRow.Cells["Nombre"].Value.ToString();
            txtdireccion.Text = dgvEmpresa.CurrentRow.Cells["Direccion"].Value.ToString();
            txttelefono.Text = dgvEmpresa.CurrentRow.Cells["Telefono"].Value.ToString();
            txtrnc.Text = dgvEmpresa.CurrentRow.Cells["RNC"].Value.ToString();
            txtcorreoelectronico.Text = dgvEmpresa.CurrentRow.Cells["Correo"].Value.ToString();
        }
    }
}
