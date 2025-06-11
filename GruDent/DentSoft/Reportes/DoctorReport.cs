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
    public partial class DoctorReport : Form
    {
        public DoctorReport()
        {
            InitializeComponent();
        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void DoctorReport_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empresaDataSet.sp_SelectEmpresa' table. You can move, or remove it, as needed.
            this.sp_SelectEmpresaTableAdapter.Fill(this.empresaDataSet.sp_SelectEmpresa);
            // TODO: This line of code loads data into the 'doctorDataSet.sp_SelectDoctores' table. You can move, or remove it, as needed.
            this.sp_SelectDoctoresTableAdapter.Fill(this.doctorDataSet.sp_SelectDoctores);

            this.reportViewer1.RefreshReport();
        }
    }
}
