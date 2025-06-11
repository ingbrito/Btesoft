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
            this.btnGuardarProcedimiento = new System.Windows.Forms.Button();
            this.txtDescProcedimientos = new System.Windows.Forms.TextBox();
            this.txtNombreProcedimientos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarProcedimiento);
            this.groupBox1.Controls.Add(this.txtDescProcedimientos);
            this.groupBox1.Controls.Add(this.txtNombreProcedimientos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(119, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnosticos";
            // 
            // btnGuardarProcedimiento
            // 
            this.btnGuardarProcedimiento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarProcedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProcedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProcedimiento.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarProcedimiento.Location = new System.Drawing.Point(497, 191);
            this.btnGuardarProcedimiento.Name = "btnGuardarProcedimiento";
            this.btnGuardarProcedimiento.Size = new System.Drawing.Size(128, 41);
            this.btnGuardarProcedimiento.TabIndex = 2;
            this.btnGuardarProcedimiento.Text = "Guardar";
            this.btnGuardarProcedimiento.UseVisualStyleBackColor = false;
            // 
            // txtDescProcedimientos
            // 
            this.txtDescProcedimientos.Location = new System.Drawing.Point(173, 120);
            this.txtDescProcedimientos.Multiline = true;
            this.txtDescProcedimientos.Name = "txtDescProcedimientos";
            this.txtDescProcedimientos.Size = new System.Drawing.Size(296, 112);
            this.txtDescProcedimientos.TabIndex = 1;
            // 
            // txtNombreProcedimientos
            // 
            this.txtNombreProcedimientos.Location = new System.Drawing.Point(173, 59);
            this.txtNombreProcedimientos.Name = "txtNombreProcedimientos";
            this.txtNombreProcedimientos.Size = new System.Drawing.Size(296, 30);
            this.txtNombreProcedimientos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 457);
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
        private System.Windows.Forms.Button btnGuardarProcedimiento;
        private System.Windows.Forms.TextBox txtDescProcedimientos;
        private System.Windows.Forms.TextBox txtNombreProcedimientos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}