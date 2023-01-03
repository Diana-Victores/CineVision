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
    public partial class Cines : Form
    {
        public Cines()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2004";
            TextBox[] textBoxes = { textID, textNombre, textDireccion };
            TextBox[] textBoxes1 = { textID, textNombre };
            navegador1.actual = this;
            navegador1.tabla = dgvcine;
            navegador1.textbox = textBoxes;
            navegador1.textboxi = textBoxes1;
            navegador1.cargar(dgvcine, textBoxes, "cinevision");
        }
    }
}
