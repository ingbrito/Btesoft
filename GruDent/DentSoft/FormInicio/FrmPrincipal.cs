using DentSoft.FormAyuda;
using DentSoft.Formulario_de_Citas;
using DentSoft.Formularios_de_Consulta;
using DentSoft.Formularios_de_Facturacion.Formularios_de_seleccion;
using DentSoft.Formularios_de_Registro;
using DentSoft.Model;
using DentSoft.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DentSoft.FormInicio
{
    public partial class FrmPrincipal : Form
    {

        public string validarusuario = null;
        public string usuarioLogin = null;   // login usuario
        public FrmPrincipal(string rolUsuario, string loginUsuario)
        {
            InitializeComponent();

            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            SetStyle(ControlStyles.ResizeRedraw, true);
            validarusuario = rolUsuario;
            usuarioLogin = loginUsuario;
            DoubleBuffered = true;
        }

        public FrmPrincipal()
        {
        }

        public partial class RolPermiso
        {
            public int IdRol { get; set; }
            public int IdPermiso { get; set; }

            public virtual Roles Roles { get; set; }
            public virtual Permisos Permisos { get; set; }
        }

        #region metodo para validar permisos de usuario

        private void AplicarPermisosDesdeRol(string rolNombre)
        {
            btnRegistros.Visible = PermisosHelper.TienePermiso("AccesoRegistro", rolNombre);
            BtnConsultas.Visible = PermisosHelper.TienePermiso("AccesoConsulta", rolNombre);
            BtnFacturacion.Visible = PermisosHelper.TienePermiso("AccesoFacturacion", rolNombre);
            BtnAgenda.Visible = PermisosHelper.TienePermiso("AccesoAgenda", rolNombre);
            BtnEmpresa.Visible = PermisosHelper.TienePermiso("AccesoEmpresa", rolNombre);
            BtnConfiguracion.Visible = PermisosHelper.TienePermiso("AccesoConfiguracion", rolNombre);
            BtnReportes.Visible = PermisosHelper.TienePermiso("AccesoReportes", rolNombre);
            BtnAyuda.Visible = PermisosHelper.TienePermiso("AccesoAyuda", rolNombre);
        }

        #endregion


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            PermisosHelper.ImprimirPermisos();

            Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size = Screen.PrimaryScreen.WorkingArea.Size;

            if (!string.IsNullOrEmpty(validarusuario))
            {
                AplicarPermisosDesdeRol(validarusuario);
                //AbrirFormEnPanel(new FrmPrincipal()); // pantalla de inicio por defecto
                //MessageBox.Show($"Usuario logueado: {usuarioLogin} - Rol: {validarusuario}");
            }
            else
            {
                MessageBox.Show("Error: rol del usuario no asignado.");
                Close();
            }
          

            switch (validarusuario)
            {
                case "Administrador":
                    // Todo visible por defecto
                    break;

                case "Recepcionista":
                    BtnConsultas.Visible = false;
                    BtnEmpresa.Visible = false;
                    BtnAgenda.Visible = false;
                    BtnConfiguracion.Visible = false;
                    BtnAyuda.Visible = false; // Opcional

                    // Aquí puedes aplicar filtros dentro del formulario "Registros"
                    break;

                case "Doctor":
                    btnRegistros.Visible = false;
                    BtnFacturacion.Visible = false;
                    BtnConfiguracion.Visible = false;
                    BtnEmpresa.Visible = false;
                    BtnAyuda.Visible = false;
                    break;

                    case "Caja":
                    btnRegistros.Visible = false;
                    BtnFacturacion.Visible = false;
                    BtnConfiguracion.Visible = false;
                    BtnEmpresa.Visible = false;
                    BtnAyuda.Visible = false;
                    break;

                case "Estandar":
                    btnRegistros.Visible = false;
                    BtnConsultas.Visible = false;
                    BtnFacturacion.Visible = false;
                    BtnEmpresa.Visible = false;
                    BtnAgenda.Visible = false;
                    BtnConfiguracion.Visible = false;
                    BtnAyuda.Visible = false;
                    break;

            }
        }

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

        #region Botones de cerrar y minimizar 
#pragma warning disable IDE0052 // Remove unread private members
        private int lx, ly;
#pragma warning restore IDE0052 // Remove unread private members
#pragma warning disable IDE0052 // Remove unread private members
        private int sw, sh;
#pragma warning restore IDE0052 // Remove unread private members

        private void PanelBarra_DoubleClick(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar sesión?", "Alerta¡",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region metodo para abrir formularios en panel
        private readonly Form currentChildForm;
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();

            currentChildForm?.Close();

        }
        private void Hidebuttom()
        {
            BtnAgenda.Hide();
            BtnAyuda.Hide();
            BtnConfiguracion.Hide();
            BtnConsultas.Hide();
            BtnEmpresa.Hide();
            BtnFacturacion.Hide();
            BtnReportes.Hide();
            btnRegistros.Hide();
        }
        #endregion

        #region Botones de menu principal
       
        private void BtnHome_Click(object sender, EventArgs e)
        {
            FrmMain.Instance.CargarControl(new UcMenuPrincipal(validarusuario));
        }
        private void BtnRegistros_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso("AccesoRegistro", validarusuario))
            {
                AbrirFormEnPanel(new FrmMenuRegistro());
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }
        }
  
        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso("AccesoConsulta", validarusuario))
            {
                AbrirFormEnPanel(new FrmMenuConsulta());
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }
            
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso("AccesoReportes", validarusuario))
            {
                AbrirFormEnPanel(new FrmListadoC());
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }
           
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso("AccesoFacturacion", validarusuario))
            {
                AbrirFormEnPanel(new FListadoFactura());
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }
            
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {   
            if (PermisosHelper.TienePermiso("AccesoEmpresa", validarusuario))
            {
                AbrirFormEnPanel(new RegistroEmpresas());
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso("AccesoAgenda", validarusuario))
            {
                AbrirFormEnPanel(new FrmRegistroCitas());
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }
           
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso("AccesoConfiguracion", validarusuario))
            {
                AbrirFormEnPanel(new RegistroUsuarios());
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }
        }


        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\ManualUsuario\\chm\\Manual Usuario GRUDENT.chm");
           // hidebuttom();
        }

        private void BntAcercaDe_Click(object sender, EventArgs e)
        {
            FormHelp fp = new FormHelp();
            fp.ShowDialog();

        }
        #endregion
    }
}
