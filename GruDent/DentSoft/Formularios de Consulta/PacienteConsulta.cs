using DentSoft.Formularios_de_Consulta;
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
    public partial class PacienteConsulta : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool mover = false;
        bool borrar = false;
        Pen pen;
       
        public PacienteConsulta()
        {
            InitializeComponent();
            g = drawpaint.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void drawpaint_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            x = e.X;
            y = e.Y;


        }

        private void drawpaint_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

            }

        }

        private void drawpaint_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
            x = -1;
            y = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = p.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawpaint.Invalidate();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistoriaClinica hc = new HistoriaClinica();
            hc.ShowDialog();
           
        }

        private void btnBuscarDiagnostico_Click(object sender, EventArgs e)
        {
            //BuscarDiagnostico bd = new BuscarDiagnostico();
            //bd.ShowDialog();
        }
    }
}
