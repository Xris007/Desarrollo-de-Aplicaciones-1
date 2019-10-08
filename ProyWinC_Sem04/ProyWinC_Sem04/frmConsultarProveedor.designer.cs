namespace ProyWinC_Sem04
{
    partial class frmConsultarProveedor
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
            this.Label2 = new System.Windows.Forms.Label();
            this.lblRaz = new System.Windows.Forms.Label();
            this.lblRepVen = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.lblRaz);
            this.GroupBox1.Controls.Add(this.lblRepVen);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.lblTel);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.lblDir);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(7, 35);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(440, 136);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos del Proveedor";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Razon Social:";
            // 
            // lblRaz
            // 
            this.lblRaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRaz.Location = new System.Drawing.Point(160, 24);
            this.lblRaz.Name = "lblRaz";
            this.lblRaz.Size = new System.Drawing.Size(205, 16);
            this.lblRaz.TabIndex = 0;
            // 
            // lblRepVen
            // 
            this.lblRepVen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRepVen.Location = new System.Drawing.Point(160, 105);
            this.lblRepVen.Name = "lblRepVen";
            this.lblRepVen.Size = new System.Drawing.Size(205, 16);
            this.lblRepVen.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(24, 105);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 16);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Rep. Ventas :";
            // 
            // lblTel
            // 
            this.lblTel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTel.Location = new System.Drawing.Point(160, 76);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(97, 16);
            this.lblTel.TabIndex = 0;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(24, 76);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(80, 16);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Telefono:";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(24, 49);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 16);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "Direccion:";
            // 
            // lblDir
            // 
            this.lblDir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDir.Location = new System.Drawing.Point(160, 49);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(264, 16);
            this.lblDir.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(173, 20);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Ingrese Codigo Proveedor:";
            // 
            // txtcod
            // 
            this.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcod.Location = new System.Drawing.Point(208, 9);
            this.txtcod.MaxLength = 4;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(56, 20);
            this.txtcod.TabIndex = 9;
            this.txtcod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcod_KeyPress);
            // 
            // frmConsultarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 174);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtcod);
            this.Name = "frmConsultarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultarProveedor";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lblRaz;
        internal System.Windows.Forms.Label lblRepVen;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblTel;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label lblDir;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtcod;
    }
}