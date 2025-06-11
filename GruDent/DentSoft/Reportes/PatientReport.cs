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
    public partial class PatientReport : Form
    {
        public PatientReport()
        {
            InitializeComponent();
        }

        private void PatientReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empresaDataSet.sp_SelectEmpresa' table. You can move, or remove it, as needed.
            this.sp_SelectEmpresaTableAdapter.Fill(this.empresaDataSet.sp_SelectEmpresa);
            // TODO: This line of code loads data into the 'patientDataSet.sp_SelectPaciente' table. You can move, or remove it, as needed.
            this.sp_SelectPacienteTableAdapter.Fill(this.patientDataSet.sp_SelectPaciente);


            this.reportViewer1.RefreshReport();
        }
    }
}
