using DentSoft.Formularios_de_Registro;
using DentSoft.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft
{
    public partial class UcMenuPrincipal : UserControl
    {
        private readonly string validarusuario;
        public UcMenuPrincipal(string usuario)
        {
            InitializeComponent();
            validarusuario = usuario;
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso(validarusuario, "Registros"))
            {
               //FormRegistro formRegistro = new FormRegistro();
               //formRegistro.ShowDialog();
               FrmMain.Instance.CargarControl(new UcFacturacion());
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a los registros.");
            }
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            if(PermisosHelper.TienePermiso(validarusuario,"Reportes"))
            {
                FrmMain.Instance.CargarControl(new UcReportes());
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a los reportes.");
            }
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso(validarusuario, "Consultas"))
            {
                FrmMain.Instance.CargarControl(new UcConsultas());
            }
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso(validarusuario, "Facturacion"))
            {
                FrmMain.Instance.CargarControl(new UcFacturacion());
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a la facturación.");
            }
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso(validarusuario,"Empresa"))
            {
                FrmMain.Instance.CargarControl(new UcEmpresa());
            }
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso(validarusuario, "Agenda"))
            {
                FrmMain.Instance.CargarControl(new UcRegCitas());
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a la agenda.");
            }
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso(validarusuario, "Configuracion"))
            {
                FrmMain.Instance.CargarControl(new UcAdministracion());
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a la configuración.");
            }

        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            if (PermisosHelper.TienePermiso(validarusuario, "Ayuda"))
            {
                FrmMain.Instance.CargarControl(new UcAyuda());
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder a la ayuda.");

            }
        }
    }
}

