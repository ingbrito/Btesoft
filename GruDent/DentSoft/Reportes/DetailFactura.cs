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
    public partial class DetailFactura : Form
    {
     
        public DetailFactura( int idventa)
        {
            InitializeComponent();
            idventa = idvisualizar;
        }

        public int idvisualizar = 0;
        public int idvisualizar2 = 0;


        private void DetalleFactura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empresaDataSet.sp_SelectEmpresa' table. You can move, or remove it, as needed.
            this.sp_SelectEmpresaTableAdapter.Fill(this.empresaDataSet.sp_SelectEmpresa);
            // TODO: This line of code loads data into the 'DetailsFactDataSet.Sp_SelectFacturas' table. You can move, or remove it, as needed.
            this.Sp_SelectFacturasTableAdapter.Fill( DetailsFactDataSet.Sp_SelectFacturas,idvisualizar,idvisualizar2);

            this.reportViewer1.RefreshReport();
        }
    }
}
