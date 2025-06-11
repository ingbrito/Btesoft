namespace DentSoft.Formularios_de_Consulta
{
    partial class HistoriaClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoriaClinica));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSexoPacient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdadPacient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHistoriaClinica = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImpReport = new System.Windows.Forms.Button();
            this.gRUDENTDataSet = new DentSoft.GRUDENTDataSet();
            this.procesosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.procesosTableAdapter = new DentSoft.GRUDENTDataSetTableAdapters.ProcesosTableAdapter();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaClinica)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRUDENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(807, 38);
            this.BarraTitulo.TabIndex = 26;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(10, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(325, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Historia Clinica";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSexoPacient);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEdadPacient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombrePaciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 95);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // txtSexoPacient
            // 
            this.txtSexoPacient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSexoPacient.Location = new System.Drawing.Point(528, 32);
            this.txtSexoPacient.Multiline = true;
            this.txtSexoPacient.Name = "txtSexoPacient";
            this.txtSexoPacient.ReadOnly = true;
            this.txtSexoPacient.Size = new System.Drawing.Size(125, 30);
            this.txtSexoPacient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sexo:";
            // 
            // txtEdadPacient
            // 
            this.txtEdadPacient.Location = new System.Drawing.Point(373, 32);
            this.txtEdadPacient.Multiline = true;
            this.txtEdadPacient.Name = "txtEdadPacient";
            this.txtEdadPacient.ReadOnly = true;
            this.txtEdadPacient.Size = new System.Drawing.Size(88, 30);
            this.txtEdadPacient.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edad:";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(146, 32);
            this.txtNombrePaciente.Multiline = true;
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.ReadOnly = true;
            this.txtNombrePaciente.Size = new System.Drawing.Size(160, 30);
            this.txtNombrePaciente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Historia de Consultas";
            // 
            // dgvHistoriaClinica
            // 
            this.dgvHistoriaClinica.AllowUserToAddRows = false;
            this.dgvHistoriaClinica.AllowUserToDeleteRows = false;
            this.dgvHistoriaClinica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoriaClinica.AutoGenerateColumns = false;
            this.dgvHistoriaClinica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistoriaClinica.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvHistoriaClinica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistoriaClinica.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvHistoriaClinica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriaClinica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.procesoDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.pagoDataGridViewTextBoxColumn,
            this.pendienteDataGridViewTextBoxColumn,
            this.nombrePacienteDataGridViewTextBoxColumn,
            this.nombreDoctorDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn});
            this.dgvHistoriaClinica.DataSource = this.procesosBindingSource;
            this.dgvHistoriaClinica.Location = new System.Drawing.Point(32, 173);
            this.dgvHistoriaClinica.Name = "dgvHistoriaClinica";
            this.dgvHistoriaClinica.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            this.dgvHistoriaClinica.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistoriaClinica.Size = new System.Drawing.Size(743, 255);
            this.dgvHistoriaClinica.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnImpReport);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvHistoriaClinica);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 466);
            this.panel1.TabIndex = 29;
            // 
            // btnImpReport
            // 
            this.btnImpReport.BackColor = System.Drawing.Color.Green;
            this.btnImpReport.FlatAppearance.BorderSize = 0;
            this.btnImpReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpReport.ForeColor = System.Drawing.Color.White;
            this.btnImpReport.Location = new System.Drawing.Point(623, 144);
            this.btnImpReport.Name = "btnImpReport";
            this.btnImpReport.Size = new System.Drawing.Size(107, 23);
            this.btnImpReport.TabIndex = 29;
            this.btnImpReport.Text = "Imprimir Reporte";
            this.btnImpReport.UseVisualStyleBackColor = false;
            this.btnImpReport.Click += new System.EventHandler(this.btnImpReport_Click);
            // 
            // gRUDENTDataSet
            // 
            this.gRUDENTDataSet.DataSetName = "GRUDENTDataSet";
            this.gRUDENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procesosBindingSource
            // 
            this.procesosBindingSource.DataMember = "Procesos";
            this.procesosBindingSource.DataSource = this.gRUDENTDataSet;
            // 
            // procesosTableAdapter
            // 
            this.procesosTableAdapter.ClearBeforeFill = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 62;
            // 
            // procesoDataGridViewTextBoxColumn
            // 
            this.procesoDataGridViewTextBoxColumn.DataPropertyName = "Proceso";
            this.procesoDataGridViewTextBoxColumn.HeaderText = "Proceso";
            this.procesoDataGridViewTextBoxColumn.Name = "procesoDataGridViewTextBoxColumn";
            this.procesoDataGridViewTextBoxColumn.ReadOnly = true;
            this.procesoDataGridViewTextBoxColumn.Width = 71;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoDataGridViewTextBoxColumn.Width = 59;
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "Pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "Pago";
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            this.pagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagoDataGridViewTextBoxColumn.Width = 57;
            // 
            // pendienteDataGridViewTextBoxColumn
            // 
            this.pendienteDataGridViewTextBoxColumn.DataPropertyName = "Pendiente";
            this.pendienteDataGridViewTextBoxColumn.HeaderText = "Pendiente";
            this.pendienteDataGridViewTextBoxColumn.Name = "pendienteDataGridViewTextBoxColumn";
            this.pendienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.pendienteDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombrePacienteDataGridViewTextBoxColumn
            // 
            this.nombrePacienteDataGridViewTextBoxColumn.DataPropertyName = "NombrePaciente";
            this.nombrePacienteDataGridViewTextBoxColumn.HeaderText = "NombrePaciente";
            this.nombrePacienteDataGridViewTextBoxColumn.Name = "nombrePacienteDataGridViewTextBoxColumn";
            this.nombrePacienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePacienteDataGridViewTextBoxColumn.Width = 111;
            // 
            // nombreDoctorDataGridViewTextBoxColumn
            // 
            this.nombreDoctorDataGridViewTextBoxColumn.DataPropertyName = "NombreDoctor";
            this.nombreDoctorDataGridViewTextBoxColumn.HeaderText = "NombreDoctor";
            this.nombreDoctorDataGridViewTextBoxColumn.Name = "nombreDoctorDataGridViewTextBoxColumn";
            this.nombreDoctorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDoctorDataGridViewTextBoxColumn.Width = 101;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.estatusDataGridViewTextBoxColumn.Width = 67;
            // 
            // HistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoriaClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.HistoriaClinica_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriaClinica)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRUDENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procesosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHistoriaClinica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnImpReport;
        public System.Windows.Forms.TextBox txtNombrePaciente;
        public System.Windows.Forms.TextBox txtEdadPacient;
        public System.Windows.Forms.TextBox txtSexoPacient;
        private GRUDENTDataSet gRUDENTDataSet;
        private System.Windows.Forms.BindingSource procesosBindingSource;
        private GRUDENTDataSetTableAdapters.ProcesosTableAdapter procesosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
    }
}