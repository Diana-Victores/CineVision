
namespace Vista_Seguridad
{
    partial class Modulos
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descripcion_modulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_modulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pk_id_modulos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.estado_modulo = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            this.tbl_modulos = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_modulos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.estado_modulo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.descripcion_modulo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nombre_modulo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pk_id_modulos);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 325);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(544, 302);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Aplicacion";
            // 
            // descripcion_modulo
            // 
            this.descripcion_modulo.Location = new System.Drawing.Point(142, 175);
            this.descripcion_modulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcion_modulo.Name = "descripcion_modulo";
            this.descripcion_modulo.Size = new System.Drawing.Size(364, 26);
            this.descripcion_modulo.TabIndex = 28;
            this.descripcion_modulo.Tag = "descripcion_modulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descripcion";
            // 
            // nombre_modulo
            // 
            this.nombre_modulo.Location = new System.Drawing.Point(137, 108);
            this.nombre_modulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre_modulo.Name = "nombre_modulo";
            this.nombre_modulo.Size = new System.Drawing.Size(364, 26);
            this.nombre_modulo.TabIndex = 5;
            this.nombre_modulo.Tag = "nombre_modulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Modulo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pk_id_modulos
            // 
            this.pk_id_modulos.Location = new System.Drawing.Point(137, 51);
            this.pk_id_modulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pk_id_modulos.Name = "pk_id_modulos";
            this.pk_id_modulos.Size = new System.Drawing.Size(364, 26);
            this.pk_id_modulos.TabIndex = 1;
            this.pk_id_modulos.Tag = "pk_id_modulos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Modulo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Estado";
            // 
            // estado_modulo
            // 
            this.estado_modulo.Location = new System.Drawing.Point(137, 237);
            this.estado_modulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.estado_modulo.Name = "estado_modulo";
            this.estado_modulo.Size = new System.Drawing.Size(364, 26);
            this.estado_modulo.TabIndex = 30;
            this.estado_modulo.Tag = "estado_modulo";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(114, 10);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(861, 234);
            this.navegador1.TabIndex = 26;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // tbl_modulos
            // 
            this.tbl_modulos.AllowUserToAddRows = false;
            this.tbl_modulos.AllowUserToDeleteRows = false;
            this.tbl_modulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_modulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_modulos.Location = new System.Drawing.Point(564, 252);
            this.tbl_modulos.Name = "tbl_modulos";
            this.tbl_modulos.ReadOnly = true;
            this.tbl_modulos.RowHeadersWidth = 62;
            this.tbl_modulos.RowTemplate.Height = 28;
            this.tbl_modulos.Size = new System.Drawing.Size(531, 428);
            this.tbl_modulos.TabIndex = 27;
            this.tbl_modulos.Tag = "tbl_modulos";
            // 
            // Modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 692);
            this.Controls.Add(this.tbl_modulos);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Modulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_modulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre_modulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pk_id_modulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox descripcion_modulo;
        private System.Windows.Forms.TextBox estado_modulo;
        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.DataGridView tbl_modulos;
    }
}