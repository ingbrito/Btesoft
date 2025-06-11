using DentSoft.FormAyuda;
using DentSoft.Formulario_de_Citas;
using DentSoft.Formularios_de_Facturacion.Formularios_de_seleccion;
using DentSoft.Formularios_de_Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.FormInicio
{
    public partial class FrmMainContent : Form
    {
        public FrmMainContent(string nombreUsuario, string rol)
        {
            InitializeComponent();
            lblBienvenida.Text = $"Bienvenido, {nombreUsuario}";
            lblRol.Text = $"Rol: {rol}";
        }

        public FrmMainContent()
        {
        }

        #region metodo para abrir formularios en panel
        private Form currentChildForm;
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

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

        }
        private void hidebuttom()
        {
            
        }
        #endregion

        #region Botones de menu principal

        private void btnHome_Click(object sender, EventArgs e)
        {
           
        }
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmMenuRegistro());
            hidebuttom();
            // hideSubMenu();
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmMenuConsulta());
            hidebuttom();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmListadoC());
            hidebuttom();
        }

        private void BtnFacturacion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FListadoFactura());
            hidebuttom();
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroEmpresas());
            hidebuttom();
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmRegistroCitas());
            hidebuttom();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroUsuarios());
            hidebuttom();
        }


        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\ManualUsuario\\chm\\Manual Usuario GRUDENT.chm");
           // hidebuttom();
        }

        private void bntAcercaDe_Click(object sender, EventArgs e)
        {
            FormHelp fp = new FormHelp();
            fp.ShowDialog();

        }
        #endregion

        private void btnCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
