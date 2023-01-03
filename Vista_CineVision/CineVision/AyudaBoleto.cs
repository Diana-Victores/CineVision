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
    public partial class AyudaBoleto : Form
    {
        string table, ttipo;
        Controlador_CineVision.Controlador cn = new Controlador_CineVision.Controlador();

        public AyudaBoleto(string tabla, string tipo)
        {
            InitializeComponent();
            table = tabla;
            ttipo = tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewAyuda.CurrentCell != null)
            {


                cn.IDS = dataGridViewAyuda.CurrentRow.Cells[0].Value.ToString();

                this.Close();



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cn.llenarfiltro(table, dataGridViewAyuda, ttipo, textCodigo.Text);
        }

        private void AyudaBoleto_Load(object sender, EventArgs e)
        {
          
        }
    }
}
