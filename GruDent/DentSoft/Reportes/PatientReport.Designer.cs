namespace DentSoft.Reportes
{
    partial class PatientReport
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
            this.spSelectPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientDataSet = new DentSoft.Reportes.PatientDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_SelectPacienteTableAdapter = new DentSoft.Reportes.PatientDataSetTableAdapters.sp_SelectPacienteTableAdapter();
            this.empresaDataSet = new DentSoft.Reportes.EmpresaDataSet();
            this.spSelectEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SelectEmpresaTableAdapter = new DentSoft.Reportes.EmpresaDataSetTableAdapters.sp_SelectEmpresaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spSelectPacienteBindingSource
            // 
            this.spSelectPacienteBindingSource.DataMember = "sp_SelectPaciente";
            this.spSelectPacienteBindingSource.DataSource = this.patientDataSet;
            // 
            // patientDataSet
            // 
            this.patientDataSet.DataSetName = "PatientDataSet";
            this.patientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spSelectPacienteBindingSource;
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.spSelectEmpresaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DentSoft.Reportes.PatientReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(701, 399);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_SelectPacienteTableAdapter
            // 
            this.sp_SelectPacienteTableAdapter.ClearBeforeFill = true;
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
            // PatientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 399);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PatientReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PatientReport";
            this.Load += new System.EventHandler(this.PatientReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spSelectPacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PatientDataSet patientDataSet;
        private System.Windows.Forms.BindingSource spSelectPacienteBindingSource;
        private PatientDataSetTableAdapters.sp_SelectPacienteTableAdapter sp_SelectPacienteTableAdapter;
        private EmpresaDataSet empresaDataSet;
        private System.Windows.Forms.BindingSource spSelectEmpresaBindingSource;
        private EmpresaDataSetTableAdapters.sp_SelectEmpresaTableAdapter sp_SelectEmpresaTableAdapter;
        // private DataSetPrincipalTableAdapters.sp_SelectPacienteTableAdapter sp_SelectPacienteTableAdapter;
    }
}