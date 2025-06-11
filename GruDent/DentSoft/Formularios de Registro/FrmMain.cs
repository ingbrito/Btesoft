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
    public partial class FrmMain : Form
    {
       
        public static FrmMain Instance { get; private set; }
        public string RolUsuario { get; private set; }
        public string LoginUsuario { get; private set; }
        public FrmMain( string rolUsuario, string loginUsuario)
        {
            InitializeComponent();
            Instance = this;
            RolUsuario = rolUsuario;
            LoginUsuario = loginUsuario;
            CargarControl(new UcMenuPrincipal(rolUsuario, loginUsuario));

        }

        public void CargarControl(UserControl control)
        {
            panelCentral.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(control);
        }
    }
}
