namespace DentSoft.Reportes
{
    partial class DiagnosticReport
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
            this.spSelectDiagnosticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticDataSet = new DentSoft.Reportes.DiagnosticDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_SelectDiagnosticoTableAdapter = new DentSoft.Reportes.DiagnosticDataSetTableAdapters.sp_SelectDiagnosticoTableAdapter();
            this.empresaDataSet = new DentSoft.Reportes.EmpresaDataSet();
            this.spSelectEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SelectEmpresaTableAdapter = new DentSoft.Reportes.EmpresaDataSetTableAdapters.sp_SelectEmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectDiagnosticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spSelectDiagnosticoBindingSource
            // 
            this.spSelectDiagnosticoBindingSource.DataMember = "sp_SelectDiagnostico";
            this.spSelectDiagnosticoBindingSource.DataSource = this.diagnosticDataSetBindingSource;
            // 
            // diagnosticDataSetBindingSource
            // 
            this.diagnosticDataSetBindingSource.DataSource = this.diagnosticDataSet;
            this.diagnosticDataSetBindingSource.Position = 0;
            // 
            // diagnosticDataSet
            // 
            this.diagnosticDataSet.DataSetName = "DiagnosticDataSet";
            this.diagnosticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spSelectDiagnosticoBindingSource;
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.spSelectEmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DentSoft.Reportes.DiagnosticReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(640, 405);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_SelectDiagnosticoTableAdapter
            // 
            this.sp_SelectDiagnosticoTableAdapter.ClearBeforeFill = true;
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
            // DiagnosticReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 405);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DiagnosticReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DiagnosticReport";
            this.Load += new System.EventHandler(this.DiagnosticReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spSelectDiagnosticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource diagnosticDataSetBindingSource;
        private DiagnosticDataSet diagnosticDataSet;
        private System.Windows.Forms.BindingSource spSelectDiagnosticoBindingSource;
        private DiagnosticDataSetTableAdapters.sp_SelectDiagnosticoTableAdapter sp_SelectDiagnosticoTableAdapter;
        private EmpresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource spSelectEmpresaBindingSource;
        private EmpresaDataSetTableAdapters.sp_SelectEmpresaTableAdapter sp_SelectEmpresaTableAdapter;
        // private DataSetPrincipalTableAdapters.sp_SelectDiagnosticoTableAdapter sp_SelectDiagnosticoTableAdapter;
    }
}