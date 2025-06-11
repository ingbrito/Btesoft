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
    public partial class FacturaReport : Form
    {
        public FacturaReport()
        {
            InitializeComponent();
        }

        private void FacturaReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empresaDataSet.sp_SelectEmpresa' table. You can move, or remove it, as needed.
            this.sp_SelectEmpresaTableAdapter.Fill(this.empresaDataSet.sp_SelectEmpresa);
            // TODO: This line of code loads data into the 'facturaDataSet.Sp_SelectFacturas' table. You can move, or remove it, as needed.
            this.sp_SelectFacturasTableAdapter.Fill(this.facturaDataSet.Sp_SelectFacturas);

            this.reportViewer1.RefreshReport();
        }
    }
}
