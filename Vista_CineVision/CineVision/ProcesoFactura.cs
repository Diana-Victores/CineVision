﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_CineVision;

namespace CineVision
{
    public partial class ProcesoFactura : Form
    {

        Controlador cn = new Controlador();
        OdbcConnection con = new OdbcConnection("Dsn=cinevision");

        public ProcesoFactura()
        {
            InitializeComponent();
            
        }
        

        public Controlador Cn { get => cn; set => cn = value; }

        public void CargarTablas(ComboBox comboBox1)
        {
            OdbcConnection con = new OdbcConnection("Dsn=cinevision");
            con.Open();
            comboBox1.DataSource = con.GetSchema("Tables");
            comboBox1.DisplayMember = "TABLE_NAME";
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AyudaBoleto a = new AyudaBoleto("clientes", "idClientes");



            if (cn.IDS == null && textIDMaestro.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                textIDMaestro.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textID.Clear();
            textIDMaestro.Clear();
            textPelicula.Clear();
            textSala.Clear();
            textPelicula.Clear();
            textHora.Clear();
            textPagarT.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AyudaBoleto a = new AyudaBoleto("peliculas", "idPeliculas");



            if (cn.IDS == null && textPelicula.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                textPelicula.Text = cn.IDS;
                cn.IDS = null;
            }
        }
        Controlador_CineVision.Controlador
          crud = new Controlador_CineVision.Controlador();

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //bool resultado = crud.InsertProducto
            //    (textID.Text, textCliente.Text, 
            //    textPelicula.Text, textHora.Text,
            //    textSala.Text, cboFila.Text, cboColumna.Text);
            //if (resultado)
            //{
            //    dataGridView1.Rows.Add(new object[] { 
            //        textID.Text, textCliente.Text,
            //        textPelicula.Text, textHora.Text, 
            //        textSala.Text, cboFila.Text, cboColumna.Text});
            //}
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2100";
            TextBox[] Grupotextbox = { textID, textIDMaestro,
                textPelicula, textHora, textSala, textPagarT };
            TextBox[] Idtextbox = { textID, textIDMaestro };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "cinevision");
        }
    }
}
