
namespace Vista_Seguridad
{
    partial class Usuario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CmbPA = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.respuesta = new System.Windows.Forms.TextBox();
            this.pregunta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.estado_usuario = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.username_usuario = new System.Windows.Forms.TextBox();
            this.password_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pk_id_usuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.email_usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.apellido_usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.tbl_usuarios = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.ultima_conexion_usuario = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ultima_conexion_usuario);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.estado_usuario);
            this.groupBox2.Controls.Add(this.check);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.username_usuario);
            this.groupBox2.Controls.Add(this.password_usuario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 514);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(513, 336);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 294);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estado";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CmbPA);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.respuesta);
            this.groupBox5.Controls.Add(this.pregunta);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(8, 183);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(477, 101);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Recuperacion";
            // 
            // CmbPA
            // 
            this.CmbPA.FormattingEnabled = true;
            this.CmbPA.Items.AddRange(new object[] {
            "PRIMER MASCOTA",
            "COLOR FAVORITO",
            "CIUDAD NACIMIENTO",
            "SEGUNDO APELLIDO DEL PADRE",
            "PRIMER CENTRO DE ESTUDIO"});
            this.CmbPA.Location = new System.Drawing.Point(9, 51);
            this.CmbPA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbPA.Name = "CmbPA";
            this.CmbPA.Size = new System.Drawing.Size(180, 28);
            this.CmbPA.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Respuesta";
            // 
            // respuesta
            // 
            this.respuesta.Location = new System.Drawing.Point(274, 51);
            this.respuesta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(169, 26);
            this.respuesta.TabIndex = 9;
            this.respuesta.Tag = "respuesta";
            // 
            // pregunta
            // 
            this.pregunta.Location = new System.Drawing.Point(199, 52);
            this.pregunta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(26, 26);
            this.pregunta.TabIndex = 12;
            this.pregunta.Tag = "pregunta";
            this.pregunta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pregunta de autentificacion";
            // 
            // estado_usuario
            // 
            this.estado_usuario.Location = new System.Drawing.Point(157, 294);
            this.estado_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.estado_usuario.Name = "estado_usuario";
            this.estado_usuario.Size = new System.Drawing.Size(328, 26);
            this.estado_usuario.TabIndex = 8;
            this.estado_usuario.Tag = "estado_usuario";
            this.estado_usuario.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(382, 119);
            this.check.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(103, 24);
            this.check.TabIndex = 9;
            this.check.Text = "Visualizar";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username";
            // 
            // username_usuario
            // 
            this.username_usuario.Location = new System.Drawing.Point(158, 51);
            this.username_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username_usuario.Name = "username_usuario";
            this.username_usuario.Size = new System.Drawing.Size(328, 26);
            this.username_usuario.TabIndex = 7;
            this.username_usuario.Tag = "username_usuario";
            // 
            // password_usuario
            // 
            this.password_usuario.Location = new System.Drawing.Point(157, 84);
            this.password_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_usuario.Name = "password_usuario";
            this.password_usuario.PasswordChar = '*';
            this.password_usuario.Size = new System.Drawing.Size(328, 26);
            this.password_usuario.TabIndex = 5;
            this.password_usuario.Tag = "password_usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pk_id_usuario);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.email_usuario);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.apellido_usuario);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nombre_usuario);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 273);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(513, 211);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Personales";
            // 
            // pk_id_usuario
            // 
            this.pk_id_usuario.Location = new System.Drawing.Point(157, 39);
            this.pk_id_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pk_id_usuario.Name = "pk_id_usuario";
            this.pk_id_usuario.Size = new System.Drawing.Size(320, 26);
            this.pk_id_usuario.TabIndex = 9;
            this.pk_id_usuario.Tag = "pk_id_usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Id";
            // 
            // email_usuario
            // 
            this.email_usuario.Location = new System.Drawing.Point(158, 151);
            this.email_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email_usuario.Name = "email_usuario";
            this.email_usuario.Size = new System.Drawing.Size(320, 26);
            this.email_usuario.TabIndex = 7;
            this.email_usuario.Tag = "email_usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "email";
            // 
            // apellido_usuario
            // 
            this.apellido_usuario.Location = new System.Drawing.Point(158, 116);
            this.apellido_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.apellido_usuario.Name = "apellido_usuario";
            this.apellido_usuario.Size = new System.Drawing.Size(320, 26);
            this.apellido_usuario.TabIndex = 5;
            this.apellido_usuario.Tag = "apellido_usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.Location = new System.Drawing.Point(157, 77);
            this.nombre_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Size = new System.Drawing.Size(320, 26);
            this.nombre_usuario.TabIndex = 3;
            this.nombre_usuario.Tag = "nombre_usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(134, 14);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(861, 234);
            this.navegador1.TabIndex = 17;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // tbl_usuarios
            // 
            this.tbl_usuarios.AllowUserToAddRows = false;
            this.tbl_usuarios.AllowUserToDeleteRows = false;
            this.tbl_usuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_usuarios.Location = new System.Drawing.Point(548, 273);
            this.tbl_usuarios.Name = "tbl_usuarios";
            this.tbl_usuarios.ReadOnly = true;
            this.tbl_usuarios.RowHeadersWidth = 62;
            this.tbl_usuarios.RowTemplate.Height = 28;
            this.tbl_usuarios.Size = new System.Drawing.Size(628, 579);
            this.tbl_usuarios.TabIndex = 18;
            this.tbl_usuarios.Tag = "tbl_usuarios";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ultima Conex.";
            // 
            // ultima_conexion_usuario
            // 
            this.ultima_conexion_usuario.Location = new System.Drawing.Point(157, 117);
            this.ultima_conexion_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ultima_conexion_usuario.Name = "ultima_conexion_usuario";
            this.ultima_conexion_usuario.PasswordChar = '*';
            this.ultima_conexion_usuario.Size = new System.Drawing.Size(208, 26);
            this.ultima_conexion_usuario.TabIndex = 18;
            this.ultima_conexion_usuario.Tag = "ultima_conexion_usuario";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 864);
            this.Controls.Add(this.tbl_usuarios);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox password_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox apellido_usuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox username_usuario;
        private System.Windows.Forms.TextBox email_usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox estado_usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CmbPA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox respuesta;
        private System.Windows.Forms.TextBox pregunta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox pk_id_usuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView tbl_usuarios;
        private System.Windows.Forms.TextBox ultima_conexion_usuario;
        private System.Windows.Forms.Label label10;
    }
}