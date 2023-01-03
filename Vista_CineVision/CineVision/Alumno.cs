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
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2004";
            TextBox[] Grupotextbox = { textID, textCarnet, textNombre,
                textDireccion, textTelefono, textEmail, textStatus };
            TextBox[] Idtextbox = { textID, textCarnet };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dgvcine;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dgvcine, Grupotextbox, "cinevision");
        }
    }
}
