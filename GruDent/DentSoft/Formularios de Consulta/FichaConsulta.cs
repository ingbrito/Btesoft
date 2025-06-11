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
using DentSoft.Formularios_de_Consulta;
using DentSoft.Model;
using System.Data.Entity;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class FichaConsulta : Form
    {
        Consulta model = new Consulta();
        
        public FichaConsulta()
        {
            InitializeComponent();
            g = drawpaint.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void FichaConsulta_Load(object sender, EventArgs e)
        {
            RellenarDgv();
        }
        public int idp = 0; // variable para guardar el id del paciente
        public int idd = 0; // variable para guardar el id del doctor
       

        #region area de capa entidad y negocio 
        E_Procedimientos objEntidad = new E_Procedimientos();
        N_Procedimientos objNegocio = new N_Procedimientos();

        E_Diagnostico objEnditadc = new E_Diagnostico();
        N_Diagnostico objNegociod = new N_Diagnostico();

        E_Odontograma objEntidadO = new E_Odontograma();
        N_Odontograma objNegociO = new N_Odontograma();

        #endregion

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            //DataTable dt = objNegocio.CN_RellenarProcedimiento();
            //DataTable dtd = objNegociod.CN_RellenarDiagnostico();
            //dgvProceConsulta.DataSource = dt;
            //dgvDiagnConsulta.DataSource = dtd;
        }
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
  
        #region Area de botones buscar 

        public byte[] ImageToByteArray(Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            //imagen.Save(ms, ImageFormat.Jpeg);
            drawpaint.Image.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnGuardarReg__Click_1(object sender, EventArgs e)
        {

            if (txtNombrePaciente.Text != "" && txtSexoPaciente.Text != "" && txtEdadPaciente.Text != "" && txtmotivo.Text != "")
            {
                byte[] bai = ImageToByteArray(drawpaint.Image);
                Consulta oImage = new Consulta();
                oImage.NombrePaciente = txtNombrePaciente.Text.Trim();
                oImage.Edad = txtEdadPaciente.Text.Trim();
                oImage.Sexo = txtSexoPaciente.Text.Trim();
                oImage.IdPaciente = idp;
                oImage.IdDoctor = idd;
                oImage.Fecha = Convert.ToDateTime(dtpFechaConsulta.Value.ToString());
                oImage.NombreDoctor = txtNombreDoctor.Text.Trim();
                oImage.Motivo = txtmotivo.Text.Trim();
                oImage.Diagnostico = lbDiag.Text;
                oImage.Procedimiento = lbProce.Text;
                oImage.Observaciones = txtobservaciones.Text.Trim();
                oImage.Indicaciones = txtindicaciones.Text.Trim();
                oImage.Foto = bai;


                using (GRUDENTEntities db = new GRUDENTEntities())
                {
                    //model = db.Consulta.Where(x => x.IdPaciente == model.IdPaciente).FirstOrDefault();
                    ////condicion que verifica si el id del paciente es nuevo e inserta
                    //if (model.IdPaciente == 0)
                    //{
                       

                    //}
                    ////condicion que verifica si el es el mismo id del paciente y actualiza
                    //else
                    //{
                    //    db.Entry(oImage).State = EntityState.Modified;

                    //}

                    db.Consulta.Add(oImage);
                    db.SaveChanges();
                    MessageBox.Show("Consulta registrada correctamente", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Faltan campos obligatorios", "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           


        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Procedimiento proce = new Procedimiento();
            proce.ShowDialog();
        }

        private void btnAgregarD_Click(object sender, EventArgs e)
        {
            Diagnostic diagn = new Diagnostic();

            AddOwnedForm(diagn);
            diagn.ShowDialog();

        }

       public int id;
        private void bntBuscarPaciente_Click_1(object sender, EventArgs e)
        {
            ListadoPacienteConsulta lp = new ListadoPacienteConsulta();

            AddOwnedForm(lp);
            lp.Show();
        }

        private void btnHistorial_Click_1(object sender, EventArgs e)
        {
            HistoriaClinica hc = new HistoriaClinica();
            AddOwnedForm(hc);
            hc.Show();

        }
        private void btnBuscarDoctor_Click(object sender, EventArgs e)
        {
            ListaDoctores listdoct = new ListaDoctores();
            AddOwnedForm(listdoct);
            listdoct.Show();
        }
        #endregion

        #region Metodo Insertar ficha consulta
        void Insertar()
        {
          
            objEntidadO.nombre = txtNombrePaciente.Text;
            objEntidadO.edad = txtNombrePaciente.Text;
            objEntidadO.sexo = txtNombrePaciente.Text;
            objEntidadO.fechaconsult = dtpFechaConsulta.Value;
            objEntidadO.motivo = txtmotivo.Text;
            objEntidadO.fichaconsult = drawpaint.ImageLocation;
            //objEntidadO.indicacion = txtindicicaciones.Text;
            objEntidadO.process = lbProce.Text;
            objEntidadO.diagnostic = lbDiag.Text;

            objNegociO.CN_InsertarOdontograma(objEntidadO);
            MessageBox.Show("Registro Insertado Satisfactoriamente", "Transaccion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


        #endregion

        private void btnVerFicha_Click(object sender, EventArgs e)
        {
            VerFicha vf = new VerFicha();

            using (GRUDENTEntities db = new GRUDENTEntities())
            {
                var oImage = db.Consulta.Find(id);
                //var oImage = db.Consulta.OrderByDescending(x => x.Fecha).First().Fecha;

                MemoryStream ms = new MemoryStream(oImage.Foto);
                Bitmap bmp = new Bitmap(ms);

                vf.pbficha.Image = bmp;
                vf.Show();
            }
        }
    }
    }

