namespace ProyWinC_Sem02
{
    partial class frmInicio
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNoModal = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyWinC_Sem02.Properties.Resources.left_aligned_column_image001;
            this.pictureBox1.Location = new System.Drawing.Point(129, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Cerrar el formulario");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNoModal
            // 
            this.btnNoModal.Image = global::ProyWinC_Sem02.Properties.Resources.form_yellow;
            this.btnNoModal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoModal.Location = new System.Drawing.Point(240, 58);
            this.btnNoModal.Name = "btnNoModal";
            this.btnNoModal.Size = new System.Drawing.Size(89, 40);
            this.btnNoModal.TabIndex = 1;
            this.btnNoModal.Text = "No Modal";
            this.btnNoModal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnNoModal, "Mostrará formulario Form1");
            this.btnNoModal.UseVisualStyleBackColor = true;
            this.btnNoModal.Click += new System.EventHandler(this.btnNoModal_Click);
            // 
            // btnModal
            // 
            this.btnModal.Image = global::ProyWinC_Sem02.Properties.Resources.form_green;
            this.btnModal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModal.Location = new System.Drawing.Point(83, 58);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(78, 40);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnModal, "Mostrará formulario frmDatos");
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNoModal);
            this.Controls.Add(this.btnModal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnNoModal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}