using DentSoft.Formularios_de_Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using System.Configuration;
using System.Data.SqlClient;
using DentSoft.Formularios_de_edicion;
using System.IO;
using System.Drawing.Imaging;
using DentSoft.Model;
using System.Data.Entity;
using DentSoft.Formularios_de_seleccion;
using DentSoft.Formularios_de_Facturacion;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class FichaConsulta : Form
    {
        private static readonly Consulta consulta = new Consulta();
        private readonly Consulta model = consulta;

        public FichaConsulta()
        {
            InitializeComponent();
            g = drawpaint.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        public int idp = 0; // variable para guardar el id del paciente
        public int idd = 0; // variable para guardar el id del doctor
        public int id;


        #region area de capa entidad y negocio 
        private readonly E_Procedimientos objEntidad = new E_Procedimientos();
        private static readonly N_Procedimientos n_Procedimientos = new N_Procedimientos();
        private readonly N_Procedimientos objNegocio = n_Procedimientos;
        private static readonly E_Diagnostico e_Diagnostico = new E_Diagnostico();
        private readonly E_Diagnostico objEnditadc = e_Diagnostico;
        private readonly N_Diagnostico objNegociod = new N_Diagnostico();
        private static readonly SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Conexion a la base de datos
        private readonly SqlConnection conexion =
        sqlConnection;
        #endregion

        #region variables para dibujo 
        public Point actual = new Point();
        public Point viejo = new Point();
        public Graphics g;
        public Pen pen = new Pen(Color.Black, 5);
        Bitmap btm;

        #endregion

        #region Metodo para dibujar en imagen 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void drawpaint_MouseDown(object sender, MouseEventArgs e)
        {
            viejo = e.Location;
        }
        private void drawpaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                actual = e.Location;
                g.DrawLine(pen, viejo, actual);
                viejo = actual;

                Image pic = drawpaint.Image;
                btm = new Bitmap(pic);
                g = Graphics.FromImage(btm);
                drawpaint.Image = btm;
            }
        }

        private void drawpaint_MouseUp(object sender, MouseEventArgs e)
        {
            actual = e.Location;
        }
        #endregion

        #region Limpiar Campos
        private void LimpiarCampos()
        {
            txtmotivo.Clear();
            txtindicaciones.Clear();
            txtobservaciones.Clear();
            lbDiag.Items.Clear();
            lbProc.Items.Clear();

        }
        #endregion

        #region Area de botones buscar y guardar

        public byte[] ImageToByteArray(Image imagen)
        {
            if (imagen is null)
            {
                throw new ArgumentNullException(nameof(imagen));
            }

            MemoryStream ms = new MemoryStream();
            //imagen.Save(ms, ImageFormat.Jpeg);
            drawpaint.Image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
        private void btnGuardarReg__Click_1(object sender, EventArgs e)
        {
            try
            {
                if (lblpaciente.Text != "" && lblsexo.Text != "" && lbledad.Text != "" && lbldoctor.Text != "" && txtmotivo.Text != "" && lbProc.Items.Count != 0 && lbDiag.Items.Count != 0)
                {
                    #region Obteniendo datos de los listbox

                    StringBuilder procedimientos = new StringBuilder();
                    procedimientos.Clear();

                    foreach (var item in lbProc.Items)

                    {
                        procedimientos.Append(item);
                        procedimientos.Append(",");
                    }

                    StringBuilder diagnosticos = new StringBuilder();
                    diagnosticos.Clear();

                    foreach (var item in lbDiag.Items)

                    {
                        diagnosticos.Append(item);
                        diagnosticos.Append(",");
                    }
                    #endregion


                    byte[] bai = ImageToByteArray(drawpaint.Image);
                    Consulta oImage = new Consulta
                    {
                        NombrePaciente = lblpaciente.Text.Trim(),
                        Edad = lbledad.Text.Trim(),
                        Sexo = lblsexo.Text.Trim(),
                        IdPaciente = idp,
                        IdDoctor = idd,
                        Fecha = Convert.ToDateTime(dtpFechaConsulta.Value.ToString()),
                        NombreDoctor = lbldoctor.Text.Trim(),
                        Motivo = txtmotivo.Text.Trim(),
                        Plan_Tratamiento = txtPlanTratamiento.Text.Trim(),
                        Diagnostico = Convert.ToString(diagnosticos),
                        Procedimiento = Convert.ToString(procedimientos),
                        Observaciones = txtobservaciones.Text.Trim(),
                        Indicaciones = txtindicaciones.Text.Trim(),
                        Foto = bai
                    };


                    using (GRUDENTEntities db = new GRUDENTEntities())
                    {

                        db.Consulta.Add(oImage);
                        db.SaveChanges();
                        LimpiarCampos();

                        MessageBox.Show("Consulta registrada correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                else
                {
                    MessageBox.Show("Faltan campos obligatorios", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Procedimiento proce = new Procedimiento();
                AddOwnedForm(proce);
                proce.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarD_Click(object sender, EventArgs e)
        {
            try
            {
                Diagnostic diagn = new Diagnostic();
                AddOwnedForm(diagn);
                diagn.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnBuscarPacientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtnadulto.Checked)
                {
                    ListadoPacienteConsulta lp = new ListadoPacienteConsulta();
                    AddOwnedForm(lp);
                    lp.Show();
                }
                else if (rdbtnninos.Checked)
                {
                    ListadoNinosConsulta ln = new ListadoNinosConsulta();
                    AddOwnedForm(ln);
                    ln.Show();

                }
                else
                {
                    MessageBox.Show("Debe seleccionar si es niño o adulto antes de intentar realizar la búsqueda", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBuscarDoctores_Click(object sender, EventArgs e)
        {
            try
            {
                ListaDoctores listdoct = new ListaDoctores();
                AddOwnedForm(listdoct);
                listdoct.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Realmente deseas eliminar este procedimiento", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                lbProc.Items.RemoveAt(lbProc.Items.Count - 1);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleecionar un procedimiento", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Realmente deseas eliminar este diagnóstico", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                lbDiag.Items.RemoveAt(lbDiag.Items.Count - 1);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un diagnóstico", "Transacción erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUltimcaConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                UltimaConsulta uc = new UltimaConsulta();

                using (GRUDENTEntities db = new GRUDENTEntities())
                {
                    var paciente = db.Consulta.Where(x => x.IdPaciente == idp)
                        .OrderByDescending(x => x.Fecha)
                        .FirstOrDefault();
                    if (paciente == null)
                    {

                        MessageBox.Show("El paciente no tiene consultas previas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }

                    using (MemoryStream ms = new MemoryStream(paciente.Foto))
                    {
                        uc.pbficha.Image = Image.FromStream(ms);
                        uc.lblprocedimiento.Text = paciente.Procedimiento;
                        uc.lbldiagnostico.Text = paciente.Diagnostico;
                        uc.lblobservacion.Text = paciente.Observaciones;
                        uc.lblfecha.Text = paciente.Fecha.ToString();
                    }

                }
                AddOwnedForm(uc);
                uc.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

