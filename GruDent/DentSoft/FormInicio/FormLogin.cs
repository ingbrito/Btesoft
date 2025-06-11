using DentSoft.FormInicio;
using DentSoft.Formularios_de_Registro;
using DentSoft.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public string validarusuario = string.Empty;

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion
        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Placeholder or WaterMark
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        #endregion

        #region Metodo para verificar usuarios
        public void logueo(string Usuario, string Clave)
        {

            PermisosHelper.CargarPermisosDesdeBD();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT UserID, LoginName, IdRol FROM Usuario WHERE LoginName=@user AND Password=@clave", conexion);
                cmd.Parameters.AddWithValue("@user", Usuario);
                cmd.Parameters.AddWithValue("@clave", Clave);

                SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqladapter.Fill(dt);

                #region Validar Tipo de usuario
                if (txtuser.Text != "Usuario" && dt.Rows.Count == 1)
                {
                    int idUsuario = Convert.ToInt32(dt.Rows[0]["UserID"]);
                    int idRol = Convert.ToInt32(dt.Rows[0]["IdRol"]);
                    string rolNombre = ObtenerNombreRol(idRol); // Método nuevo que crearás abajo

                    // FrmPrincipal fp = new FrmPrincipal(rolNombre,Usuario);
                   FrmMain fp = new FrmMain (rolNombre,Usuario);
                    //fp.validarusuario = rolNombre;
                    //fp.usuarioLogin = Usuario;
                    fp.Tag = idUsuario; // Guarda el idUsuario para usar en FrmPrincipal
                    fp.FormClosed += CerrarSesion;
                    fp.Show();
                    MessageBox.Show("Bienvenido al sistema: " + txtuser.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Hide();
                }

                else MessageBox.Show("Usuario o contraseña erroneos", "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear();
                txtpass.Focus();
                #endregion
            }


            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conexion.Close();
            }

            foreach (var rol in PermisosHelper.GetDebugInfo())
            {
                Console.WriteLine($"Rol: {rol.Key}");
                foreach (var permiso in rol.Value)
                {
                    Console.WriteLine($" - {permiso}");
                }
            }

        }

        #endregion

        private string ObtenerNombreRol(int idRol)
        {
            string nombreRol = "Estandar"; // Valor por defecto
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT NombreRol FROM Roles WHERE IdRol = @idRol", conexion);
                cmd.Parameters.AddWithValue("@idRol", idRol);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    nombreRol = dt.Rows[0]["NombreRol"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el nombre del rol: " + ex.Message);
            }
            return nombreRol;
        }


        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtpass.Text= "Contraseña";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "Usuario";
            lblmensaje.Visible = false;
            Show();
           
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void msgError(string msg)
        {
            lblmensaje.Text = "      " + msg;
            lblmensaje.Visible = true;
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            logueo(txtuser.Text, txtpass.Text);

            
        }
    }
}
