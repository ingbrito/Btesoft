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
using DentSoft.Formularios_de_Registro;
using DentSoft.Formularios_de_Consulta;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Infrastructure;

namespace DentSoft
{
    public partial class RegistroPacientes : Form
    {
        public RegistroPacientes()
        {
            InitializeComponent();
        }

        private static readonly E_Paciente e_Paciente = new E_Paciente();
#pragma warning disable IDE0052 // Remove unread private members
        private readonly E_Paciente objEntidad = e_Paciente;
        private static readonly N_Paciente n_Paciente = new N_Paciente();
#pragma warning restore IDE0052 // Remove unread private members
#pragma warning disable IDE0052 // Remove unread private members
        private readonly N_Paciente objNegocio = n_Paciente;
#pragma warning restore IDE0052 // Remove unread private members

        #region Limpiar txt

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
        }

        #endregion
        //#region Metodo Insertar Paciente
        //private void Agregarpaciente()
        //{
        //    try
        //    {
        //        if (dtpfechanacimiento.Value >= DateTime.Now)
        //        {
        //            MessageBox.Show("La fecha de nacimiento no debe ser posterior a la fecha actual: " + DateTime.Now, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            byte[] file = null;
        //            Stream mystream = opdImagen.OpenFile();

        //            using (MemoryStream ms = new MemoryStream())
        //            {
        //                mystream.CopyTo(ms);
        //                file = ms.ToArray();
        //            }
        //            using (Model.GRUDENTEntities db = new Model.GRUDENTEntities())
        //            {
        //                Model.Paciente oImage = new Model.Paciente
        //                {
        //                    Documento = txtcedula.Text.Trim(),
        //                    Nombres = txtnombre.Text.Trim(),
        //                    PrimerApellido = txtpapellido.Text.Trim(),
        //                    SegundoApellido = txtsapellido.Text.Trim(),
        //                    Sexo = cmbsexo.Text.Trim(),
        //                    FechaDeNacimiento = Convert.ToDateTime(dtpfechanacimiento.Value),
        //                    EstadoCivil = cmbestadocivil.Text.Trim(),
        //                    GrupoSanguineo = cmbgruposanguineo.Text.Trim(),
        //                    ARS = cmbars.Text.Trim(),
        //                    NSS = txtnss.Text.Trim(),
        //                    CorreoElectronico = txtcorreoelectronico.Text.Trim(),
        //                    Telefono = txttelefono.Text.Trim(),
        //                    Celular = txtcelular.Text.Trim(),
        //                    Direccion = txtdireccion.Text.Trim(),

        //                    Foto = file
        //                };

        //                db.Paciente.Add(oImage);
        //                db.SaveChanges();
        //                LimpiarCampos();
        //                MessageBox.Show("Paciente registrado correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                txtnombre.Focus();
        //            }
        //        }
        //    }
        //    catch (DbUpdateException ex)
        //    {
        //        if (ex.InnerException.InnerException is SqlException sql)
        //        {
        //            if (sql.Number == 2627)
        //            {
        //                MessageBox.Show("Este clienta ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }

        //        }
        //    }
        //}

        //#endregion

        #region

        private void Agregarpaciente()
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
                    string odontogramaPath = Path.Combine(Application.StartupPath, "Resources", "Odontograma.png");

                    if (File.Exists(odontogramaPath))
                    {
                        file = File.ReadAllBytes(odontogramaPath);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la imagen base del odontograma en la ruta: " + odontogramaPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (Model.GRUDENTEntities db = new Model.GRUDENTEntities())
                    {
                        Model.Paciente oImage = new Model.Paciente
                        {
                            Documento = txtcedula.Text.Trim(),
                            Nombres = txtnombre.Text.Trim(),
                            PrimerApellido = txtpapellido.Text.Trim(),
                            SegundoApellido = txtsapellido.Text.Trim(),
                            Sexo = cmbsexo.Text.Trim(),
                            FechaDeNacimiento = Convert.ToDateTime(dtpfechanacimiento.Value),
                            EstadoCivil = cmbestadocivil.Text.Trim(),
                            GrupoSanguineo = cmbgruposanguineo.Text.Trim(),
                            ARS = cmbars.Text.Trim(),
                            NSS = txtnss.Text.Trim(),
                            CorreoElectronico = txtcorreoelectronico.Text.Trim(),
                            Telefono = txttelefono.Text.Trim(),
                            Celular = txtcelular.Text.Trim(),
                            Direccion = txtdireccion.Text.Trim(),
                            Foto = file
                        };

                        db.Paciente.Add(oImage);
                        db.SaveChanges();
                        LimpiarCampos();
                        MessageBox.Show("Paciente registrado correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnombre.Focus();
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.InnerException is SqlException sql)
                {
                    if (sql.Number == 2627)
                    {
                        MessageBox.Show("Este paciente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardadReg_Click(object sender, EventArgs e)
        {

            try
            {
                #region Codigo validar dia anterior de otra forma
                //if ((DateTime.Now - dtpfechanacimiento.Value).Ticks <= TimeSpan.TicksPerDay)
                //{
                //    MessageBox.Show("La fecha de nacimiento debe ser inferior a la fecha actual: " + DateTime.Now, "Error en la operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                #endregion

                DateTime dateCurrent = DateTime.Now;
                if (dtpfechanacimiento.Value.ToShortDateString() == dateCurrent.ToShortDateString())
                {
                    MessageBox.Show("La fecha de nacimiento debe ser inferior a la fecha actual: " + DateTime.Now, "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if ((txtnombre.Text != "") && (txtpapellido.Text != "") && (txtdireccion.Text != "") &&
                       (cmbestadocivil.Text != "") && (cmbsexo.Text != "") )
                        
                {
                    Agregarpaciente();
                }
                else
                   
                {
                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        public string fn;
        public string edad;
        private void Dtpfechanacimiento_ValueChanged(object sender, EventArgs e)
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
    }
}
