namespace DentSoft.FormInicio
{
    partial class FrmMainContent
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.LinkLabel();
            this.bntAcercaDe = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntAcercaDe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.lblRol);
            this.panelContenedor.Controls.Add(this.lblBienvenida);
            this.panelContenedor.Controls.Add(this.btnCerrarSesion);
            this.panelContenedor.Controls.Add(this.bntAcercaDe);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1100, 709);
            this.panelContenedor.TabIndex = 9;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.Location = new System.Drawing.Point(999, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(70, 13);
            this.btnCerrarSesion.TabIndex = 16;
            this.btnCerrarSesion.TabStop = true;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.Visible = false;
            // 
            // bntAcercaDe
            // 
            this.bntAcercaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.bntAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAcercaDe.Image = global::DentSoft.Properties.Resources.pregunta__1_2;
            this.bntAcercaDe.Location = new System.Drawing.Point(1075, 1);
            this.bntAcercaDe.Name = "bntAcercaDe";
            this.bntAcercaDe.Size = new System.Drawing.Size(21, 28);
            this.bntAcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntAcercaDe.TabIndex = 14;
            this.bntAcercaDe.TabStop = false;
            this.bntAcercaDe.Click += new System.EventHandler(this.bntAcercaDe_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(195, 158);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(17, 13);
            this.lblBienvenida.TabIndex = 17;
            this.lblBienvenida.Text = "lbl";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(195, 191);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(17, 13);
            this.lblRol.TabIndex = 18;
            this.lblRol.Text = "lbl";
            // 
            // FrmMainContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 709);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainContent";
            this.Text = "FrmMainContent";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bntAcercaDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox bntAcercaDe;
        private System.Windows.Forms.LinkLabel btnCerrarSesion;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblRol;
    }
}