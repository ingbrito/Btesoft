using DentSoft.Seguridad;
using DevExpress.XtraEditors;
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
    public partial class UcMenuPrincipal : UserControl
    {
        public static FrmMain Instance { get; private set; }
        public string validarusuario = null;
        public string usuarioLogin = null;   // login usuario
        public UcMenuPrincipal(string rolUsuario, string loginUsuario)
        {
            InitializeComponent();
            Instance = FrmMain.Instance;
            //CargarControl(new UcMenuRegistro()); // Carga el menú por defecto
            validarusuario = rolUsuario;
            usuarioLogin = loginUsuario;
            DoubleBuffered = true;
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
        public void CargarControl(UserControl control)
        {
            panelCentral.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(control);
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso("AccesoRegistro", validarusuario))
            {
                FrmMain.Instance.CargarControl(new UcMenuRegistro());
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }           
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            if (!PermisosHelper.TienePermiso("AccesoReportes", validarusuario))
            {
                FrmMain.Instance.CargarControl(new UcReportes());
               
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
                return;
            }

        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
           if (PermisosHelper.TienePermiso("AccesoConsultas", validarusuario))
            {
                FrmMain.Instance.CargarControl(new UcConsultas());
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
                FrmMain.Instance.CargarControl(new UcFacturacion());
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
                FrmMain.Instance.CargarControl(new UcEmpresa());
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
                FrmMain.Instance.CargarControl(new UcRegCitas());
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
                FrmMain.Instance.CargarControl(new UcAdministracion());
            }
            else
            {
                MessageBox.Show("Acceso denegado.");
            }

        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            FrmMain.Instance.CargarControl(new UcAyuda());

        }

        private void UcMenuPrincipal_Load(object sender, EventArgs e)
        {
            PermisosHelper.ImprimirPermisos();

            Location = Screen.PrimaryScreen.WorkingArea.Location;
            Size = Screen.PrimaryScreen.WorkingArea.Size;

            if (!string.IsNullOrEmpty(validarusuario))
            {
                AplicarPermisosDesdeRol(validarusuario);
    
            }
            else
            {
                MessageBox.Show("Error: rol del usuario no asignado.");
                //Close(); // Cierra el control si no hay rol asignado
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
    }
}
