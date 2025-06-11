namespace DentSoft.Formulario_Registro_Licencia
{
    partial class FormLicencia
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrialDaysLeftLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EnterLicenseKeyButton = new System.Windows.Forms.Button();
            this.txtProductKey = new System.Windows.Forms.MaskedTextBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DentSoft.Properties.Resources.ds1;
            this.pictureBox1.Location = new System.Drawing.Point(197, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TrialDaysLeftLabel
            // 
            this.TrialDaysLeftLabel.AutoSize = true;
            this.TrialDaysLeftLabel.BackColor = System.Drawing.Color.White;
            this.TrialDaysLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrialDaysLeftLabel.ForeColor = System.Drawing.Color.Blue;
            this.TrialDaysLeftLabel.Location = new System.Drawing.Point(88, 196);
            this.TrialDaysLeftLabel.Name = "TrialDaysLeftLabel";
            this.TrialDaysLeftLabel.Size = new System.Drawing.Size(444, 25);
            this.TrialDaysLeftLabel.TabIndex = 2;
            this.TrialDaysLeftLabel.Text = "Le quedan 30 dias De Su Periodo De Prueba";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(341, 332);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(134, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Salir";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EnterLicenseKeyButton
            // 
            this.EnterLicenseKeyButton.Location = new System.Drawing.Point(119, 332);
            this.EnterLicenseKeyButton.Name = "EnterLicenseKeyButton";
            this.EnterLicenseKeyButton.Size = new System.Drawing.Size(216, 23);
            this.EnterLicenseKeyButton.TabIndex = 11;
            this.EnterLicenseKeyButton.Text = "Enter License Key";
            this.EnterLicenseKeyButton.UseVisualStyleBackColor = true;
            this.EnterLicenseKeyButton.Click += new System.EventHandler(this.EnterLicenseKeyButton_Click);
            // 
            // txtProductKey
            // 
            this.txtProductKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductKey.Location = new System.Drawing.Point(236, 281);
            this.txtProductKey.Mask = ">AAAAA-AAAAA-AAAAA-AAAAA-AAAAA";
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.Size = new System.Drawing.Size(275, 23);
            this.txtProductKey.TabIndex = 9;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmp.Location = new System.Drawing.Point(236, 237);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(275, 23);
            this.txtNombreEmp.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre Empresa:";
            // 
            // FormLicencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 379);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EnterLicenseKeyButton);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.txtNombreEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrialDaysLeftLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLicencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLicencia";
            this.Load += new System.EventHandler(this.FormLicencia_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLicencia_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TrialDaysLeftLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EnterLicenseKeyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox txtProductKey;
        public System.Windows.Forms.TextBox txtNombreEmp;
    }
}