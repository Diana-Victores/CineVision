
namespace CineVision
{
    partial class ProcesoFactura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textPagarT = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textSala = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textHora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPelicula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textIDMaestro = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textPagarT);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.textSala);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textHora);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textPelicula);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textIDMaestro);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nota";
            // 
            // textPagarT
            // 
            this.textPagarT.Location = new System.Drawing.Point(380, 156);
            this.textPagarT.Name = "textPagarT";
            this.textPagarT.Size = new System.Drawing.Size(137, 26);
            this.textPagarT.TabIndex = 18;
            this.textPagarT.Tag = "nota";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.iconButton2.IconColor = System.Drawing.Color.Red;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(602, 118);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(94, 68);
            this.iconButton2.TabIndex = 17;
            this.iconButton2.Text = "Cancelar";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.iconButton1.IconColor = System.Drawing.Color.LightSeaGreen;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(599, 32);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(97, 68);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "Registrar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textSala
            // 
            this.textSala.Location = new System.Drawing.Point(380, 113);
            this.textSala.Name = "textSala";
            this.textSala.Size = new System.Drawing.Size(137, 26);
            this.textSala.TabIndex = 11;
            this.textSala.Tag = "carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Carrera";
            // 
            // textHora
            // 
            this.textHora.Location = new System.Drawing.Point(379, 73);
            this.textHora.Name = "textHora";
            this.textHora.Size = new System.Drawing.Size(138, 26);
            this.textHora.TabIndex = 9;
            this.textHora.Tag = "cursos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Curso";
            // 
            // textPelicula
            // 
            this.textPelicula.Location = new System.Drawing.Point(380, 28);
            this.textPelicula.Name = "textPelicula";
            this.textPelicula.Size = new System.Drawing.Size(139, 26);
            this.textPelicula.TabIndex = 6;
            this.textPelicula.Tag = "carnetalumno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Carnet Alumno";
            // 
            // textIDMaestro
            // 
            this.textIDMaestro.Location = new System.Drawing.Point(101, 62);
            this.textIDMaestro.Name = "textIDMaestro";
            this.textIDMaestro.Size = new System.Drawing.Size(140, 26);
            this.textIDMaestro.TabIndex = 3;
            this.textIDMaestro.Tag = "textIDMaestro";
            this.textIDMaestro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(101, 26);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(140, 26);
            this.textID.TabIndex = 2;
            this.textID.Tag = "";
            this.textID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Maestro";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Registro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 487);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 128);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Tag = "procesonotas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Registro de Notas";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(125, 67);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 10;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // ProcesoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 674);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcesoFactura";
            this.Text = "Registro Notas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textIDMaestro;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textPelicula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPagarT;
        private NavegadorVista.Navegador navegador1;
    }
}