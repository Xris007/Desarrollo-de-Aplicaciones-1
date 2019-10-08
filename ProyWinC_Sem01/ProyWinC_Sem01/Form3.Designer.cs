namespace ProyWinC_Sem01
{
    partial class Form3
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
            this.lblPromedio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optPractica = new System.Windows.Forms.RadioButton();
            this.optTeoria = new System.Windows.Forms.RadioButton();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPromedio.Location = new System.Drawing.Point(108, 275);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(75, 23);
            this.lblPromedio.TabIndex = 5;
            this.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Promedio:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(108, 236);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(108, 75);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(67, 20);
            this.txtN3.TabIndex = 2;
            this.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 3:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(108, 49);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(67, 20);
            this.txtN2.TabIndex = 1;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nota 2:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(108, 23);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(67, 20);
            this.txtN1.TabIndex = 0;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nota 1:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optPractica);
            this.groupBox1.Controls.Add(this.optTeoria);
            this.groupBox1.Location = new System.Drawing.Point(51, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija el tipo de curso:";
            // 
            // optPractica
            // 
            this.optPractica.AutoSize = true;
            this.optPractica.Location = new System.Drawing.Point(125, 27);
            this.optPractica.Name = "optPractica";
            this.optPractica.Size = new System.Drawing.Size(64, 17);
            this.optPractica.TabIndex = 1;
            this.optPractica.Text = "Practica";
            this.optPractica.UseVisualStyleBackColor = true;
            // 
            // optTeoria
            // 
            this.optTeoria.AutoSize = true;
            this.optTeoria.Checked = true;
            this.optTeoria.Location = new System.Drawing.Point(12, 27);
            this.optTeoria.Name = "optTeoria";
            this.optTeoria.Size = new System.Drawing.Size(55, 17);
            this.optTeoria.TabIndex = 0;
            this.optTeoria.TabStop = true;
            this.optTeoria.Text = "Teoria";
            this.optTeoria.UseVisualStyleBackColor = true;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(108, 101);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(67, 20);
            this.txtN4.TabIndex = 16;
            this.txtN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nota 4:";
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(108, 127);
            this.txtN5.Name = "txtN5";
            this.txtN5.Size = new System.Drawing.Size(67, 20);
            this.txtN5.TabIndex = 18;
            this.txtN5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nota 5:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 359);
            this.Controls.Add(this.txtN5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Promedios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optPractica;
        private System.Windows.Forms.RadioButton optTeoria;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN5;
        private System.Windows.Forms.Label label6;
    }
}