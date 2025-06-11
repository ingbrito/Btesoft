namespace DentSoft.Formularios_de_Registro
{
    partial class FrmMenuConsulta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListadoConsult = new System.Windows.Forms.PictureBox();
            this.btnConsult = new System.Windows.Forms.PictureBox();
            this.panelContC = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnListadoConsult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 131);
            this.panel1.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.btnListadoConsult);
            this.groupBox7.Controls.Add(this.btnConsult);
            this.groupBox7.Location = new System.Drawing.Point(40, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1020, 123);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(535, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Listado Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(349, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Realizar Consulta";
            // 
            // btnListadoConsult
            // 
            this.btnListadoConsult.Image = global::DentSoft.Properties.Resources.checking;
            this.btnListadoConsult.Location = new System.Drawing.Point(571, 19);
            this.btnListadoConsult.Name = "btnListadoConsult";
            this.btnListadoConsult.Size = new System.Drawing.Size(64, 64);
            this.btnListadoConsult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnListadoConsult.TabIndex = 0;
            this.btnListadoConsult.TabStop = false;
            this.btnListadoConsult.Click += new System.EventHandler(this.btnListadoConsult_Click);
            // 
            // btnConsult
            // 
            this.btnConsult.Image = global::DentSoft.Properties.Resources.Muela;
            this.btnConsult.Location = new System.Drawing.Point(384, 19);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(64, 64);
            this.btnConsult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnConsult.TabIndex = 0;
            this.btnConsult.TabStop = false;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // panelContC
            // 
            this.panelContC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContC.Location = new System.Drawing.Point(0, 131);
            this.panelContC.Name = "panelContC";
            this.panelContC.Size = new System.Drawing.Size(1100, 618);
            this.panelContC.TabIndex = 3;
            // 
            // FrmMenuConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 749);
            this.Controls.Add(this.panelContC);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuConsulta";
            this.Text = "FrmMenuConsulta";
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnListadoConsult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnListadoConsult;
        private System.Windows.Forms.PictureBox btnConsult;
        private System.Windows.Forms.Panel panelContC;
    }
}