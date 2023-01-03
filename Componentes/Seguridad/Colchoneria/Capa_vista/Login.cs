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
    public partial class Login : Form
    {
        Controlador cn = new Controlador();

        public Login()
        {
            InitializeComponent();
        }

        



        public void login()
        {
            if (cn.validarLogin(TBusuario.Text, Controlador.SetHash(TBcontrasena.Text)))
            {
                Controlador.Username = Controlador.SetHash(TBusuario.Text);
                Menup b = new Menup();
                cn.setBtitacora("1998", "LOGIN");
                b.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Contraseña o Usuario Incorrecta");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            login();  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                TBcontrasena.PasswordChar = '\0';
            }
            else
                       if (TBcontrasena.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                TBcontrasena.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recuperacion b = new recuperacion();
            b.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
