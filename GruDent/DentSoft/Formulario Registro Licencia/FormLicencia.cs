using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formulario_Registro_Licencia
{
    public partial class FormLicencia : Form
    {
        public int TotalDaysLeft { get; set; }

        public FormLicencia()
        {
            InitializeComponent();
        }


        #region Movilidad de barra en formulario 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormLicencia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);

        }

        #endregion
        private void FormLicencia_Load(object sender, EventArgs e)
        {
            TrialDaysLeftLabel.Text = "Te quedan " + TotalDaysLeft + " días en tu período de prueba.";

            if (TotalDaysLeft > 0)
            {
                ExitButton.Text = "Continuar con prueba";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitApplication();
        }

        private void ExitApplication()
        {
            if (TotalDaysLeft == 0)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        
        private void EnterLicenseKeyButton_Click(object sender, EventArgs e)
        {

            if (IsValidated())
            {
                try
                {
                    EnterNameAndProductKeyToDB();
                    MessageBox.Show("La clave del producto se ha agregado correctamente al sistema.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        E_ProductLicense objEntidad = new E_ProductLicense();
        N_ProductLicense objNegocio = new N_ProductLicense();

        private void EnterNameAndProductKeyToDB()
        {
            string connstring = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE ProductKey SET [NombreEmpresa]=@NombreEmpresa,[ProductKey]=@ProductKey", conn))
                {
                    cmd.Parameters.AddWithValue("@NombreEmpresa", txtNombreEmp.Text);
                    cmd.Parameters.AddWithValue("@ProductKey", txtProductKey.Text);

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsValidated()
        {
            if (txtNombreEmp.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Se requiere el nombre de la empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreEmp.Focus();
                return false;
            }

            if (!txtProductKey.MaskCompleted)
            {
                MessageBox.Show("La clave del producto debe tener 25 caracteres de longitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductKey.Focus();
                return false;
            }
            else
            {
                bool isValid = CheckIsProductKeyValid(txtProductKey.Text);

                if (!isValid)
                {
                    MessageBox.Show("La clave del producto no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductKey.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool CheckIsProductKeyValid(string productkey)
        {
            // "Z45SO-6FT4T-WA6T4-KRE8U-OR403"
            string part1 = productkey.Substring(3, 2); //SO
            string part2 = productkey.Substring(7, 2); //FT
            string part3 = productkey.Substring(12, 2); //WA
            string part4 = productkey.Substring(19, 2); //RE
            string part5 = productkey.Substring(27, 2); //03

            productkey = part1 + part2 + part3 + part4 + part5;

            if (productkey != "SOFTWARE03") 
            {
                return false;
            }

            return true;
        }

       
    }
}
