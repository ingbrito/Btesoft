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
    public partial class DiagnosticReport : Form
    {
        public DiagnosticReport()
        {
            InitializeComponent();
        }

        private void DiagnosticReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empresaDataSet.sp_SelectEmpresa' table. You can move, or remove it, as needed.
            this.sp_SelectEmpresaTableAdapter.Fill(this.empresaDataSet.sp_SelectEmpresa);
            // TODO: This line of code loads data into the 'diagnosticDataSet.sp_SelectDiagnostico' table. You can move, or remove it, as needed.
            this.sp_SelectDiagnosticoTableAdapter.Fill(this.diagnosticDataSet.sp_SelectDiagnostico);

            this.reportViewer1.RefreshReport();
        }
    }
}
