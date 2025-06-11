namespace DentSoft.Formularios_de_Consulta
{
    partial class HistorialPaciente
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
            this.dgvHistorialP = new System.Windows.Forms.DataGridView();
            this.Historico = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Procedimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorialP
            // 
            this.dgvHistorialP.AllowUserToAddRows = false;
            this.dgvHistorialP.AllowUserToDeleteRows = false;
            this.dgvHistorialP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorialP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHistorialP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Historico,
            this.ID,
            this.Documento,
            this.Nombres,
            this.PrimerApellido,
            this.Sexo,
            this.Telefono,
            this.Direccion,
            this.Fecha,
            this.NombreDoctor,
            this.Motivo,
            this.Observaciones,
            this.Diagnostico,
            this.Procedimiento,
            this.Indicaciones});
            this.dgvHistorialP.Location = new System.Drawing.Point(26, 110);
            this.dgvHistorialP.Name = "dgvHistorialP";
            this.dgvHistorialP.ReadOnly = true;
            this.dgvHistorialP.Size = new System.Drawing.Size(932, 347);
            this.dgvHistorialP.TabIndex = 1;
            // 
            // Historico
            // 
            this.Historico.DataPropertyName = "Historico";
            this.Historico.HeaderText = "Historico";
            this.Historico.Image = global::DentSoft.Properties.Resources.report;
            this.Historico.Name = "Historico";
            this.Historico.ReadOnly = true;
            this.Historico.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Historico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Historico.Width = 73;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento de identidad";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 96;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Paciente";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 74;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "FechaDeNacimiento";
            this.PrimerApellido.HeaderText = "Fecha Nacimiento";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            this.PrimerApellido.Width = 108;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 56;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 74;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 77;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha De Consulta";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 113;
            // 
            // NombreDoctor
            // 
            this.NombreDoctor.DataPropertyName = "NombreDoctor";
            this.NombreDoctor.HeaderText = "Doctor";
            this.NombreDoctor.Name = "NombreDoctor";
            this.NombreDoctor.ReadOnly = true;
            this.NombreDoctor.Width = 64;
            // 
            // Motivo
            // 
            this.Motivo.DataPropertyName = "Motivo";
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.ReadOnly = true;
            this.Motivo.Width = 64;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 103;
            // 
            // Diagnostico
            // 
            this.Diagnostico.DataPropertyName = "Diagnostico";
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            this.Diagnostico.Width = 88;
            // 
            // Procedimiento
            // 
            this.Procedimiento.DataPropertyName = "Procedimiento";
            this.Procedimiento.HeaderText = "Procedimientos";
            this.Procedimiento.Name = "Procedimiento";
            this.Procedimiento.ReadOnly = true;
            this.Procedimiento.Width = 104;
            // 
            // Indicaciones
            // 
            this.Indicaciones.DataPropertyName = "Indicaciones";
            this.Indicaciones.HeaderText = "Indicaciones";
            this.Indicaciones.Name = "Indicaciones";
            this.Indicaciones.ReadOnly = true;
            this.Indicaciones.Width = 92;
            // 
            // HistorialPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 567);
            this.Controls.Add(this.dgvHistorialP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialPaciente";
            this.Text = "HistorialPaciente";
            this.Load += new System.EventHandler(this.HistorialPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorialP;
        private System.Windows.Forms.DataGridViewImageColumn Historico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procedimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicaciones;
    }
}