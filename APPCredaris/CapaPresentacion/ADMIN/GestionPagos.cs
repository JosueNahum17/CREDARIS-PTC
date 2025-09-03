using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ADMIN
{
    public partial class GestionPagos : Form
    {
        public GestionPagos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {
            GestionPrestamos gestionPrestamos = new GestionPrestamos();
            gestionPrestamos.Show();
            this.Hide();
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            GestionEmpleados gestionEmpleados = new GestionEmpleados();
            gestionEmpleados.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
