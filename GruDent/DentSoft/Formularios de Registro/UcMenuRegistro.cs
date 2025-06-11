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

namespace DentSoft.Formularios_de_Registro
{
    public partial class UcMenuRegistro : UserControl
    {
        public UcMenuRegistro()
        {
            InitializeComponent();
        }

        private void CargarSubControl(UserControl control)
        {
            PanelControl.Controls.Clear();
            control.Dock = DockStyle.Fill;
            PanelControl.Controls.Add(control);
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            CargarSubControl(new UcRegistros());

        }

        private void BtnDoctores_Click(object sender, EventArgs e)
        {
            CargarSubControl(new UcRegDoctores());
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            CargarSubControl(new UcRegProcedimientos());
        }

        private void BtnDiagnostic_Click(object sender, EventArgs e)
        {
            CargarSubControl(new UcRegDiagnosticos());
        }

        private void UcMenuRegistro_Load(object sender, EventArgs e)
        {
           
        }
    }
}
