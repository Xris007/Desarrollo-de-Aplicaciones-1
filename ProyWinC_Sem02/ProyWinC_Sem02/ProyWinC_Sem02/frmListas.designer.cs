namespace ProyWinC_Sem02
{
    partial class frmListas
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
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtGaseosa = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstGaseosas = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarI = new System.Windows.Forms.Button();
            this.btnRecorrerTodos = new System.Windows.Forms.Button();
            this.btnRecorrerSel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(84, 243);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(160, 108);
            this.lstClientes.TabIndex = 30;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(15, 244);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 13);
            this.Label5.TabIndex = 29;
            this.Label5.Text = "Clientes:";
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(282, 239);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(49, 18);
            this.Label11.TabIndex = 26;
            this.Label11.Text = "Cliente:";
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCod.Location = new System.Drawing.Point(285, 289);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(52, 22);
            this.lblCod.TabIndex = 27;
            // 
            // lblRS
            // 
            this.lblRS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRS.Location = new System.Drawing.Point(285, 257);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(125, 17);
            this.lblRS.TabIndex = 28;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(205, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(130, 16);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Ingrese Gaseosa:";
            // 
            // txtGaseosa
            // 
            this.txtGaseosa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGaseosa.Location = new System.Drawing.Point(204, 33);
            this.txtGaseosa.Name = "txtGaseosa";
            this.txtGaseosa.Size = new System.Drawing.Size(127, 20);
            this.txtGaseosa.TabIndex = 24;
            this.txtGaseosa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGaseosa_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(204, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 24);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstGaseosas
            // 
            this.lstGaseosas.Items.AddRange(new object[] {
            "COCA COLA",
            "INKA COLA",
            "PEPSI COLA",
            "FANTA"});
            this.lstGaseosas.Location = new System.Drawing.Point(12, 12);
            this.lstGaseosas.Name = "lstGaseosas";
            this.lstGaseosas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGaseosas.Size = new System.Drawing.Size(144, 108);
            this.lstGaseosas.TabIndex = 17;
            this.lstGaseosas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstGaseosas_KeyUp);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(204, 108);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 24);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(206, 180);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 24);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarI
            // 
            this.btnEliminarI.Location = new System.Drawing.Point(206, 145);
            this.btnEliminarI.Name = "btnEliminarI";
            this.btnEliminarI.Size = new System.Drawing.Size(131, 24);
            this.btnEliminarI.TabIndex = 19;
            this.btnEliminarI.Text = "Eliminar * Indice";
            this.btnEliminarI.Click += new System.EventHandler(this.btnEliminarI_Click);
            // 
            // btnRecorrerTodos
            // 
            this.btnRecorrerTodos.Location = new System.Drawing.Point(12, 131);
            this.btnRecorrerTodos.Name = "btnRecorrerTodos";
            this.btnRecorrerTodos.Size = new System.Drawing.Size(147, 24);
            this.btnRecorrerTodos.TabIndex = 21;
            this.btnRecorrerTodos.Text = "Recorrer";
            this.btnRecorrerTodos.Click += new System.EventHandler(this.btnRecorrerTodos_Click);
            // 
            // btnRecorrerSel
            // 
            this.btnRecorrerSel.Location = new System.Drawing.Point(11, 165);
            this.btnRecorrerSel.Name = "btnRecorrerSel";
            this.btnRecorrerSel.Size = new System.Drawing.Size(150, 24);
            this.btnRecorrerSel.TabIndex = 20;
            this.btnRecorrerSel.Text = "Recorrer Seleccionados";
            this.btnRecorrerSel.Click += new System.EventHandler(this.btnRecorrerSel_Click);
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 377);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtGaseosa);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstGaseosas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminarI);
            this.Controls.Add(this.btnRecorrerTodos);
            this.Controls.Add(this.btnRecorrerSel);
            this.Name = "frmListas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListas";
            this.Load += new System.EventHandler(this.frmListas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstClientes;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label lblCod;
        internal System.Windows.Forms.Label lblRS;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtGaseosa;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.ListBox lstGaseosas;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.Button btnEliminarI;
        internal System.Windows.Forms.Button btnRecorrerTodos;
        internal System.Windows.Forms.Button btnRecorrerSel;
    }
}