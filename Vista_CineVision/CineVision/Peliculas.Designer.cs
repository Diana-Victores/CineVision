
namespace CineVision
{
    partial class Peliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new NavegadorVista.Navegador();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textGenero = new System.Windows.Forms.TextBox();
            this.textClasificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSubtitulado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombrePelicula = new System.Windows.Forms.TextBox();
            this.textIDPelicula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.Idioma = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(84, 42);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Idioma);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textGenero);
            this.groupBox1.Controls.Add(this.textClasificacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textSubtitulado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textNombrePelicula);
            this.groupBox1.Controls.Add(this.textIDPelicula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(84, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 191);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(348, 115);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(161, 20);
            this.textPrecio.TabIndex = 29;
            this.textPrecio.Tag = "precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Idioma";
            // 
            // textGenero
            // 
            this.textGenero.Location = new System.Drawing.Point(111, 154);
            this.textGenero.Margin = new System.Windows.Forms.Padding(2);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(161, 20);
            this.textGenero.TabIndex = 24;
            this.textGenero.Tag = "Genero";
            // 
            // textClasificacion
            // 
            this.textClasificacion.Location = new System.Drawing.Point(111, 112);
            this.textClasificacion.Margin = new System.Windows.Forms.Padding(2);
            this.textClasificacion.Name = "textClasificacion";
            this.textClasificacion.Size = new System.Drawing.Size(161, 20);
            this.textClasificacion.TabIndex = 23;
            this.textClasificacion.Tag = "Clasificación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Clasificacion";
            // 
            // textSubtitulado
            // 
            this.textSubtitulado.Location = new System.Drawing.Point(348, 31);
            this.textSubtitulado.Margin = new System.Windows.Forms.Padding(2);
            this.textSubtitulado.Name = "textSubtitulado";
            this.textSubtitulado.Size = new System.Drawing.Size(161, 20);
            this.textSubtitulado.TabIndex = 20;
            this.textSubtitulado.Tag = "Subtitulado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Subtitulado";
            // 
            // textNombrePelicula
            // 
            this.textNombrePelicula.Location = new System.Drawing.Point(111, 66);
            this.textNombrePelicula.Margin = new System.Windows.Forms.Padding(2);
            this.textNombrePelicula.Name = "textNombrePelicula";
            this.textNombrePelicula.Size = new System.Drawing.Size(161, 20);
            this.textNombrePelicula.TabIndex = 18;
            this.textNombrePelicula.Tag = "Nombre";
            // 
            // textIDPelicula
            // 
            this.textIDPelicula.Location = new System.Drawing.Point(111, 31);
            this.textIDPelicula.Margin = new System.Windows.Forms.Padding(2);
            this.textIDPelicula.Name = "textIDPelicula";
            this.textIDPelicula.Size = new System.Drawing.Size(161, 20);
            this.textIDPelicula.TabIndex = 17;
            this.textIDPelicula.Tag = "idPeliculas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.AllowUserToDeleteRows = false;
            this.dgvPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Location = new System.Drawing.Point(11, 439);
            this.dgvPeliculas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.RowHeadersWidth = 62;
            this.dgvPeliculas.RowTemplate.Height = 28;
            this.dgvPeliculas.Size = new System.Drawing.Size(773, 154);
            this.dgvPeliculas.TabIndex = 32;
            this.dgvPeliculas.Tag = "Peliculas";
            // 
            // Idioma
            // 
            this.Idioma.Location = new System.Drawing.Point(349, 74);
            this.Idioma.Name = "Idioma";
            this.Idioma.Size = new System.Drawing.Size(160, 20);
            this.Idioma.TabIndex = 30;
            this.Idioma.Tag = "Idioma";
            // 
            // Peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 631);
            this.Controls.Add(this.dgvPeliculas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.navegador1);
            this.Name = "Peliculas";
            this.Text = "Peliculas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textGenero;
        private System.Windows.Forms.TextBox textClasificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSubtitulado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombrePelicula;
        private System.Windows.Forms.TextBox textIDPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.TextBox Idioma;
    }
}