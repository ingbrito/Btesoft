using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft.Seguridad
{
    public static class PermisosHelper
    {
        private static Dictionary<string, List<string>> permisosPorRol = new Dictionary<string, List<string>>();

        public static void CargarPermisosDesdeBD()
        {
            permisosPorRol.Clear();

            string connectionString = ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                string query = @"
                    SELECT r.NombreRol, p.NombreFuncion
                    FROM Roles r
                    INNER JOIN RolesPermisos rp ON r.IdRol = rp.Roles_IdRol
                    INNER JOIN Permisos p ON rp.Permisos_IdPermiso = p.IdPermiso
                    WHERE rp.Activo = 1";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string rol = reader.GetString(0);
                        string funcion = reader.GetString(1);

                        if (!permisosPorRol.ContainsKey(rol))
                            permisosPorRol[rol] = new List<string>();

                        if (!permisosPorRol[rol].Contains(funcion))
                            permisosPorRol[rol].Add(funcion);
                    }
                }
            }
        }

        public static void ImprimirPermisos()
        {
            Console.WriteLine("Permisos cargados:");
            foreach (var rol in permisosPorRol.Keys)
            {
                Console.WriteLine($"Rol: {rol}");
                foreach (var permiso in permisosPorRol[rol])
                {
                    Console.WriteLine($" - Permiso: {permiso}");
                }
            }
        }
        public static Dictionary<string, List<string>> GetDebugInfo()
        {
            return permisosPorRol;
        }

        public static bool TienePermiso(string funcionalidad, string rolUsuario)
        {

            var key = permisosPorRol.Keys.FirstOrDefault(k => string.Equals(k, rolUsuario, StringComparison.OrdinalIgnoreCase));

            if (key == null)
            {
                MessageBox.Show($"Rol no encontrado: {rolUsuario}");
                return false;
            }

            bool tiene = permisosPorRol[key].Contains(funcionalidad);
            if (!tiene)
            {
                MessageBox.Show($"Rol '{rolUsuario}' no tiene permiso: {funcionalidad}");
            }

            return tiene;
        }
    }


}
