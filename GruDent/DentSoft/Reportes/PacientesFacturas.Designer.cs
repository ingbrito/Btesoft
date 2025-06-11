namespace DentSoft.Reportes
{
    partial class PacientesFacturas
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
            this.gRUDENTDataSet1 = new DentSoft.GRUDENTDataSet1();
            this.spSelectFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SelectFacturasTableAdapter = new DentSoft.GRUDENTDataSet1TableAdapters.sp_SelectFacturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gRUDENTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectFacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spSelectFacturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DentSoft.Reportes.PacientesFacturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(727, 355);
            this.reportViewer1.TabIndex = 0;
            // 
            // gRUDENTDataSet1
            // 
            this.gRUDENTDataSet1.DataSetName = "GRUDENTDataSet1";
            this.gRUDENTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spSelectFacturasBindingSource
            // 
            this.spSelectFacturasBindingSource.DataMember = "sp_SelectFacturas";
            this.spSelectFacturasBindingSource.DataSource = this.gRUDENTDataSet1;
            // 
            // sp_SelectFacturasTableAdapter
            // 
            this.sp_SelectFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // PacientesFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 355);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PacientesFacturas";
            this.Text = "PacientesFacturas";
            this.Load += new System.EventHandler(this.PacientesFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gRUDENTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSelectFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GRUDENTDataSet1 gRUDENTDataSet1;
        private System.Windows.Forms.BindingSource spSelectFacturasBindingSource;
        private GRUDENTDataSet1TableAdapters.sp_SelectFacturasTableAdapter sp_SelectFacturasTableAdapter;
    }
}