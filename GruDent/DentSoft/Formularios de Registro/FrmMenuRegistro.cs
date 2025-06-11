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
using DentSoft.Formularios_de_Consulta;

namespace DentSoft.Formularios_de_Registro
{
    public partial class FrmMenuRegistro : Form
    {
        public FrmMenuRegistro()
        {
            InitializeComponent();
        }

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
            if (panelContC.Controls.Count > 0)
                panelContC.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContC.Controls.Add(fh);
            panelContC.Tag = fh;
            fh.Show();
        }
        #endregion

        #region Botones para abrir formularios en panel
        private void btnPacient_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroPacientes());
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroPacientesNinos());

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroDoctores());

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroProcedimientos());

        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Diagnostico());


        }
        #endregion
    }


}
