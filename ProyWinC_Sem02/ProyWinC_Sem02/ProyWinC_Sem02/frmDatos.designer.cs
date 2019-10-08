namespace ProyWinC_Sem02
{
    partial class frmDatos
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtPunt1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPunt2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optFemenino = new System.Windows.Forms.RadioButton();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.chkPeruano = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(33, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Codigo:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(113, 20);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(32, 20);
            this.txtCod.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Location = new System.Drawing.Point(113, 52);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(144, 20);
            this.txtNom.TabIndex = 3;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(33, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Nombres:";
            // 
            // txtApe
            // 
            this.txtApe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApe.Location = new System.Drawing.Point(377, 52);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(144, 20);
            this.txtApe.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(289, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 16);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Apellidos:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(441, 84);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(257, 84);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(104, 20);
            this.txtRUC.TabIndex = 9;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            this.txtRUC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtRUC_MouseDown);
            this.txtRUC.Validating += new System.ComponentModel.CancelEventHandler(this.txtRUC_Validating);
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(201, 84);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 16);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "RUC:";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(385, 84);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(50, 16);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "EMail:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(386, 174);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 24);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(33, 84);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(74, 24);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(113, 84);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(80, 20);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Enabled = false;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(494, 175);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 17;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtPunt1
            // 
            this.txtPunt1.Location = new System.Drawing.Point(204, 121);
            this.txtPunt1.MaxLength = 2;
            this.txtPunt1.Name = "txtPunt1";
            this.txtPunt1.Size = new System.Drawing.Size(80, 20);
            this.txtPunt1.TabIndex = 13;
            this.txtPunt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            this.txtPunt1.Validating += new System.ComponentModel.CancelEventHandler(this.txtPunt1_Validating);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Puntaje Entrevista:";
            // 
            // txtPunt2
            // 
            this.txtPunt2.Location = new System.Drawing.Point(480, 121);
            this.txtPunt2.MaxLength = 2;
            this.txtPunt2.Name = "txtPunt2";
            this.txtPunt2.Size = new System.Drawing.Size(89, 20);
            this.txtPunt2.TabIndex = 15;
            this.txtPunt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            this.txtPunt2.Validating += new System.ComponentModel.CancelEventHandler(this.txtPunt1_Validating);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Puntaje Examen:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optMasculino);
            this.groupBox1.Controls.Add(this.optFemenino);
            this.groupBox1.Location = new System.Drawing.Point(25, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 83);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo:";
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.Checked = true;
            this.optFemenino.Location = new System.Drawing.Point(38, 19);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(71, 17);
            this.optFemenino.TabIndex = 0;
            this.optFemenino.TabStop = true;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Location = new System.Drawing.Point(38, 42);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(73, 17);
            this.optMasculino.TabIndex = 1;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(204, 194);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 19;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // chkPeruano
            // 
            this.chkPeruano.AutoSize = true;
            this.chkPeruano.Location = new System.Drawing.Point(204, 218);
            this.chkPeruano.Name = "chkPeruano";
            this.chkPeruano.Size = new System.Drawing.Size(72, 17);
            this.chkPeruano.TabIndex = 20;
            this.chkPeruano.Text = "Peruano?";
            this.chkPeruano.UseVisualStyleBackColor = true;
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 307);
            this.Controls.Add(this.chkPeruano);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtPunt2);
            this.Controls.Add(this.txtPunt1);
            this.Controls.Add(this.txtTelefono);
            this.KeyPreview = true;
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplo bucle For-Each";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmDatos_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCod;
        internal System.Windows.Forms.TextBox txtNom;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtApe;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtRUC;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnLimpiar;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.TextBox txtPunt1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtPunt2;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.CheckBox chkPeruano;
    }
}