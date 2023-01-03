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
    public partial class Perfiles : Form
    {

        string table = "tbl_perfiles";
        Controlador cn = new Controlador();

        public Perfiles()
        {
            InitializeComponent();
        }
        private void Perfiles_Load(object sender, EventArgs e)
        {
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1004";
            TextBox[] Grupotextbox = { pk_id_perfil, nombre_perfil, descripcion_perfil, estado_perfil };
            TextBox[] Idtextbox = { pk_id_perfil, nombre_perfil };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_perfiles;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_perfiles, Grupotextbox, "hoteleria");
        }
    }
}
