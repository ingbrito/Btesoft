using CapaEntidad;
using CapaNegocio;
using DentSoft.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Formularios_de_Registro
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }


        E_Usuario objEntidad = new E_Usuario();
        N_Usuario objNegocio = new N_Usuario();
        public int iduser = 0;

        #region Metodo de rellenar datagrid
        void RellenarDgv()
        {
            using (var db = new GRUDENTEntities())
            {
                var lista = (from u in db.Usuario
                             join r in db.Roles on u.IdRol equals r.IdRol
                             select new
                             {
                                 ID = u.UserID,
                                 Username = u.LoginName,
                                 Nombre = u.Nombre,
                                 Apellido = u.Apellido,
                                 Email = u.Email,
                                 Rol = r.NombreRol
                             }).ToList();

                dgvUsuarios.DataSource = lista;
            }
        }
        #endregion

        #region Limpiar txt
        void LimpiarCampos()
        {
            txtUsername.Clear();
            txtContrasena.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            cbbPosicion.SelectedIndex = -1;
        }
        #endregion
        private ComboBox GetCbbPosicion()
        {
            return cbbPosicion;
        }

        #region Metodo actualizar Usuario
        void Actualizar(ComboBox cbbPosicion)
        {
            objEntidad.Id = iduser;
            objEntidad.LoginName = txtUserN.Text;
            objEntidad.Password = txtPass.Text;
            objEntidad.Nombre = txtName.Text;
            objEntidad.Apellido = txtApe.Text;
            objEntidad.Email = txtMail.Text;
            objEntidad.IdRol = cbbPosicion.SelectedValue.ToString(); // Fix: Convert the SelectedValue to string

            objNegocio.CN_UpdateUsuario(objEntidad);
            MessageBox.Show("Registro Actualizado Satisfactoriamente", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RellenarDgv();
            txtUserN.Text = null;
            txtPass.Text = null;
            txtName.Text = null;
            txtApe.Text = null;
            txtMail.Text = null;
        }
        #endregion

        #region Boton registrar usuarios para utilizar sistema
        private void btnGuardarReg_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUsername.Text != "") && (txtContrasena.Text != "") && (txtNombre.Text != "") &&
                       (txtApellido.Text != "") && (txtEmail.Text != "") && (cbbPosicion.Text != ""))
                {

                    using (Model.GRUDENTEntities db = new Model.GRUDENTEntities())
                    {
                        Model.Usuario user = new Model.Usuario();
                        user.LoginName = txtUsername.Text.Trim();
                        user.Password = txtContrasena.Text.Trim();
                        user.Nombre = txtNombre.Text.Trim();
                        user.Apellido = txtApellido.Text.Trim();
                        user.Email = txtEmail.Text.Trim();
                        user.IdRol = Convert.ToInt32(cbbPosicion.SelectedValue);


                        db.Usuario.Add(user);
                        db.SaveChanges();
                        LimpiarCampos();
                        RellenarDgv();
                        MessageBox.Show("Usuario registrado correctamente", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsername.Focus();

                    }
                }
                else
                {

                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Evento load del formulario 
        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
               
                RellenarDgv();
                CargarRoles();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
          
           }
        }
        private void CargarRoles()
            
        {
            using (var db = new GRUDENTEntities())
            {
                var roles = db.Roles.Select(r => new { r.IdRol, r.NombreRol }).ToList();
                cbbPosicion.DataSource = roles;
                cbbPosicion.DisplayMember = "NombreRol";
                cbbPosicion.ValueMember = "IdRol";
                cbbPosicion.SelectedIndex = -1;
            }
        }

        #endregion

        #region Datagridview usuarios
        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iduser = Convert.ToInt16(dgvUsuarios.CurrentRow.Cells["ID"].Value.ToString());
                txtUserN.Text = dgvUsuarios.CurrentRow.Cells["Username"].Value.ToString();
                txtName.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPass.Text = dgvUsuarios.CurrentRow.Cells["Password"].Value.ToString();
                txtApe.Text = dgvUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtMail.Text = dgvUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                cbbPosit.Text = dgvUsuarios.CurrentRow.Cells["Posicion"].Value.ToString();
                cbbPosit.SelectedValue = dgvUsuarios.CurrentRow.Cells["Rol"]; // donde idRolDelUsuario es el ID real del rol

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion     

        #region Eliminar Usuario
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (dgvUsuarios.Rows[e.RowIndex].Cells["Eliminar"].Selected)
                {
                    int eliminar = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                    DialogResult resultado = MessageBox.Show("Realmente deseas eliminar este usuario", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                    objNegocio.CN_EliminarUsuario(eliminar);
                    RellenarDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Boton actualizar usuarios
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtUserN.Text != "") && (txtPass.Text != "") && (txtName.Text != "") &&
                (txtApe.Text != "") && (txtMail.Text != "") && (cbbPosit.Text != ""))
                {
                    Actualizar(GetCbbPosicion());
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Faltan campos obligatorios", "Error en la operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
        #endregion



    }
}
