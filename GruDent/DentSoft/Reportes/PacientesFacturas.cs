﻿    using System;
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
    public partial class PacientesFacturas : Form
    {
        public PacientesFacturas()
        {
            InitializeComponent();
        }

        private void PacientesFacturas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gRUDENTDataSet1.sp_SelectFacturas' table. You can move, or remove it, as needed.
            this.sp_SelectFacturasTableAdapter.Fill(this.gRUDENTDataSet1.sp_SelectFacturas);
            // TODO: This line of code loads data into the 'gRUDENTDataSet.Procesos' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
        }
    }
}
