using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace Vista_Seguridad
{
    public partial class Menup : Form
    {
        Controlador cn = new Controlador();

        public Menup()
        {
            InitializeComponent();
            Button[] apps = { btnseguridad, btlogistica};
            cn.deshabilitarApps(apps);
            cn.getAccesoApp(1000, apps[0]);
            cn.getAccesoApp(2000, apps[1]);
        }

        public void btnlogout_Click(object sender, EventArgs e)
        {
            MenuSeguridad b = new MenuSeguridad();
            b.Show();
            cn.setBtitacora("1000", "Ingreso Seguridad");
            //this.Close();
        }

        public void btlogistica_Click(object sender, EventArgs e)
        {
            CineVision.MenuCineVision b = new CineVision.MenuCineVision();
            
                b.Show();
            
            cn.setBtitacora("2000", "Ingreso Cine");
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login b = new Login();
            cn.setBtitacora("1999", "Cerro Sesion");
            b.Show();
            this.Close();
        }

        private void Menup_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            cn.setBtitacora("1999", "logout");
        }

        private void Menup_Load(object sender, EventArgs e)
        {

        }
    }
}
