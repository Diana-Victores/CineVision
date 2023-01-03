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
    public partial class Modulos : Form
    {
        string table = "tbl_modulos";

        Controlador cn = new Controlador();

        public Modulos()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1003";
            TextBox[] Grupotextbox = { pk_id_modulos, nombre_modulo, descripcion_modulo, estado_modulo };
            TextBox[] Idtextbox = { pk_id_modulos, nombre_modulo };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_modulos;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_modulos, Grupotextbox, "cinevision");
        }
    }
}
