using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Reportes
{
    public partial class HistorialP : Form
    {
        public HistorialP()
        {
            InitializeComponent();
        }

        private void HistorialP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sp_SelectHistoricoConsulta' table. You can move, or remove it, as needed.
            this.sp_SelectHistoricoConsultaTableAdapter.HistorialFill(this.dataSet1.sp_SelectHistoricoConsulta);

            this.reportViewer1.RefreshReport();
        }
    }
}
