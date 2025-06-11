namespace DentSoft.Reportes
{
    partial class ProcessReport
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
            this.spSelectProcedimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processDataSet = new DentSoft.Reportes.ProcessDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_SelectProcedimientosTableAdapter = new DentSoft.Reportes.ProcessDataSetTableAdapters.sp_SelectProcedimientosTableAdapter();
            this.empresaDataSet = new DentSoft.Reportes.EmpresaDataSet();
            this.spSelectEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SelectEmpresaTableAdapter = new DentSoft.Reportes.EmpresaDataSetTableAdapters.sp_SelectEmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectProcedimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spSelectProcedimientosBindingSource
            // 
            this.spSelectProcedimientosBindingSource.DataMember = "sp_SelectProcedimientos";
            this.spSelectProcedimientosBindingSource.DataSource = this.processDataSet;
            // 
            // processDataSet
            // 
            this.processDataSet.DataSetName = "ProcessDataSet";
            this.processDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProcessReport";
            reportDataSource1.Value = this.spSelectProcedimientosBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.spSelectEmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DentSoft.Reportes.ProcessReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(701, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_SelectProcedimientosTableAdapter
            // 
            this.sp_SelectProcedimientosTableAdapter.ClearBeforeFill = true;
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
            // ProcessReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 406);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ProcessReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProcessReport";
            this.Load += new System.EventHandler(this.ProcessReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spSelectProcedimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProcessDataSet processDataSet;
        private System.Windows.Forms.BindingSource spSelectProcedimientosBindingSource;
        private ProcessDataSetTableAdapters.sp_SelectProcedimientosTableAdapter sp_SelectProcedimientosTableAdapter;
        private EmpresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource spSelectEmpresaBindingSource;
        private EmpresaDataSetTableAdapters.sp_SelectEmpresaTableAdapter sp_SelectEmpresaTableAdapter;
        //  private DataSetPrincipalTableAdapters.sp_SelectProcedimientosTableAdapter sp_SelectProcedimientosTableAdapter;
    }
}