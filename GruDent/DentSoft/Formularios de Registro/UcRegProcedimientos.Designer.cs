namespace DentSoft.Formularios_de_Registro
{
    partial class UcRegProcedimientos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardadReg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCostoProcedimiento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescProcedimientos = new System.Windows.Forms.TextBox();
            this.txtNombreProcedimientos = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardadReg
            // 
            this.btnGuardadReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardadReg.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardadReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardadReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardadReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardadReg.Location = new System.Drawing.Point(49, 369);
            this.btnGuardadReg.Name = "btnGuardadReg";
            this.btnGuardadReg.Size = new System.Drawing.Size(182, 57);
            this.btnGuardadReg.TabIndex = 22;
            this.btnGuardadReg.Text = "Guardar";
            this.btnGuardadReg.UseVisualStyleBackColor = false;
            this.btnGuardadReg.Click += new System.EventHandler(this.btnGuardadReg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtCostoProcedimiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescProcedimientos);
            this.groupBox1.Controls.Add(this.txtNombreProcedimientos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(49, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 332);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procedimientos";
            // 
            // txtCostoProcedimiento
            // 
            this.txtCostoProcedimiento.Location = new System.Drawing.Point(191, 117);
            this.txtCostoProcedimiento.Mask = "99999";
            this.txtCostoProcedimiento.Name = "txtCostoProcedimiento";
            this.txtCostoProcedimiento.Size = new System.Drawing.Size(109, 30);
            this.txtCostoProcedimiento.TabIndex = 8;
            this.txtCostoProcedimiento.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Costo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // txtDescProcedimientos
            // 
            this.txtDescProcedimientos.Location = new System.Drawing.Point(191, 178);
            this.txtDescProcedimientos.Multiline = true;
            this.txtDescProcedimientos.Name = "txtDescProcedimientos";
            this.txtDescProcedimientos.Size = new System.Drawing.Size(354, 136);
            this.txtDescProcedimientos.TabIndex = 2;
            // 
            // txtNombreProcedimientos
            // 
            this.txtNombreProcedimientos.Location = new System.Drawing.Point(191, 56);
            this.txtNombreProcedimientos.Name = "txtNombreProcedimientos";
            this.txtNombreProcedimientos.Size = new System.Drawing.Size(354, 30);
            this.txtNombreProcedimientos.TabIndex = 4;
            // 
            // UcRegProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGuardadReg);
            this.Controls.Add(this.groupBox1);
            this.Name = "UcRegProcedimientos";
            this.Size = new System.Drawing.Size(841, 452);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardadReg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtCostoProcedimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescProcedimientos;
        private System.Windows.Forms.TextBox txtNombreProcedimientos;
    }
}
