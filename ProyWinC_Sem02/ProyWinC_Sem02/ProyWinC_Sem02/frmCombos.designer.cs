namespace ProyWinC_Sem02
{
    partial class frmCombos
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
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.cboCargos = new System.Windows.Forms.ComboBox();
            this.lblequipo = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblRS = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.cboBuenos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(32, 130);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 13);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "Clientes:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(32, 81);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 13);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Cargos:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(32, 32);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Equipos:";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(316, 32);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(49, 18);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Equipo:";
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(316, 171);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(49, 15);
            this.Label10.TabIndex = 17;
            this.Label10.Text = "Codigo:";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(316, 133);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(49, 18);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Cliente:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(316, 87);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 16);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Sueldo:";
            // 
            // cboClientes
            // 
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.Location = new System.Drawing.Point(126, 133);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(160, 21);
            this.cboClientes.TabIndex = 12;
            this.cboClientes.SelectionChangeCommitted += new System.EventHandler(this.cboClientes_SelectionChangeCommitted);
            // 
            // cboCargos
            // 
            this.cboCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboCargos.Location = new System.Drawing.Point(126, 81);
            this.cboCargos.Name = "cboCargos";
            this.cboCargos.Size = new System.Drawing.Size(160, 21);
            this.cboCargos.TabIndex = 11;
            this.cboCargos.SelectedIndexChanged += new System.EventHandler(this.cboCargos_SelectedIndexChanged);
            // 
            // lblequipo
            // 
            this.lblequipo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblequipo.Location = new System.Drawing.Point(371, 31);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(125, 17);
            this.lblequipo.TabIndex = 21;
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCod.Location = new System.Drawing.Point(371, 170);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(64, 17);
            this.lblCod.TabIndex = 18;
            // 
            // lblRS
            // 
            this.lblRS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRS.Location = new System.Drawing.Point(371, 130);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(125, 17);
            this.lblRS.TabIndex = 19;
            // 
            // lblSueldo
            // 
            this.lblSueldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSueldo.Location = new System.Drawing.Point(371, 86);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(95, 17);
            this.lblSueldo.TabIndex = 20;
            // 
            // cboBuenos
            // 
            this.cboBuenos.Location = new System.Drawing.Point(126, 29);
            this.cboBuenos.Name = "cboBuenos";
            this.cboBuenos.Size = new System.Drawing.Size(160, 21);
            this.cboBuenos.TabIndex = 13;
            this.cboBuenos.SelectedIndexChanged += new System.EventHandler(this.cboBuenos_SelectedIndexChanged);
            // 
            // frmCombos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 221);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.cboCargos);
            this.Controls.Add(this.lblequipo);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.cboBuenos);
            this.Name = "frmCombos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejando Combos";
            this.Load += new System.EventHandler(this.frmCombos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboClientes;
        internal System.Windows.Forms.ComboBox cboCargos;
        internal System.Windows.Forms.Label lblequipo;
        internal System.Windows.Forms.Label lblCod;
        internal System.Windows.Forms.Label lblRS;
        internal System.Windows.Forms.Label lblSueldo;
        internal System.Windows.Forms.ComboBox cboBuenos;
    }
}

