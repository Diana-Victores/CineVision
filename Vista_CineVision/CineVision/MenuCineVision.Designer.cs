
namespace CineVision
{
    partial class MenuCineVision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCineVision));
            this.btnCine = new System.Windows.Forms.Button();
            this.btnPelicula = new System.Windows.Forms.Button();
            this.panelMantenimientos = new System.Windows.Forms.Panel();
            this.buttonCatalogo = new System.Windows.Forms.Button();
            this.panelgeneral = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelSalir = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panelHerramienta = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.panelSeguridad = new System.Windows.Forms.Panel();
            this.buttonSeguridad = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.panelProcesos = new System.Windows.Forms.Panel();
            this.btnCompraBoleto = new System.Windows.Forms.Button();
            this.buttonProceso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMantenimientos.SuspendLayout();
            this.panelgeneral.SuspendLayout();
            this.panelSalir.SuspendLayout();
            this.panelHerramienta.SuspendLayout();
            this.panelSeguridad.SuspendLayout();
            this.panelProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCine
            // 
            this.btnCine.BackColor = System.Drawing.Color.Transparent;
            this.btnCine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCine.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCine.Location = new System.Drawing.Point(0, 0);
            this.btnCine.Name = "btnCine";
            this.btnCine.Size = new System.Drawing.Size(252, 39);
            this.btnCine.TabIndex = 0;
            this.btnCine.Tag = "Cines";
            this.btnCine.Text = "Alumno";
            this.btnCine.UseVisualStyleBackColor = false;
            this.btnCine.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPelicula
            // 
            this.btnPelicula.BackColor = System.Drawing.Color.Transparent;
            this.btnPelicula.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPelicula.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnPelicula.Location = new System.Drawing.Point(0, 39);
            this.btnPelicula.Name = "btnPelicula";
            this.btnPelicula.Size = new System.Drawing.Size(252, 37);
            this.btnPelicula.TabIndex = 1;
            this.btnPelicula.Tag = "Peliculas";
            this.btnPelicula.Text = "Profesor";
            this.btnPelicula.UseVisualStyleBackColor = false;
            this.btnPelicula.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelMantenimientos
            // 
            this.panelMantenimientos.Controls.Add(this.btnPelicula);
            this.panelMantenimientos.Controls.Add(this.btnCine);
            this.panelMantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMantenimientos.Location = new System.Drawing.Point(0, 44);
            this.panelMantenimientos.Name = "panelMantenimientos";
            this.panelMantenimientos.Size = new System.Drawing.Size(252, 130);
            this.panelMantenimientos.TabIndex = 3;
            this.panelMantenimientos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMantenimientos_Paint);
            // 
            // buttonCatalogo
            // 
            this.buttonCatalogo.BackColor = System.Drawing.Color.White;
            this.buttonCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatalogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCatalogo.Location = new System.Drawing.Point(0, 0);
            this.buttonCatalogo.Name = "buttonCatalogo";
            this.buttonCatalogo.Size = new System.Drawing.Size(252, 44);
            this.buttonCatalogo.TabIndex = 5;
            this.buttonCatalogo.Text = "Catalogos";
            this.buttonCatalogo.UseVisualStyleBackColor = false;
            this.buttonCatalogo.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelgeneral
            // 
            this.panelgeneral.AutoScroll = true;
            this.panelgeneral.BackColor = System.Drawing.Color.Moccasin;
            this.panelgeneral.Controls.Add(this.btnSalir);
            this.panelgeneral.Controls.Add(this.panelSalir);
            this.panelgeneral.Controls.Add(this.panelHerramienta);
            this.panelgeneral.Controls.Add(this.btnHerramientas);
            this.panelgeneral.Controls.Add(this.panelSeguridad);
            this.panelgeneral.Controls.Add(this.btnSeguridad);
            this.panelgeneral.Controls.Add(this.panelProcesos);
            this.panelgeneral.Controls.Add(this.buttonProceso);
            this.panelgeneral.Controls.Add(this.panelMantenimientos);
            this.panelgeneral.Controls.Add(this.buttonCatalogo);
            this.panelgeneral.Controls.Add(this.pictureBox1);
            this.panelgeneral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelgeneral.Location = new System.Drawing.Point(0, 0);
            this.panelgeneral.Name = "panelgeneral";
            this.panelgeneral.Size = new System.Drawing.Size(252, 719);
            this.panelgeneral.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(0, 553);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(252, 43);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelSalir
            // 
            this.panelSalir.BackColor = System.Drawing.Color.Transparent;
            this.panelSalir.CausesValidation = false;
            this.panelSalir.Controls.Add(this.buttonSalir);
            this.panelSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalir.Location = new System.Drawing.Point(0, 488);
            this.panelSalir.Name = "panelSalir";
            this.panelSalir.Size = new System.Drawing.Size(252, 65);
            this.panelSalir.TabIndex = 12;
            this.panelSalir.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSalir_Paint);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.buttonSalir.Location = new System.Drawing.Point(0, 0);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(252, 37);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "Log Out";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // panelHerramienta
            // 
            this.panelHerramienta.BackColor = System.Drawing.Color.Transparent;
            this.panelHerramienta.Controls.Add(this.btnConsulta);
            this.panelHerramienta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHerramienta.Location = new System.Drawing.Point(0, 423);
            this.panelHerramienta.Name = "panelHerramienta";
            this.panelHerramienta.Size = new System.Drawing.Size(252, 65);
            this.panelHerramienta.TabIndex = 11;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnConsulta.Location = new System.Drawing.Point(0, 0);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(252, 36);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta Avanzada";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHerramientas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHerramientas.Location = new System.Drawing.Point(0, 387);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(252, 36);
            this.btnHerramientas.TabIndex = 10;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.UseVisualStyleBackColor = true;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // panelSeguridad
            // 
            this.panelSeguridad.BackColor = System.Drawing.Color.Transparent;
            this.panelSeguridad.Controls.Add(this.buttonSeguridad);
            this.panelSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeguridad.Location = new System.Drawing.Point(0, 330);
            this.panelSeguridad.Name = "panelSeguridad";
            this.panelSeguridad.Size = new System.Drawing.Size(252, 57);
            this.panelSeguridad.TabIndex = 9;
            // 
            // buttonSeguridad
            // 
            this.buttonSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeguridad.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.buttonSeguridad.Location = new System.Drawing.Point(0, 0);
            this.buttonSeguridad.Name = "buttonSeguridad";
            this.buttonSeguridad.Size = new System.Drawing.Size(252, 28);
            this.buttonSeguridad.TabIndex = 0;
            this.buttonSeguridad.Text = "Seguridad";
            this.buttonSeguridad.UseVisualStyleBackColor = true;
            this.buttonSeguridad.Click += new System.EventHandler(this.buttonSeguridad_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguridad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSeguridad.Location = new System.Drawing.Point(0, 285);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(252, 45);
            this.btnSeguridad.TabIndex = 8;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // panelProcesos
            // 
            this.panelProcesos.Controls.Add(this.btnCompraBoleto);
            this.panelProcesos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProcesos.Location = new System.Drawing.Point(0, 217);
            this.panelProcesos.Name = "panelProcesos";
            this.panelProcesos.Size = new System.Drawing.Size(252, 68);
            this.panelProcesos.TabIndex = 6;
            // 
            // btnCompraBoleto
            // 
            this.btnCompraBoleto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompraBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraBoleto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCompraBoleto.Location = new System.Drawing.Point(0, 0);
            this.btnCompraBoleto.Name = "btnCompraBoleto";
            this.btnCompraBoleto.Size = new System.Drawing.Size(252, 37);
            this.btnCompraBoleto.TabIndex = 0;
            this.btnCompraBoleto.Text = "Registro notas";
            this.btnCompraBoleto.UseVisualStyleBackColor = true;
            this.btnCompraBoleto.Click += new System.EventHandler(this.btnCompraBoleto_Click);
            // 
            // buttonProceso
            // 
            this.buttonProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProceso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonProceso.Location = new System.Drawing.Point(0, 174);
            this.buttonProceso.Name = "buttonProceso";
            this.buttonProceso.Size = new System.Drawing.Size(252, 43);
            this.buttonProceso.TabIndex = 7;
            this.buttonProceso.Text = "Procesos";
            this.buttonProceso.UseVisualStyleBackColor = true;
            this.buttonProceso.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 633);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 86);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MenuCineVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(848, 719);
            this.Controls.Add(this.panelgeneral);
            this.IsMdiContainer = true;
            this.Name = "MenuCineVision";
            this.Text = "Menu Universidad Diana Victores 9959-19-1471";
            this.Load += new System.EventHandler(this.MenuCineVision_Load);
            this.panelMantenimientos.ResumeLayout(false);
            this.panelgeneral.ResumeLayout(false);
            this.panelSalir.ResumeLayout(false);
            this.panelHerramienta.ResumeLayout(false);
            this.panelSeguridad.ResumeLayout(false);
            this.panelProcesos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCine;
        private System.Windows.Forms.Button btnPelicula;
        private System.Windows.Forms.Panel panelMantenimientos;
        private System.Windows.Forms.Button buttonCatalogo;
        private System.Windows.Forms.Panel panelgeneral;
        private System.Windows.Forms.Button buttonProceso;
        private System.Windows.Forms.Panel panelProcesos;
        private System.Windows.Forms.Button btnCompraBoleto;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Panel panelSeguridad;
        private System.Windows.Forms.Button buttonSeguridad;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Panel panelHerramienta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelSalir;
        private System.Windows.Forms.Button buttonSalir;
    }
}