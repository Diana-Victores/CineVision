
namespace CineVision
{
    partial class Cines
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
            this.dgvcine = new System.Windows.Forms.DataGridView();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCarnet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcine)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(125, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 1;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // dgvcine
            // 
            this.dgvcine.AllowUserToAddRows = false;
            this.dgvcine.AllowUserToDeleteRows = false;
            this.dgvcine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcine.Location = new System.Drawing.Point(335, 202);
            this.dgvcine.Margin = new System.Windows.Forms.Padding(2);
            this.dgvcine.Name = "dgvcine";
            this.dgvcine.ReadOnly = true;
            this.dgvcine.RowHeadersWidth = 62;
            this.dgvcine.RowTemplate.Height = 28;
            this.dgvcine.Size = new System.Drawing.Size(442, 223);
            this.dgvcine.TabIndex = 42;
            this.dgvcine.Tag = "alumnos";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(94, 117);
            this.textDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(161, 20);
            this.textDireccion.TabIndex = 41;
            this.textDireccion.Tag = "direccion_alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Direccion";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(94, 81);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(161, 20);
            this.textNombre.TabIndex = 39;
            this.textNombre.Tag = "nombre_alumno";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(94, 19);
            this.textID.Margin = new System.Windows.Forms.Padding(2);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(161, 20);
            this.textID.TabIndex = 38;
            this.textID.Tag = "codigo_alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Estatus";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(94, 146);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(161, 20);
            this.textTelefono.TabIndex = 46;
            this.textTelefono.Tag = "telefono_alumno";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(94, 173);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(161, 20);
            this.textEmail.TabIndex = 47;
            this.textEmail.Tag = "email_alumno";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(94, 207);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(161, 20);
            this.textStatus.TabIndex = 48;
            this.textStatus.Tag = "estatus_alumno";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textCarnet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textStatus);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textDireccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 255);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textCarnet
            // 
            this.textCarnet.Location = new System.Drawing.Point(94, 56);
            this.textCarnet.Name = "textCarnet";
            this.textCarnet.Size = new System.Drawing.Size(161, 20);
            this.textCarnet.TabIndex = 65;
            this.textCarnet.Tag = "carnet_alumno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Carnet";
            // 
            // Cines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvcine);
            this.Controls.Add(this.navegador1);
            this.Name = "Cines";
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcine)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView dgvcine;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCarnet;
        private System.Windows.Forms.Label label7;
    }
}