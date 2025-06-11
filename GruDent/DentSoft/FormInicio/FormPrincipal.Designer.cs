namespace DentSoft
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubMenuUsers = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelSubMenuHelp = new System.Windows.Forms.Panel();
            this.btnVerAyuda = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelSubMenConsult = new System.Windows.Forms.Panel();
            this.btnListadoConsult = new System.Windows.Forms.Button();
            this.btnVerConsult = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.panelSubMenuReportes = new System.Windows.Forms.Panel();
            this.btnListadoFacturas = new System.Windows.Forms.Button();
            this.btnNinosReportes = new System.Windows.Forms.Button();
            this.btnLPacReportes = new System.Windows.Forms.Button();
            this.btnDocReportes = new System.Windows.Forms.Button();
            this.btnDiagReportes = new System.Windows.Forms.Button();
            this.btnProceReportes = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panelSubMenuRegistro = new System.Windows.Forms.Panel();
            this.btnDiagnosticos = new System.Windows.Forms.Button();
            this.btnProcedimientos = new System.Windows.Forms.Button();
            this.btnDoctores = new System.Windows.Forms.Button();
            this.btnPacienteNinos = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelHora = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panelContenedorForm = new System.Windows.Forms.Panel();
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.btnHistorialConsulta = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMenuUsers.SuspendLayout();
            this.panelSubMenuHelp.SuspendLayout();
            this.panelSubMenConsult.SuspendLayout();
            this.panelSubMenuReportes.SuspendLayout();
            this.panelSubMenuRegistro.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.panelSideMenu.Controls.Add(this.panelSubMenuUsers);
            this.panelSideMenu.Controls.Add(this.btnUsers);
            this.panelSideMenu.Controls.Add(this.panelSubMenuHelp);
            this.panelSideMenu.Controls.Add(this.btnHelp);
            this.panelSideMenu.Controls.Add(this.panelSubMenConsult);
            this.panelSideMenu.Controls.Add(this.btnConsultas);
            this.panelSideMenu.Controls.Add(this.panelSubMenuReportes);
            this.panelSideMenu.Controls.Add(this.btnReportes);
            this.panelSideMenu.Controls.Add(this.panelSubMenuRegistro);
            this.panelSideMenu.Controls.Add(this.btnRegistro);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 749);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSubMenuUsers
            // 
            this.panelSubMenuUsers.BackColor = System.Drawing.Color.White;
            this.panelSubMenuUsers.Controls.Add(this.btnSalir);
            this.panelSubMenuUsers.Controls.Add(this.btnCerrarSesion);
            this.panelSubMenuUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuUsers.Location = new System.Drawing.Point(0, 930);
            this.panelSubMenuUsers.Name = "panelSubMenuUsers";
            this.panelSubMenuUsers.Size = new System.Drawing.Size(183, 85);
            this.panelSubMenuUsers.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(0, 40);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(183, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = global::DentSoft.Properties.Resources.logout1;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(183, 40);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Image = global::DentSoft.Properties.Resources.login1;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 890);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(183, 40);
            this.btnUsers.TabIndex = 9;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // panelSubMenuHelp
            // 
            this.panelSubMenuHelp.BackColor = System.Drawing.Color.White;
            this.panelSubMenuHelp.Controls.Add(this.btnVerAyuda);
            this.panelSubMenuHelp.Controls.Add(this.btnAcercaDe);
            this.panelSubMenuHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuHelp.Location = new System.Drawing.Point(0, 805);
            this.panelSubMenuHelp.Name = "panelSubMenuHelp";
            this.panelSubMenuHelp.Size = new System.Drawing.Size(183, 85);
            this.panelSubMenuHelp.TabIndex = 8;
            // 
            // btnVerAyuda
            // 
            this.btnVerAyuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerAyuda.FlatAppearance.BorderSize = 0;
            this.btnVerAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerAyuda.Location = new System.Drawing.Point(0, 40);
            this.btnVerAyuda.Name = "btnVerAyuda";
            this.btnVerAyuda.Size = new System.Drawing.Size(183, 40);
            this.btnVerAyuda.TabIndex = 1;
            this.btnVerAyuda.Text = "Ver Ayuda";
            this.btnVerAyuda.UseVisualStyleBackColor = true;
            this.btnVerAyuda.Click += new System.EventHandler(this.btnVerAyuda_Click_1);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 0);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(183, 40);
            this.btnAcercaDe.TabIndex = 2;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click_1);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::DentSoft.Properties.Resources.pregunta__1_1;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 765);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(183, 40);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Ayuda";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelSubMenConsult
            // 
            this.panelSubMenConsult.BackColor = System.Drawing.Color.White;
            this.panelSubMenConsult.Controls.Add(this.btnListadoConsult);
            this.panelSubMenConsult.Controls.Add(this.btnVerConsult);
            this.panelSubMenConsult.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenConsult.Location = new System.Drawing.Point(0, 671);
            this.panelSubMenConsult.Name = "panelSubMenConsult";
            this.panelSubMenConsult.Size = new System.Drawing.Size(183, 94);
            this.panelSubMenConsult.TabIndex = 6;
            // 
            // btnListadoConsult
            // 
            this.btnListadoConsult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoConsult.FlatAppearance.BorderSize = 0;
            this.btnListadoConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoConsult.Image = global::DentSoft.Properties.Resources.lista;
            this.btnListadoConsult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoConsult.Location = new System.Drawing.Point(0, 40);
            this.btnListadoConsult.Name = "btnListadoConsult";
            this.btnListadoConsult.Size = new System.Drawing.Size(183, 40);
            this.btnListadoConsult.TabIndex = 2;
            this.btnListadoConsult.Text = "Consultas";
            this.btnListadoConsult.UseVisualStyleBackColor = true;
            this.btnListadoConsult.Click += new System.EventHandler(this.btnListadoConsult_Click);
            // 
            // btnVerConsult
            // 
            this.btnVerConsult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerConsult.FlatAppearance.BorderSize = 0;
            this.btnVerConsult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerConsult.Image = global::DentSoft.Properties.Resources.tooth__3_;
            this.btnVerConsult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerConsult.Location = new System.Drawing.Point(0, 0);
            this.btnVerConsult.Name = "btnVerConsult";
            this.btnVerConsult.Size = new System.Drawing.Size(183, 40);
            this.btnVerConsult.TabIndex = 2;
            this.btnVerConsult.Text = "   Realizar Consulta";
            this.btnVerConsult.UseVisualStyleBackColor = true;
            this.btnVerConsult.Click += new System.EventHandler(this.btnVerConsult_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Image = global::DentSoft.Properties.Resources.list;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(0, 631);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(183, 40);
            this.btnConsultas.TabIndex = 5;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // panelSubMenuReportes
            // 
            this.panelSubMenuReportes.BackColor = System.Drawing.Color.White;
            this.panelSubMenuReportes.Controls.Add(this.btnHistorialConsulta);
            this.panelSubMenuReportes.Controls.Add(this.btnListadoFacturas);
            this.panelSubMenuReportes.Controls.Add(this.btnNinosReportes);
            this.panelSubMenuReportes.Controls.Add(this.btnLPacReportes);
            this.panelSubMenuReportes.Controls.Add(this.btnDocReportes);
            this.panelSubMenuReportes.Controls.Add(this.btnDiagReportes);
            this.panelSubMenuReportes.Controls.Add(this.btnProceReportes);
            this.panelSubMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuReportes.Location = new System.Drawing.Point(0, 351);
            this.panelSubMenuReportes.Name = "panelSubMenuReportes";
            this.panelSubMenuReportes.Size = new System.Drawing.Size(183, 280);
            this.panelSubMenuReportes.TabIndex = 4;
            // 
            // btnListadoFacturas
            // 
            this.btnListadoFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoFacturas.FlatAppearance.BorderSize = 0;
            this.btnListadoFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoFacturas.Image = global::DentSoft.Properties.Resources.Factura1;
            this.btnListadoFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoFacturas.Location = new System.Drawing.Point(0, 200);
            this.btnListadoFacturas.Name = "btnListadoFacturas";
            this.btnListadoFacturas.Size = new System.Drawing.Size(183, 40);
            this.btnListadoFacturas.TabIndex = 6;
            this.btnListadoFacturas.Text = "Facturas";
            this.btnListadoFacturas.UseVisualStyleBackColor = true;
            this.btnListadoFacturas.Click += new System.EventHandler(this.btnListadoFacturas_Click);
            // 
            // btnNinosReportes
            // 
            this.btnNinosReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNinosReportes.FlatAppearance.BorderSize = 0;
            this.btnNinosReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNinosReportes.Image = global::DentSoft.Properties.Resources.historial_dental;
            this.btnNinosReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNinosReportes.Location = new System.Drawing.Point(0, 160);
            this.btnNinosReportes.Name = "btnNinosReportes";
            this.btnNinosReportes.Size = new System.Drawing.Size(183, 40);
            this.btnNinosReportes.TabIndex = 5;
            this.btnNinosReportes.Text = "Niños";
            this.btnNinosReportes.UseVisualStyleBackColor = true;
            this.btnNinosReportes.Click += new System.EventHandler(this.btnNinosReportes_Click);
            // 
            // btnLPacReportes
            // 
            this.btnLPacReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLPacReportes.FlatAppearance.BorderSize = 0;
            this.btnLPacReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLPacReportes.Image = global::DentSoft.Properties.Resources.dental_record__1_;
            this.btnLPacReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLPacReportes.Location = new System.Drawing.Point(0, 120);
            this.btnLPacReportes.Name = "btnLPacReportes";
            this.btnLPacReportes.Size = new System.Drawing.Size(183, 40);
            this.btnLPacReportes.TabIndex = 1;
            this.btnLPacReportes.Text = "Pacientes";
            this.btnLPacReportes.UseVisualStyleBackColor = true;
            this.btnLPacReportes.Click += new System.EventHandler(this.btnLPacReportes_Click);
            // 
            // btnDocReportes
            // 
            this.btnDocReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocReportes.FlatAppearance.BorderSize = 0;
            this.btnDocReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocReportes.Image = global::DentSoft.Properties.Resources.doctor__2_1;
            this.btnDocReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocReportes.Location = new System.Drawing.Point(0, 80);
            this.btnDocReportes.Name = "btnDocReportes";
            this.btnDocReportes.Size = new System.Drawing.Size(183, 40);
            this.btnDocReportes.TabIndex = 2;
            this.btnDocReportes.Text = "Doctores";
            this.btnDocReportes.UseVisualStyleBackColor = true;
            this.btnDocReportes.Click += new System.EventHandler(this.btnDocReportes_Click);
            // 
            // btnDiagReportes
            // 
            this.btnDiagReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiagReportes.FlatAppearance.BorderSize = 0;
            this.btnDiagReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagReportes.Image = global::DentSoft.Properties.Resources.historial_medico;
            this.btnDiagReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagReportes.Location = new System.Drawing.Point(0, 40);
            this.btnDiagReportes.Name = "btnDiagReportes";
            this.btnDiagReportes.Size = new System.Drawing.Size(183, 40);
            this.btnDiagReportes.TabIndex = 3;
            this.btnDiagReportes.Text = "Diagnosticos";
            this.btnDiagReportes.UseVisualStyleBackColor = true;
            this.btnDiagReportes.Click += new System.EventHandler(this.btnDiagReportes_Click);
            // 
            // btnProceReportes
            // 
            this.btnProceReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProceReportes.FlatAppearance.BorderSize = 0;
            this.btnProceReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceReportes.Image = global::DentSoft.Properties.Resources.mejora;
            this.btnProceReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProceReportes.Location = new System.Drawing.Point(0, 0);
            this.btnProceReportes.Name = "btnProceReportes";
            this.btnProceReportes.Size = new System.Drawing.Size(183, 40);
            this.btnProceReportes.TabIndex = 4;
            this.btnProceReportes.Text = "Procedimientos";
            this.btnProceReportes.UseVisualStyleBackColor = true;
            this.btnProceReportes.Click += new System.EventHandler(this.btnProceReportes_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Image = global::DentSoft.Properties.Resources.medical_report1;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 311);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(183, 40);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panelSubMenuRegistro
            // 
            this.panelSubMenuRegistro.BackColor = System.Drawing.Color.White;
            this.panelSubMenuRegistro.Controls.Add(this.btnDiagnosticos);
            this.panelSubMenuRegistro.Controls.Add(this.btnProcedimientos);
            this.panelSubMenuRegistro.Controls.Add(this.btnDoctores);
            this.panelSubMenuRegistro.Controls.Add(this.btnPacienteNinos);
            this.panelSubMenuRegistro.Controls.Add(this.btnPacientes);
            this.panelSubMenuRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuRegistro.Location = new System.Drawing.Point(0, 106);
            this.panelSubMenuRegistro.Name = "panelSubMenuRegistro";
            this.panelSubMenuRegistro.Size = new System.Drawing.Size(183, 205);
            this.panelSubMenuRegistro.TabIndex = 2;
            // 
            // btnDiagnosticos
            // 
            this.btnDiagnosticos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiagnosticos.FlatAppearance.BorderSize = 0;
            this.btnDiagnosticos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiagnosticos.Image = global::DentSoft.Properties.Resources.historial_medico;
            this.btnDiagnosticos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiagnosticos.Location = new System.Drawing.Point(0, 160);
            this.btnDiagnosticos.Name = "btnDiagnosticos";
            this.btnDiagnosticos.Size = new System.Drawing.Size(183, 40);
            this.btnDiagnosticos.TabIndex = 5;
            this.btnDiagnosticos.Text = " Diagnosticos";
            this.btnDiagnosticos.UseVisualStyleBackColor = true;
            this.btnDiagnosticos.Click += new System.EventHandler(this.btnDiagnostico_Click);
            // 
            // btnProcedimientos
            // 
            this.btnProcedimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcedimientos.FlatAppearance.BorderSize = 0;
            this.btnProcedimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcedimientos.Image = global::DentSoft.Properties.Resources.mejora;
            this.btnProcedimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcedimientos.Location = new System.Drawing.Point(0, 120);
            this.btnProcedimientos.Name = "btnProcedimientos";
            this.btnProcedimientos.Size = new System.Drawing.Size(183, 40);
            this.btnProcedimientos.TabIndex = 1;
            this.btnProcedimientos.Text = " Procedimientos";
            this.btnProcedimientos.UseVisualStyleBackColor = true;
            this.btnProcedimientos.Click += new System.EventHandler(this.btnProcedimientos_Click);
            // 
            // btnDoctores
            // 
            this.btnDoctores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctores.FlatAppearance.BorderSize = 0;
            this.btnDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctores.Image = global::DentSoft.Properties.Resources.doctor__2_;
            this.btnDoctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctores.Location = new System.Drawing.Point(0, 80);
            this.btnDoctores.Name = "btnDoctores";
            this.btnDoctores.Size = new System.Drawing.Size(183, 40);
            this.btnDoctores.TabIndex = 2;
            this.btnDoctores.Text = "Doctores";
            this.btnDoctores.UseVisualStyleBackColor = true;
            this.btnDoctores.Click += new System.EventHandler(this.btnDoctores_Click);
            // 
            // btnPacienteNinos
            // 
            this.btnPacienteNinos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacienteNinos.FlatAppearance.BorderSize = 0;
            this.btnPacienteNinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacienteNinos.Image = global::DentSoft.Properties.Resources.children;
            this.btnPacienteNinos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacienteNinos.Location = new System.Drawing.Point(0, 40);
            this.btnPacienteNinos.Name = "btnPacienteNinos";
            this.btnPacienteNinos.Size = new System.Drawing.Size(183, 40);
            this.btnPacienteNinos.TabIndex = 3;
            this.btnPacienteNinos.Text = "      Pacientes Niños";
            this.btnPacienteNinos.UseVisualStyleBackColor = true;
            this.btnPacienteNinos.Click += new System.EventHandler(this.btnPacienteNinos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Image = global::DentSoft.Properties.Resources.hombre__1_;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(0, 0);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(183, 40);
            this.btnPacientes.TabIndex = 4;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Image = global::DentSoft.Properties.Resources.jefe__1_;
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(0, 66);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(183, 40);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registros";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLogo.Controls.Add(this.label3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(183, 66);
            this.panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Menu Principal";
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBarra.Controls.Add(this.btnMinimizar);
            this.panelBarra.Controls.Add(this.btnCerrar);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(200, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(900, 66);
            this.panelBarra.TabIndex = 1;
            this.panelBarra.DoubleClick += new System.EventHandler(this.panelBarra_DoubleClick);
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(821, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(861, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelHora
            // 
            this.panelHora.Controls.Add(this.label2);
            this.panelHora.Controls.Add(this.label1);
            this.panelHora.Controls.Add(this.lbFecha);
            this.panelHora.Controls.Add(this.lblHora);
            this.panelHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHora.Location = new System.Drawing.Point(200, 649);
            this.panelHora.Name = "panelHora";
            this.panelHora.Size = new System.Drawing.Size(900, 100);
            this.panelHora.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "@Posicion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(112, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "@Nombre";
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.Location = new System.Drawing.Point(635, 69);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(224, 20);
            this.lbFecha.TabIndex = 11;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(642, 15);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 10;
            this.lblHora.Text = "21:49:45";
            // 
            // panelContenedorForm
            // 
            this.panelContenedorForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorForm.Location = new System.Drawing.Point(200, 66);
            this.panelContenedorForm.Name = "panelContenedorForm";
            this.panelContenedorForm.Size = new System.Drawing.Size(900, 583);
            this.panelContenedorForm.TabIndex = 7;
            this.panelContenedorForm.Click += new System.EventHandler(this.btnDoctores_Click);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick_1);
            // 
            // btnHistorialConsulta
            // 
            this.btnHistorialConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorialConsulta.FlatAppearance.BorderSize = 0;
            this.btnHistorialConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialConsulta.Image = global::DentSoft.Properties.Resources.Factura1;
            this.btnHistorialConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialConsulta.Location = new System.Drawing.Point(0, 240);
            this.btnHistorialConsulta.Name = "btnHistorialConsulta";
            this.btnHistorialConsulta.Size = new System.Drawing.Size(183, 40);
            this.btnHistorialConsulta.TabIndex = 7;
            this.btnHistorialConsulta.Text = "Historial Consulta";
            this.btnHistorialConsulta.UseVisualStyleBackColor = true;
            this.btnHistorialConsulta.Click += new System.EventHandler(this.btnHistorialConsulta_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 749);
            this.Controls.Add(this.panelContenedorForm);
            this.Controls.Add(this.panelHora);
            this.Controls.Add(this.panelBarra);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 660);
            this.Name = "FormPrincipal";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMenuUsers.ResumeLayout(false);
            this.panelSubMenuHelp.ResumeLayout(false);
            this.panelSubMenConsult.ResumeLayout(false);
            this.panelSubMenuReportes.ResumeLayout(false);
            this.panelSubMenuRegistro.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelHora.ResumeLayout(false);
            this.panelHora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelSubMenuRegistro;
        private System.Windows.Forms.Button btnProcedimientos;
        private System.Windows.Forms.Button btnDoctores;
        private System.Windows.Forms.Button btnPacienteNinos;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panelSubMenuReportes;
        private System.Windows.Forms.Button btnLPacReportes;
        private System.Windows.Forms.Button btnDocReportes;
        private System.Windows.Forms.Button btnDiagReportes;
        private System.Windows.Forms.Button btnProceReportes;
        private System.Windows.Forms.Panel panelSubMenConsult;
        private System.Windows.Forms.Button btnListadoConsult;
        private System.Windows.Forms.Button btnVerConsult;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panelContenedorForm;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiagnosticos;
        private System.Windows.Forms.Button btnNinosReportes;
        private System.Windows.Forms.Button btnListadoFacturas;
        private System.Windows.Forms.Panel panelSubMenuUsers;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel panelSubMenuHelp;
        private System.Windows.Forms.Button btnVerAyuda;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnHistorialConsulta;
    }
}

