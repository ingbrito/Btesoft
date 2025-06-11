namespace DentSoft.Formularios_de_Consulta
{
    partial class Diagnostico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescDiagnostico = new System.Windows.Forms.TextBox();
            this.txtNombreDiagnostico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardadReg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtDescDiagnostico);
            this.groupBox1.Controls.Add(this.txtNombreDiagnostico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(40, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnósticos";
            // 
            // txtDescDiagnostico
            // 
            this.txtDescDiagnostico.Location = new System.Drawing.Point(173, 120);
            this.txtDescDiagnostico.Multiline = true;
            this.txtDescDiagnostico.Name = "txtDescDiagnostico";
            this.txtDescDiagnostico.Size = new System.Drawing.Size(354, 136);
            this.txtDescDiagnostico.TabIndex = 1;
            // 
            // txtNombreDiagnostico
            // 
            this.txtNombreDiagnostico.Location = new System.Drawing.Point(173, 59);
            this.txtNombreDiagnostico.Name = "txtNombreDiagnostico";
            this.txtNombreDiagnostico.Size = new System.Drawing.Size(354, 30);
            this.txtNombreDiagnostico.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(71, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(98, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnGuardadReg
            // 
            this.btnGuardadReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardadReg.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardadReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardadReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardadReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardadReg.Location = new System.Drawing.Point(40, 318);
            this.btnGuardadReg.Name = "btnGuardadReg";
            this.btnGuardadReg.Size = new System.Drawing.Size(182, 57);
            this.btnGuardadReg.TabIndex = 20;
            this.btnGuardadReg.Text = "Guardar";
            this.btnGuardadReg.UseVisualStyleBackColor = false;
            this.btnGuardadReg.Click += new System.EventHandler(this.btnGuardadReg_Click);
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 423);
            this.Controls.Add(this.btnGuardadReg);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagnostico";
            this.Text = "Diagnostico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescDiagnostico;
        private System.Windows.Forms.TextBox txtNombreDiagnostico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardadReg;
    }
}