namespace DentSoft.Reportes
{
    partial class HistorialP
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new DentSoft.DataSet1();
            this.spSelectHistoricoConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SelectHistoricoConsultaTableAdapter = new DentSoft.DataSet1TableAdapters.sp_SelectHistoricoConsultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectHistoricoConsultaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spSelectHistoricoConsultaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DentSoft.Reportes.Phistorial.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(787, 464);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSelectHistoricoConsultaBindingSource
            // 
            this.spSelectHistoricoConsultaBindingSource.DataMember = "sp_SelectHistoricoConsulta";
            this.spSelectHistoricoConsultaBindingSource.DataSource = this.dataSet1;
            // 
            // sp_SelectHistoricoConsultaTableAdapter
            // 
            this.sp_SelectHistoricoConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // HistorialP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 464);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HistorialP";
            this.Text = "HistorialP";
            this.Load += new System.EventHandler(this.HistorialP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectHistoricoConsultaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource spSelectHistoricoConsultaBindingSource;
        private DataSet1TableAdapters.sp_SelectHistoricoConsultaTableAdapter sp_SelectHistoricoConsultaTableAdapter;
    }
}