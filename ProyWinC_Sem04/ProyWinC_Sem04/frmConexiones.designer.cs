namespace ProyWinC_Sem04
{
    partial class frmConexiones
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Button1);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Location = new System.Drawing.Point(70, 28);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(384, 80);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "CONEXION A SQL SERVER";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(64, 24);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(112, 32);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "ABRIR";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Enabled = false;
            this.Button2.Location = new System.Drawing.Point(208, 24);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(112, 32);
            this.Button2.TabIndex = 0;
            this.Button2.Text = "CERRAR";
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Button3);
            this.GroupBox2.Controls.Add(this.Button4);
            this.GroupBox2.Location = new System.Drawing.Point(70, 124);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(384, 72);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "CONEXION CON ACCESS";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(64, 24);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(112, 32);
            this.Button3.TabIndex = 0;
            this.Button3.Text = "ABRIR";
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Enabled = false;
            this.Button4.Location = new System.Drawing.Point(208, 24);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(112, 32);
            this.Button4.TabIndex = 0;
            this.Button4.Text = "CERRAR";
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // frmConexiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 238);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Name = "frmConexiones";
            this.Text = "Ejemplo de Conexiones";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button4;
    }
}

