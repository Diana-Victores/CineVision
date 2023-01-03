using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVision
{
    public partial class MenuCineVision : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();


        public MenuCineVision()
        {
            InitializeComponent();
            customizeDesing();

            Button[] apps = { btnCine, btnPelicula, btnCompraBoleto,btnSeguridad,
                btnConsulta,btnSalir};
            cnseg.deshabilitarApps(apps);
            cnseg.getAccesoApp(2001, apps[0]);
            cnseg.getAccesoApp(2002, apps[1]);
            cnseg.getAccesoApp(2003, apps[2]);
            cnseg.getAccesoApp(2004, apps[3]);
            cnseg.getAccesoApp(2100, apps[4]);
        }
        private void customizeDesing()
        {
            panelMantenimientos.Visible = false;
            panelProcesos.Visible = false;
            panelSeguridad.Visible = false;
            panelHerramienta.Visible = false;
            panelSalir.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelMantenimientos.Visible == true)
                panelMantenimientos.Visible = false;
            if (panelProcesos.Visible == true)
                panelProcesos.Visible = false;
            if (panelSeguridad.Visible == true)
                panelSeguridad.Visible = false;
            if (panelHerramienta.Visible == true)
                panelHerramienta.Visible = false;
            if (panelSalir.Visible == true)
                panelSalir.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cines b = new Cines();

            b.MdiParent = this;
            b.StartPosition = FormStartPosition.CenterScreen;
            b.Show();
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Peliculas b = new Peliculas();

            b.MdiParent = this;
            b.StartPosition = FormStartPosition.CenterScreen;
            b.Show();
            hideSubMenu();
        }

        private void MenuCineVision_Load(object sender, EventArgs e)
        {

        }

        private void btnCompraBoleto_Click(object sender, EventArgs e)
        {
            CineVision.ProcesoFactura b = new CineVision.ProcesoFactura();
            b.MdiParent = this;
            b.Show();
            pictureBox1.Visible = false;
            hideSubMenu();
        }

        private void panelMantenimientos_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelProcesos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMantenimientos);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSeguridad);
        }

        private void buttonSeguridad_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHerramienta);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Capa_VistaConsultas.Busqueda_Avanzada consultar = new Capa_VistaConsultas.Busqueda_Avanzada();
            consultar.MdiParent = this;
            consultar.StartPosition = FormStartPosition.CenterScreen;
            consultar.Show();
            hideSubMenu();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void panelSalir_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
