namespace DentSoft.Formularios_de_Consulta
{
    partial class ListadoPacientesNinos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbcampo = new System.Windows.Forms.ComboBox();
            this.dgvPacienteN = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Factura = new System.Windows.Forms.DataGridViewImageColumn();
            this.Historico = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupoSanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TutorCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFemenino = new System.Windows.Forms.Label();
            this.lblMasculino = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbk = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(24, 147);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(148, 41);
            this.btnGenerarReporte.TabIndex = 15;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtbusqueda);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.cmbcampo);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox6.Location = new System.Drawing.Point(24, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(932, 122);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Listado de Niños";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbusqueda.Location = new System.Drawing.Point(271, 72);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(655, 31);
            this.txtbusqueda.TabIndex = 17;
            this.txtbusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbusqueda_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkBlue;
            this.label15.Location = new System.Drawing.Point(12, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Tipo de búsqueda";
            // 
            // cmbcampo
            // 
            this.cmbcampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcampo.FormattingEnabled = true;
            this.cmbcampo.Items.AddRange(new object[] {
            "Documento",
            "Nombres",
            "Primer Apellido",
            "Segundo Apellido",
            "Sexo",
            "Fecha De Nacimiento",
            "Estado Civil",
            "Grupo Sanguineo",
            "ARS",
            "NSS",
            "Correo Electronico",
            "Telefono",
            "Celular",
            "Direccion",
            "Tutor"});
            this.cmbcampo.Location = new System.Drawing.Point(16, 72);
            this.cmbcampo.Name = "cmbcampo";
            this.cmbcampo.Size = new System.Drawing.Size(234, 28);
            this.cmbcampo.TabIndex = 16;
            // 
            // dgvPacienteN
            // 
            this.dgvPacienteN.AllowUserToAddRows = false;
            this.dgvPacienteN.AllowUserToDeleteRows = false;
            this.dgvPacienteN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacienteN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacienteN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacienteN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienteN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Factura,
            this.Historico,
            this.ID,
            this.Documento,
            this.Nombres,
            this.PrimerApellido,
            this.SegundoApellido,
            this.Sexo,
            this.FechaDeNacimiento,
            this.EstadoCivil,
            this.GrupoSanguineo,
            this.ARS,
            this.NSS,
            this.CorreoElectronico,
            this.Telefono,
            this.Celular,
            this.Direccion,
            this.TutorNombre,
            this.TutorTelefono,
            this.TutorCedula,
            this.Foto});
            this.dgvPacienteN.Location = new System.Drawing.Point(24, 234);
            this.dgvPacienteN.Name = "dgvPacienteN";
            this.dgvPacienteN.ReadOnly = true;
            this.dgvPacienteN.Size = new System.Drawing.Size(932, 374);
            this.dgvPacienteN.TabIndex = 13;
            this.dgvPacienteN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacienteN_CellClick);
            this.dgvPacienteN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaciente_CellContentClick);
            this.dgvPacienteN.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaciente_CellContentDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar.FillWeight = 203.0457F;
            this.Eliminar.HeaderText = "*";
            this.Eliminar.Image = global::DentSoft.Properties.Resources.clear__1_;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 25;
            // 
            // Factura
            // 
            this.Factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Factura.FillWeight = 94.57655F;
            this.Factura.HeaderText = "*";
            this.Factura.Image = global::DentSoft.Properties.Resources.Factura;
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            this.Factura.Width = 25;
            // 
            // Historico
            // 
            this.Historico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Historico.FillWeight = 94.57655F;
            this.Historico.HeaderText = "*";
            this.Historico.Image = global::DentSoft.Properties.Resources.buscar;
            this.Historico.Name = "Historico";
            this.Historico.ReadOnly = true;
            this.Historico.Width = 25;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.FillWeight = 94.57655F;
            this.Documento.HeaderText = "Cédula ";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 68;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.FillWeight = 94.57655F;
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 74;
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.DataPropertyName = "PrimerApellido";
            this.PrimerApellido.FillWeight = 94.57655F;
            this.PrimerApellido.HeaderText = "P. Apellido";
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.ReadOnly = true;
            this.PrimerApellido.Width = 82;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.DataPropertyName = "SegundoApellido";
            this.SegundoApellido.FillWeight = 94.57655F;
            this.SegundoApellido.HeaderText = "S. Apellido";
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.ReadOnly = true;
            this.SegundoApellido.Width = 82;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.FillWeight = 94.57655F;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 56;
            // 
            // FechaDeNacimiento
            // 
            this.FechaDeNacimiento.DataPropertyName = "FechaDeNacimiento";
            this.FechaDeNacimiento.FillWeight = 94.57655F;
            this.FechaDeNacimiento.HeaderText = "Nacimiento";
            this.FechaDeNacimiento.Name = "FechaDeNacimiento";
            this.FechaDeNacimiento.ReadOnly = true;
            this.FechaDeNacimiento.Width = 85;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.DataPropertyName = "EstadoCivil";
            this.EstadoCivil.FillWeight = 94.57655F;
            this.EstadoCivil.HeaderText = "Est. Civil";
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            this.EstadoCivil.Width = 72;
            // 
            // GrupoSanguineo
            // 
            this.GrupoSanguineo.DataPropertyName = "GrupoSanguineo";
            this.GrupoSanguineo.FillWeight = 94.57655F;
            this.GrupoSanguineo.HeaderText = "G. Sanguineo";
            this.GrupoSanguineo.Name = "GrupoSanguineo";
            this.GrupoSanguineo.ReadOnly = true;
            this.GrupoSanguineo.Width = 97;
            // 
            // ARS
            // 
            this.ARS.DataPropertyName = "ARS";
            this.ARS.FillWeight = 94.57655F;
            this.ARS.HeaderText = "ARS";
            this.ARS.Name = "ARS";
            this.ARS.ReadOnly = true;
            this.ARS.Width = 54;
            // 
            // NSS
            // 
            this.NSS.DataPropertyName = "NSS";
            this.NSS.FillWeight = 94.57655F;
            this.NSS.HeaderText = "NSS";
            this.NSS.Name = "NSS";
            this.NSS.ReadOnly = true;
            this.NSS.Width = 54;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.DataPropertyName = "CorreoElectronico";
            this.CorreoElectronico.FillWeight = 94.57655F;
            this.CorreoElectronico.HeaderText = "Correo";
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.ReadOnly = true;
            this.CorreoElectronico.Width = 63;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.FillWeight = 94.57655F;
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 74;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.FillWeight = 94.57655F;
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 64;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.FillWeight = 94.57655F;
            this.Direccion.HeaderText = "Dirección ";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 80;
            // 
            // TutorNombre
            // 
            this.TutorNombre.DataPropertyName = "TutorNombre";
            this.TutorNombre.FillWeight = 94.57655F;
            this.TutorNombre.HeaderText = "Tutor";
            this.TutorNombre.Name = "TutorNombre";
            this.TutorNombre.ReadOnly = true;
            this.TutorNombre.Width = 57;
            // 
            // TutorTelefono
            // 
            this.TutorTelefono.DataPropertyName = "TutorTelefono";
            this.TutorTelefono.FillWeight = 94.57655F;
            this.TutorTelefono.HeaderText = "T. Teléfono";
            this.TutorTelefono.Name = "TutorTelefono";
            this.TutorTelefono.ReadOnly = true;
            this.TutorTelefono.Width = 87;
            // 
            // TutorCedula
            // 
            this.TutorCedula.DataPropertyName = "TutorCedula";
            this.TutorCedula.FillWeight = 94.57655F;
            this.TutorCedula.HeaderText = "T. Cédula ";
            this.TutorCedula.Name = "TutorCedula";
            this.TutorCedula.ReadOnly = true;
            this.TutorCedula.Width = 81;
            // 
            // Foto
            // 
            this.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Visible = false;
            // 
            // lblFemenino
            // 
            this.lblFemenino.AutoSize = true;
            this.lblFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFemenino.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFemenino.Location = new System.Drawing.Point(368, 168);
            this.lblFemenino.Name = "lblFemenino";
            this.lblFemenino.Size = new System.Drawing.Size(18, 20);
            this.lblFemenino.TabIndex = 16;
            this.lblFemenino.Text = "0";
            // 
            // lblMasculino
            // 
            this.lblMasculino.AutoSize = true;
            this.lblMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMasculino.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMasculino.Location = new System.Drawing.Point(579, 168);
            this.lblMasculino.Name = "lblMasculino";
            this.lblMasculino.Size = new System.Drawing.Size(18, 20);
            this.lblMasculino.TabIndex = 17;
            this.lblMasculino.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl.Location = new System.Drawing.Point(425, 168);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(148, 20);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Cantidad Masculino";
            // 
            // lbk
            // 
            this.lbk.AutoSize = true;
            this.lbk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbk.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbk.Location = new System.Drawing.Point(214, 168);
            this.lbk.Name = "lbk";
            this.lbk.Size = new System.Drawing.Size(148, 20);
            this.lbk.TabIndex = 19;
            this.lbk.Text = "Cantidad Femenino";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(20, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(434, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Para Actualizar los datos, dar doble click en cualquier campo";
            // 
            // ListadoPacientesNinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 620);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblFemenino);
            this.Controls.Add(this.lblMasculino);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbk);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dgvPacienteN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoPacientesNinos";
            this.Text = "ListadoPacientesNinos";
            this.Load += new System.EventHandler(this.ListadoPacientesNinos_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbcampo;
        private System.Windows.Forms.DataGridView dgvPacienteN;
        private System.Windows.Forms.Label lblFemenino;
        private System.Windows.Forms.Label lblMasculino;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbk;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Factura;
        private System.Windows.Forms.DataGridViewImageColumn Historico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupoSanguineo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn TutorCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
        private System.Windows.Forms.Label label19;
    }
}