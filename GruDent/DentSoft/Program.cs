using DentSoft.FormInicio;
using DentSoft.Formulario_Registro_Licencia;
using DentSoft.Formularios_de_Consulta;
using DentSoft.Formularios_de_Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentSoft
{
    static class Program
    {
        public static FichaConsulta Owner { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-DO");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }

        private static void ValidateOwnerForm()
        {
            FichaConsulta fc = Owner as FichaConsulta;
            if (fc == null)
            {
                MessageBox.Show("The owner form is not set or is not of type FichaConsulta.");
                return;
            }
        }
    }
}
