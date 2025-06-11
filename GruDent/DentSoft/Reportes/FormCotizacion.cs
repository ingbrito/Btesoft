using CapaEntidad;
using DentSoft.Formularios_de_Facturacion;
using Microsoft.Reporting.WinForms;
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
    public partial class FormCotizacion : Form
    {

        public List<Cotization> cotizacion = new List<Cotization>();
        public FormCotizacion()
        {
            InitializeComponent();
        }

        private void FormCotizacion_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetCotizacion", cotizacion));

            this.reportViewer1.RefreshReport();
        }
    }
}
