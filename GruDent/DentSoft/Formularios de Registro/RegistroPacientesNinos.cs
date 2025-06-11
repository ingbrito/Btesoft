using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_Registro
{
    public partial class RegistroPacientesNinos : Form
    {
        public RegistroPacientesNinos()
        {
            InitializeComponent();
        }
        E_PacienteN objEntidad = new E_PacienteN();
        N_PacienteN objNegocio = new N_PacienteN();
        #region Limpiar txt

        #region limpiar Campos
        void LimpiarCampos()
        {
            txtnombre.Clear();
            txtcedula.Clear();
            txtpapellido.Clear();
            txtsapellido.Clear();
            txtcorreoelectronico.Clear();
            txttelefono.Clear();
            txtcelular.Clear();
            txtdireccion.Clear();
            txtnss.Clear();
            cmbgruposanguineo.SelectedIndex = -1;
            cmbestadocivil.SelectedIndex = -1;
            cmbsexo.SelectedIndex = -1;
            cmbars.SelectedIndex = -1;
            txtnombretutor.Clear();
            mtbCedulaTutor.Clear();
            mtbTelTutor.Clear();
        }
        #endregion
        #endregion
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                opdImagen.InitialDirectory = "C:\\Odontogramas";
                opdImagen.Filter = "Archivos jpg(*.jpg)|*.jpg|Archivos png(*.png)|*.png";
                opdImagen.FilterIndex = 1;
                opdImagen.RestoreDirectory = true;
                if (opdImagen.ShowDialog() == DialogResult.OK)
                {
                    txtruta.Text = opdImagen.FileName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public string fn;
        public string edad;
        private void dtpfechanacimiento_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime fn = dtpfechanacimiento.Value;
                DateTime edad = DateTime.Now;
                TimeSpan tspan = edad - fn;
                double dias = tspan.TotalDays;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void agregarnino()
        {
            try
            {
                if (dtpfechanacimiento.Value >= DateTime.Now)
                {
                    MessageBox.Show("La fecha de nacimiento no debe ser posterior a la fecha actual: " + DateTime.Now, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    byte[] file = null;
                    Stream mystream = opdImagen.OpenFile();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        mystream.CopyTo(ms);
                        file = ms.ToArray();
                    }
                    using (Model.GRUDENTEntities db = new Model.GRUDENTEntities())
                    {

                        Model.PacienteN oImage = new Model.PacienteN();
                        oImage.Documento = txtcedula.Text.Trim();
                        oImage.Nombres = txtnombre.Text.Trim();
                        oImage.PrimerApellido = txtpapellido.Text.Trim();
                        oImage.SegundoApellido = txtsapellido.Text.Trim();
                        oImage.Sexo = cmbsexo.Text.Trim();
                        oImage.FechaDeNacimiento = Convert.ToDateTime(dtpfechanacimiento.Value);
                        oImage.EstadoCivil = cmbestadocivil.Text.Trim();
                        oImage.GrupoSanguineo = cmbgruposanguineo.Text.Trim();
                        oImage.ARS = cmbars.Text.Trim();
                        oImage.NSS = txtnss.Text.Trim();
                        oImage.CorreoElectronico = txtcorreoelectronico.Text.Trim();
                        oImage.Telefono = txttelefono.Text.Trim();
                        oImage.Celular = txtcelular.Text.Trim();
                        oImage.Direccion = txtdireccion.Text.Trim();
                        oImage.TutorNombre = txtnombretutor.Text.Trim();
                        oImage.TutorTelefono = mtbTelTutor.Text.Trim();
                        oImage.TutorCedula = mtbCedulaTutor.Text.Trim();

                        oImage.Foto = file;

                        db.PacienteN.Add(oImage);
                        db.SaveChanges();
                        LimpiarCampos();
                        MessageBox.Show("Paciente registrado correctamente", "Operación  Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnombre.Focus();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnGuardadReg_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateCurrent = DateTime.Now;
                if (dtpfechanacimiento.Value.ToShortDateString() == dateCurrent.ToShortDateString())
                {
                    MessageBox.Show("La fecha de nacimiento debe ser inferior a la fecha actual: " + DateTime.Now, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((txtnombre.Text != "") && (txtpapellido.Text != "") && (txtdireccion.Text != "") &&
                       (cmbestadocivil.Text != "") && (cmbsexo.Text != "") && (txtruta.Text != "") && (txtnombretutor.Text != "") && (mtbTelTutor.Text != ""))
                {
                    agregarnino();
                }
                else
                {

                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
