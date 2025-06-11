using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DentSoft.Formularios_de_Registro;
using DentSoft.Formularios_de_Consulta;
using DentSoft.Formulario_Registro_Licencia;
using DentSoft.Formularios_de_edicion;
using DentSoft.FormAyuda;
using DentSoft.Formularios_de_Facturacion.Formularios_de_seleccion;
using DentSoft.Formularios_de_Facturacion;
using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using CapaNegocio;
using DentSoft.Formulario_de_Citas;

namespace DentSoft
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
            customizeDesign();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            SetStyle(ControlStyles.ResizeRedraw, true);
            DoubleBuffered = true;
        }

        public string validarusuario = null;

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size = Screen.PrimaryScreen.WorkingArea.Size;

            if (validarusuario == "Estandar")
            {
                btnConfiguraciones.Visible = false;
            }
            else if (validarusuario == "Administrador")
            {
                btnConfiguraciones.Visible = true;
            }

            /// Validar productkey
            /// 

           // CheckProductKeyDetails();
        }

        #region Metodos para registrar licencia 
        //private void CheckProductKeyDetails()
        //{
        //    E_ProductLicense prodlicense = GetProductKeyDetails();

        //    if (prodlicense.ProductKey == string.Empty)
        //    {
        //        int totaldaysleft = 0;

        //        if (prodlicense.TrialExpiryDate == new DateTime(1900, 1, 1))
        //        {
        //            UpdateTrialExpiryDate();

        //            totaldaysleft = FindTotalTrialDaysLeft(DateTime.Now.Date.AddMonths(1), DateTime.Now.Date);
        //        }
        //        else
        //        {
        //            totaldaysleft = FindTotalTrialDaysLeft(prodlicense.TrialExpiryDate, DateTime.Now.Date);
        //        }

        //        ShowLicenseForm(totaldaysleft);
        //    }
        //}

        //private int FindTotalTrialDaysLeft(DateTime trialExpiryDate, DateTime currentDate)
        //{
        //    int totaldaysleft = Convert.ToInt16((trialExpiryDate - currentDate).TotalDays);

        //    if (totaldaysleft < 0)
        //        totaldaysleft = 0;

        //    return totaldaysleft;
        //}

        //private void UpdateTrialExpiryDate()
        //{
        //    string connstring = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;

        //    using (SqlConnection conn = new SqlConnection(connstring))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("UPDATE ProductKey SET [TrialExpiryDate]=@TrialExpiryDate", conn))
        //        {
        //            cmd.Parameters.AddWithValue("@TrialExpiryDate", DateTime.Now.Date.AddMonths(1));

        //            conn.Open();

        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        //private void ShowLicenseForm(int totaldaysleft)
        //{
        //     FormLicencia lf = new FormLicencia();
        //     lf.TotalDaysLeft = totaldaysleft;
        //     lf.ShowDialog();
        //}


        //private E_ProductLicense GetProductKeyDetails()
        //{

        //    E_ProductLicense Pl = new E_ProductLicense();

        //    string connstring = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;

        //    using (SqlConnection conn = new SqlConnection(connstring))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProductKey", conn))
        //        {
        //            conn.Open();

        //            SqlDataReader reader = cmd.ExecuteReader();

        //            reader.Read();

        //            Pl.NombreEmpresa = reader["NombreEmpresa"].ToString();
        //            Pl.ProductKey = reader["ProductKey"].ToString();
        //            Pl.TrialExpiryDate = Convert.ToDateTime(reader["TrialExpiryDate"]);
        //        }
        //    }

        //    return Pl;
        //}

        #endregion

        #region Movilidad del formulario 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region mostrar y ocultar submenu al hacer click
        private void customizeDesign()
        {

            panelSubMenuRegistro.Visible = false;
            panelSubMenuReportes.Visible = false;
            panelSubMenConsult.Visible = false;
            panelSubMenuFacturacion.Visible = false;
            panelSubMenuAyuda.Visible = false;
            panelSubMenuUsers.Visible = false;
            panelSubMenuEmpr.Visible = false;
            panelSubMenuAgenda.Visible = false;

        }
        #endregion

        #region Metodo para cambiar tamano en tiempo ejecucion
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
     

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion
        
        #region EsconderSubMenu 
        private void hideSubMenu()
        {
            if (panelSubMenuRegistro.Visible == true)
                panelSubMenuRegistro.Visible = false;
            if (panelSubMenuReportes.Visible == true)
                panelSubMenuReportes.Visible = false;
            if (panelSubMenConsult.Visible == true)
                panelSubMenConsult.Visible = false;
            if (panelSubMenuFacturacion.Visible == true)
                panelSubMenuFacturacion.Visible = false;
            if (panelSubMenuAyuda.Visible == true)
                panelSubMenuAyuda.Visible = false;
            if (panelSubMenuUsers.Visible == true)
                panelSubMenuUsers.Visible = false;
            if (panelSubMenuEmpr.Visible == true)
                panelSubMenuEmpr.Visible = false;
            if (panelSubMenuAgenda.Visible == true)
                panelSubMenuAgenda.Visible = false;
            
        }
        #endregion

        #region Mostrar SubMenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region metodo para abrir formularios en panel

        //private Form activeForm = null;

        //private void openChildFormInPanel(Form childForm)
        //{
        ////    if (activeForm != null)
        ////        activeForm.Close();
        ////    activeForm = childForm;
        ////    childForm.TopLevel = false;
        ////    childForm.FormBorderStyle = FormBorderStyle.None;
        ////    childForm.Dock = DockStyle.Fill;
        ////    panelContenedorForm.Controls.Add(childForm);
        ////    panelContenedorForm.Tag = childForm;
        ////    childForm.BringToFront();
        ////    childForm.Show();
        ////}

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (panelContenedorForm.Controls.Count > 0)
                panelContenedorForm.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedorForm.Controls.Add(fh);
            panelContenedorForm.Tag = fh;
            fh.Show();
        }
        #endregion

        #region Menu y SubMenu del los formularios
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuRegistro);
        }

        private void bntAgenda_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAgenda);
        }
        private void btnEmpress_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuEmpr);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuUsers);
        }
        private void btnPacientes_Click(object sender, EventArgs e)
        {
        
            AbrirFormEnPanel(new RegistroPacientes());
            hideSubMenu();
        }

        private void btnPacienteNinos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroPacientesNinos());
            hideSubMenu();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FListadoFactura());
            hideSubMenu();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroDoctores());
            hideSubMenu();
        }

        private void btnProcedimientos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroProcedimientos());
            hideSubMenu();
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Diagnostico());
            hideSubMenu();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            //AbrirFormEnPanel(new RegistroEmpresas());
            //hideSubMenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuReportes);
        }

        private void btnLPacReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListadoPaciente());
            hideSubMenu();
        }


        private void btnDiagReportes_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListadoDiagnostico());
            hideSubMenu();

        }

        private void btnProceReportes_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListadoProcedimientos());
            hideSubMenu();

        }

        private void btnDocReportes_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListadoDoctores());
            hideSubMenu();
        }

        private void btnNinosReportes_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListadoPacientesNinos());
            hideSubMenu();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenConsult);
        }

        private void btnVerConsult_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FichaConsulta());
            hideSubMenu();
        }

        private void btnListadoConsult_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListadoConsulta());
            hideSubMenu();

        }
        private void btnCotizacion_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new Cotizaciones());
            hideSubMenu();
        }


        private void bntFacturacion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuFacturacion);

        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuAyuda);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            FormHelp fp = new FormHelp();
            fp.ShowDialog();
            hideSubMenu();

        }

       private void btnVerAyuda_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\ManualUsuario\\chm\\Manual Usuario GRUDENT.chm");
            //ManualUsuario mu = new ManualUsuario();
            //mu.ShowDialog();
            hideSubMenu();
        }

        private void bntRegEmpre_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroEmpresas());
            hideSubMenu();
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmRegistroCitas());
            hideSubMenu();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Alerta¡",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            } 
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroUsuarios());
            hideSubMenu();
        }

        #endregion

        #region Metodos para cerrar,minimizar formulario 
        private int lx, ly;
        private int sw, sh;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void panelBarra_DoubleClick(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        #endregion

        #region Fecha y hora en panel bajo

        private void tmFechaHora_Tick_1(object sender, EventArgs e)
        {

            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        #endregion

    }
}
