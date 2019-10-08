namespace ProyWinC_Sem04
{
    partial class frmComandoReader
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.optApe = new System.Windows.Forms.RadioButton();
            this.optCod = new System.Windows.Forms.RadioButton();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.lblVendedor);
            this.GroupBox1.Controls.Add(this.lblNombre);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtCod);
            this.GroupBox1.Location = new System.Drawing.Point(25, 187);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(422, 112);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Consultando datos ";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(28, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(56, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Vendedor:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVendedor.Location = new System.Drawing.Point(127, 73);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(276, 18);
            this.lblVendedor.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Location = new System.Drawing.Point(127, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(276, 18);
            this.lblNombre.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(82, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Nombre Distrito:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(28, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Ingrese Distrito";
            // 
            // txtCod
            // 
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Location = new System.Drawing.Point(127, 19);
            this.txtCod.MaxLength = 3;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(62, 20);
            this.txtCod.TabIndex = 0;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // optApe
            // 
            this.optApe.AutoSize = true;
            this.optApe.Location = new System.Drawing.Point(370, 38);
            this.optApe.Name = "optApe";
            this.optApe.Size = new System.Drawing.Size(81, 17);
            this.optApe.TabIndex = 10;
            this.optApe.Text = "Por Apellido";
            this.optApe.UseVisualStyleBackColor = true;
            // 
            // optCod
            // 
            this.optCod.AutoSize = true;
            this.optCod.Checked = true;
            this.optCod.Location = new System.Drawing.Point(370, 12);
            this.optCod.Name = "optCod";
            this.optCod.Size = new System.Drawing.Size(77, 17);
            this.optCod.TabIndex = 11;
            this.optCod.TabStop = true;
            this.optCod.Text = "Por Codigo";
            this.optCod.UseVisualStyleBackColor = true;
            // 
            // ListBox2
            // 
            this.ListBox2.Location = new System.Drawing.Point(236, 61);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(211, 108);
            this.ListBox2.TabIndex = 9;
            // 
            // ListBox1
            // 
            this.ListBox1.Location = new System.Drawing.Point(25, 61);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(192, 108);
            this.ListBox1.TabIndex = 8;
            // 
            // btnVendedores
            // 
            this.btnVendedores.Location = new System.Drawing.Point(236, 12);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(128, 32);
            this.btnVendedores.TabIndex = 6;
            this.btnVendedores.Text = "Listar Vendedores";
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(25, 12);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(128, 32);
            this.btnProductos.TabIndex = 7;
            this.btnProductos.Text = "Listar Productos";
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // frmComandoReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 321);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.optApe);
            this.Controls.Add(this.optCod);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.btnVendedores);
            this.Controls.Add(this.btnProductos);
            this.Name = "frmComandoReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComandoReader";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblVendedor;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCod;
        internal System.Windows.Forms.RadioButton optApe;
        internal System.Windows.Forms.RadioButton optCod;
        internal System.Windows.Forms.ListBox ListBox2;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Button btnVendedores;
        internal System.Windows.Forms.Button btnProductos;
    }
}