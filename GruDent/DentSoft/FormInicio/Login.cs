using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.FormInicio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Conexion a la base de datos
        SqlConnection conexion =
        new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        #endregion

        public void logueo (string Usuario, string Clave)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Select LoginName,Position FROM Usuario where LoginName=@user and Password=@clave", conexion);
                cmd.Parameters.AddWithValue("@user", Usuario);
                cmd.Parameters.AddWithValue("@clave", Clave);
                SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqladapter.Fill(dt);

                #region Validar Tipo de usuario
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0]["Position"].ToString() == "Estandar")
                    {
                        FPrincipal fp = new FPrincipal();
                        fp.validarusuario = "Estandar";
                        fp.Show();
                    }
                    else if (dt.Rows[0]["Position"].ToString() == "Administrador")
                    {
                        FPrincipal fp = new FPrincipal();
                        fp.validarusuario = "Administrador";
                        fp.Show();
                    }

                }
                #endregion

                else
                {
                    MessageBox.Show("Usuario o contraseña erroneos", "Error en la operacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Clear();
                    txtpass.Focus();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logueo(txtnombre.Text, txtpass.Text);
        }
    }
}
