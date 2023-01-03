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
    public partial class Aplicacion : Form
    {
        string table = "tbl_Aplicaciones";
        Controlador cn = new Controlador();

        public Aplicacion()
        {
            InitializeComponent();
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1002";
            TextBox[] Grupotextbox = { pk_id_aplicacion, txtNombre, txtDescripcion, txtEstado };
            TextBox[] Idtextbox = { pk_id_aplicacion, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_aplicaciones;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_aplicaciones, Grupotextbox, "cinevision");
        }
    }
}
