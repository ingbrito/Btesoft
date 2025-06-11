namespace DentSoft.FormInicio
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelBarra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.bntAcercaDe = new System.Windows.Forms.PictureBox();
            this.BtnFacturacion = new System.Windows.Forms.Button();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnAyuda = new System.Windows.Forms.Button();
            this.BtnConfiguracion = new System.Windows.Forms.Button();
            this.BtnAgenda = new System.Windows.Forms.Button();
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntAcercaDe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBarra.Controls.Add(this.label1);
            this.panelBarra.Controls.Add(this.btnHome);
            this.panelBarra.Controls.Add(this.btnMinimizar);
            this.panelBarra.Controls.Add(this.btnCerrar);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1100, 40);
            this.panelBarra.TabIndex = 2;
            this.panelBarra.DoubleClick += new System.EventHandler(this.PanelBarra_DoubleClick);
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Inicio";
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::DentSoft.Properties.Resources.home_64px;
            this.btnHome.Location = new System.Drawing.Point(12, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(35, 37);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1027, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::DentSoft.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1067, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.xtraUserControl1);
            this.panelContenedor.Controls.Add(this.btnCerrarSesion);
            this.panelContenedor.Controls.Add(this.bntAcercaDe);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 40);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1100, 700);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.Location = new System.Drawing.Point(999, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(70, 13);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.TabStop = true;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnCerrarSesion_LinkClicked);
            // 
            // bntAcercaDe
            // 
            this.bntAcercaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.bntAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAcercaDe.Image = global::DentSoft.Properties.Resources.pregunta__1_2;
            this.bntAcercaDe.Location = new System.Drawing.Point(1075, 2);
            this.bntAcercaDe.Name = "bntAcercaDe";
            this.bntAcercaDe.Size = new System.Drawing.Size(21, 28);
            this.bntAcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntAcercaDe.TabIndex = 14;
            this.bntAcercaDe.TabStop = false;
            this.bntAcercaDe.Click += new System.EventHandler(this.BntAcercaDe_Click);
            // 
            // BtnFacturacion
            // 
            this.BtnFacturacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturacion.FlatAppearance.BorderSize = 0;
            this.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturacion.Image = global::DentSoft.Properties.Resources.Facturas;
            this.BtnFacturacion.Location = new System.Drawing.Point(749, 225);
            this.BtnFacturacion.Name = "BtnFacturacion";
            this.BtnFacturacion.Size = new System.Drawing.Size(157, 122);
            this.BtnFacturacion.TabIndex = 0;
            this.BtnFacturacion.Text = "Facturación";
            this.BtnFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFacturacion.UseVisualStyleBackColor = false;
            this.BtnFacturacion.Click += new System.EventHandler(this.BtnFacturacion_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsultas.FlatAppearance.BorderSize = 0;
            this.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultas.Image = global::DentSoft.Properties.Resources.consultas;
            this.BtnConsultas.Location = new System.Drawing.Point(564, 225);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Size = new System.Drawing.Size(157, 122);
            this.BtnConsultas.TabIndex = 0;
            this.BtnConsultas.Text = "Consultas";
            this.BtnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultas.UseVisualStyleBackColor = false;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.Image = global::DentSoft.Properties.Resources.reports;
            this.BtnReportes.Location = new System.Drawing.Point(379, 225);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(157, 122);
            this.BtnReportes.TabIndex = 0;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAyuda.FlatAppearance.BorderSize = 0;
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyuda.Image = global::DentSoft.Properties.Resources.info;
            this.BtnAyuda.Location = new System.Drawing.Point(749, 402);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(157, 122);
            this.BtnAyuda.TabIndex = 0;
            this.BtnAyuda.Text = "Ayuda";
            this.BtnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAyuda.UseVisualStyleBackColor = false;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracion.Image = global::DentSoft.Properties.Resources.gear;
            this.BtnConfiguracion.Location = new System.Drawing.Point(564, 402);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(157, 122);
            this.BtnConfiguracion.TabIndex = 0;
            this.BtnConfiguracion.Text = "Configuración";
            this.BtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConfiguracion.UseVisualStyleBackColor = false;
            this.BtnConfiguracion.Click += new System.EventHandler(this.BtnConfiguracion_Click);
            // 
            // BtnAgenda
            // 
            this.BtnAgenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgenda.FlatAppearance.BorderSize = 0;
            this.BtnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgenda.Image = global::DentSoft.Properties.Resources.cita_dental;
            this.BtnAgenda.Location = new System.Drawing.Point(379, 402);
            this.BtnAgenda.Name = "BtnAgenda";
            this.BtnAgenda.Size = new System.Drawing.Size(157, 122);
            this.BtnAgenda.TabIndex = 0;
            this.BtnAgenda.Text = "Agenda";
            this.BtnAgenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAgenda.UseVisualStyleBackColor = false;
            this.BtnAgenda.Click += new System.EventHandler(this.BtnAgenda_Click);
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpresa.FlatAppearance.BorderSize = 0;
            this.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpresa.Image = global::DentSoft.Properties.Resources.build;
            this.BtnEmpresa.Location = new System.Drawing.Point(194, 402);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(157, 122);
            this.BtnEmpresa.TabIndex = 0;
            this.BtnEmpresa.Text = "Empresa";
            this.BtnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEmpresa.UseVisualStyleBackColor = false;
            this.BtnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistros.FlatAppearance.BorderSize = 0;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.Image = global::DentSoft.Properties.Resources.add;
            this.btnRegistros.Location = new System.Drawing.Point(194, 225);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(157, 122);
            this.btnRegistros.TabIndex = 0;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistros.UseVisualStyleBackColor = false;
            this.btnRegistros.Click += new System.EventHandler(this.BtnRegistros_Click);
            // 
            // xtraUserControl1
            // 
            this.xtraUserControl1.Location = new System.Drawing.Point(598, 185);
            this.xtraUserControl1.Name = "xtraUserControl1";
            this.xtraUserControl1.Size = new System.Drawing.Size(150, 150);
            this.xtraUserControl1.TabIndex = 16;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 740);
            this.Controls.Add(this.BtnFacturacion);
            this.Controls.Add(this.BtnConsultas);
            this.Controls.Add(this.BtnReportes);
            this.Controls.Add(this.BtnAyuda);
            this.Controls.Add(this.BtnConfiguracion);
            this.Controls.Add(this.BtnAgenda);
            this.Controls.Add(this.BtnEmpresa);
            this.Controls.Add(this.btnRegistros);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntAcercaDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Button BtnFacturacion;
        private System.Windows.Forms.Button BtnEmpresa;
        private System.Windows.Forms.Button BtnAgenda;
        private System.Windows.Forms.Button BtnConfiguracion;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bntAcercaDe;
        private System.Windows.Forms.LinkLabel btnCerrarSesion;
        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
    }
}