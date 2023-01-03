
namespace Vista_Seguridad
{
    partial class Perfiles
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
            this.descripcion_perfil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_perfil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.estado_perfil = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.tbl_perfiles = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pk_id_perfil = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_perfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pk_id_perfil);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.estado_perfil);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.descripcion_perfil);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nombre_perfil);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(506, 270);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // descripcion_perfil
            // 
            this.descripcion_perfil.Location = new System.Drawing.Point(108, 146);
            this.descripcion_perfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcion_perfil.Name = "descripcion_perfil";
            this.descripcion_perfil.Size = new System.Drawing.Size(364, 26);
            this.descripcion_perfil.TabIndex = 28;
            this.descripcion_perfil.Tag = "descripcion_perfil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion";
            // 
            // nombre_perfil
            // 
            this.nombre_perfil.Location = new System.Drawing.Point(107, 102);
            this.nombre_perfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre_perfil.Name = "nombre_perfil";
            this.nombre_perfil.Size = new System.Drawing.Size(364, 26);
            this.nombre_perfil.TabIndex = 5;
            this.nombre_perfil.Tag = "nombre_perfil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Estado:";
            // 
            // estado_perfil
            // 
            this.estado_perfil.Location = new System.Drawing.Point(108, 194);
            this.estado_perfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.estado_perfil.Name = "estado_perfil";
            this.estado_perfil.Size = new System.Drawing.Size(364, 26);
            this.estado_perfil.TabIndex = 30;
            this.estado_perfil.Tag = "estado_perfil";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(84, 4);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(861, 234);
            this.navegador1.TabIndex = 31;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // tbl_perfiles
            // 
            this.tbl_perfiles.AllowUserToAddRows = false;
            this.tbl_perfiles.AllowUserToDeleteRows = false;
            this.tbl_perfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_perfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_perfiles.Location = new System.Drawing.Point(526, 248);
            this.tbl_perfiles.Name = "tbl_perfiles";
            this.tbl_perfiles.ReadOnly = true;
            this.tbl_perfiles.RowHeadersWidth = 62;
            this.tbl_perfiles.RowTemplate.Height = 28;
            this.tbl_perfiles.Size = new System.Drawing.Size(526, 316);
            this.tbl_perfiles.TabIndex = 32;
            this.tbl_perfiles.Tag = "tbl_perfiles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id";
            // 
            // pk_id_perfil
            // 
            this.pk_id_perfil.Location = new System.Drawing.Point(108, 53);
            this.pk_id_perfil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pk_id_perfil.Name = "pk_id_perfil";
            this.pk_id_perfil.Size = new System.Drawing.Size(364, 26);
            this.pk_id_perfil.TabIndex = 32;
            this.pk_id_perfil.Tag = "pk_id_perfil";
            // 
            // Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.tbl_perfiles);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfiles";
            this.Load += new System.EventHandler(this.Perfiles_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_perfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre_perfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descripcion_perfil;
        private System.Windows.Forms.TextBox estado_perfil;
        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView tbl_perfiles;
        private System.Windows.Forms.TextBox pk_id_perfil;
        private System.Windows.Forms.Label label2;
    }
}