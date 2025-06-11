namespace DentSoft.Reportes
{
    partial class DetailFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sp_SelectFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetailsFactDataSet = new DentSoft.Reportes.DetailsFactDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_SelectFacturasTableAdapter = new DentSoft.Reportes.DetailsFactDataSetTableAdapters.Sp_SelectFacturasTableAdapter();
            this.empresaDataSet = new DentSoft.Reportes.EmpresaDataSet();
            this.spSelectEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SelectEmpresaTableAdapter = new DentSoft.Reportes.EmpresaDataSetTableAdapters.sp_SelectEmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_SelectFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsFactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_SelectFacturasBindingSource
            // 
            this.Sp_SelectFacturasBindingSource.DataMember = "Sp_SelectFacturas";
            this.Sp_SelectFacturasBindingSource.DataSource = this.DetailsFactDataSet;
            // 
            // DetailsFactDataSet
            // 
            this.DetailsFactDataSet.DataSetName = "DetailsFactDataSet";
            this.DetailsFactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DetailFactDataSet";
            reportDataSource1.Value = this.Sp_SelectFacturasBindingSource;
            reportDataSource2.Name = "EmprDataSet";
            reportDataSource2.Value = this.spSelectEmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DentSoft.Reportes.DetalleFacturaReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(822, 442);
            this.reportViewer1.TabIndex = 0;
            // 
            // Sp_SelectFacturasTableAdapter
            // 
            this.Sp_SelectFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // empresaDataSet
            // 
            this.empresaDataSet.DataSetName = "EmpresaDataSet";
            this.empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSelectEmpresaBindingSource
            // 
            this.spSelectEmpresaBindingSource.DataMember = "sp_SelectEmpresa";
            this.spSelectEmpresaBindingSource.DataSource = this.empresaDataSet;
            // 
            // sp_SelectEmpresaTableAdapter
            // 
            this.sp_SelectEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // DetailFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 442);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DetailFactura";
            this.Text = "DetalleFactura";
            this.Load += new System.EventHandler(this.DetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_SelectFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsFactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_SelectFacturasBindingSource;
        private DetailsFactDataSet DetailsFactDataSet;
        private DetailsFactDataSetTableAdapters.Sp_SelectFacturasTableAdapter Sp_SelectFacturasTableAdapter;
        private EmpresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource spSelectEmpresaBindingSource;
        private EmpresaDataSetTableAdapters.sp_SelectEmpresaTableAdapter sp_SelectEmpresaTableAdapter;
    }
}