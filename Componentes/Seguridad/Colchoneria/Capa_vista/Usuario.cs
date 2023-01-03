using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace Vista_Seguridad
{
    public partial class Usuario : Form
    {
        string table = "tbl_usuarios";
        Controlador cn = new Controlador();

        public Usuario()
        {
            InitializeComponent();
        }

        public void checks()
        {
            string pregunta;
            pregunta = CmbPA.Text;
            this.pregunta.Text = pregunta;

        }


        private void Usuario_Load(object sender, EventArgs e)
        {
        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {

        }


        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                password_usuario.PasswordChar = '\0';
            }
            else
                      if (password_usuario.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                password_usuario.PasswordChar = '*';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ayudausuario b = new ayudausuario();
            //b.MdiParent = this;
            b.Show();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1001";
            TextBox[] Grupotextbox = { pk_id_usuario, nombre_usuario, apellido_usuario, username_usuario, password_usuario, email_usuario, ultima_conexion_usuario, estado_usuario, pregunta, respuesta };
            TextBox[] Idtextbox = { pk_id_usuario, nombre_usuario };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_usuarios;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_usuarios, Grupotextbox, "cinevision");
        }
    }
}
