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

namespace DentSoft.Formularios_de_Registro
{
    public partial class FrmMenuConsulta : Form
    {
        public FrmMenuConsulta()
        {
            InitializeComponent();
        }

        #region Metodo para abrir formularios en panel 
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

        private void btnConsult_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FichaConsulta());
        }

        private void btnListadoConsult_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ListadoConsulta());
        }
    }
}
