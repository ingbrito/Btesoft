using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DentSoft.Model;

namespace DentSoft.Formularios_de_Consulta
{
    public partial class HistoriaClinica : Form
    {
        public HistoriaClinica()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        private void btnImpReport_Click(object sender, EventArgs e)
        {
            
        }

        private void HistoriaClinica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gRUDENTDataSet.Procesos' table. You can move, or remove it, as needed.
            this.procesosTableAdapter.Fill(this.gRUDENTDataSet.Procesos);

            //#region Edad
            //DateTime nacimiento = Convert.ToDateTime(dgvHistoriaClinica.CurrentRow.Cells[6].Value.ToString());
            //int edad = DateTime.Today.AddTicks(nacimiento.Ticks).Year - 1;
            //#endregion

            FichaConsulta fc = Owner as FichaConsulta;

            //fc.idp = Convert.ToInt32(dgvHistoriaClinica.CurrentRow.Cells[0].Value.ToString());
            //fc.txtNombrePaciente.Text = dgvHistoriaClinica.CurrentRow.Cells[2].Value.ToString();
            //fc.txtSexoPaciente.Text = dgvHistoriaClinica.CurrentRow.Cells[5].Value.ToString();
            //fc.txtEdadPaciente.Text = Convert.ToString(edad);

            using (GRUDENTEntities db = new GRUDENTEntities())
            {
                Consulta consult = new Consulta();

                consult.NombrePaciente = txtNombrePaciente.Text.Trim();
                consult.Edad = txtEdadPacient.Text.Trim();
                consult.Sexo = txtSexoPacient.Text.Trim();

            }
        }
    }
}
