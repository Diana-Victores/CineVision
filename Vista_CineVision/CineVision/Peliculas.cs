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
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2003";
            TextBox[] Grupotextbox = { textIDPelicula, textNombrePelicula,
                textClasificacion, textGenero, textSubtitulado, Idioma, textPrecio };
            TextBox[] Idtextbox = { textIDPelicula, textNombrePelicula };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dgvPeliculas;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dgvPeliculas, Grupotextbox, "cinevision");
        }
    }
}
