namespace ProyWinC_Sem02
{
    partial class frmListas2
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
            this.lstItem = new System.Windows.Forms.ListBox();
            this.lstItem2 = new System.Windows.Forms.ListBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtItem2 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnLimpiar2 = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.btnMoveRightAll = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveLeftAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstItem
            // 
            this.lstItem.FormattingEnabled = true;
            this.lstItem.Location = new System.Drawing.Point(65, 41);
            this.lstItem.Name = "lstItem";
            this.lstItem.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstItem.Size = new System.Drawing.Size(208, 186);
            this.lstItem.TabIndex = 0;
            // 
            // lstItem2
            // 
            this.lstItem2.FormattingEnabled = true;
            this.lstItem2.Location = new System.Drawing.Point(380, 41);
            this.lstItem2.Name = "lstItem2";
            this.lstItem2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstItem2.Size = new System.Drawing.Size(208, 186);
            this.lstItem2.TabIndex = 1;
            // 
            // txtItem
            // 
            this.txtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItem.Location = new System.Drawing.Point(65, 242);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(208, 20);
            this.txtItem.TabIndex = 2;
            // 
            // txtItem2
            // 
            this.txtItem2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItem2.Location = new System.Drawing.Point(380, 242);
            this.txtItem2.Name = "txtItem2";
            this.txtItem2.Size = new System.Drawing.Size(208, 20);
            this.txtItem2.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(65, 289);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(208, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(65, 313);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(208, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remover Items Seleccionados";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(65, 337);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(208, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.Location = new System.Drawing.Point(380, 337);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(208, 23);
            this.btnLimpiar2.TabIndex = 9;
            this.btnLimpiar2.Text = "Limpiar";
            this.btnLimpiar2.UseVisualStyleBackColor = true;
            this.btnLimpiar2.Click += new System.EventHandler(this.BtnLimpiar2_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Enabled = false;
            this.btnRemove2.Location = new System.Drawing.Point(380, 313);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(208, 23);
            this.btnRemove2.TabIndex = 8;
            this.btnRemove2.Text = "Remover Items Seleccionados";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.BtnRemove2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Location = new System.Drawing.Point(380, 289);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(208, 23);
            this.btnAgregar2.TabIndex = 7;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.BtnAgregar2_Click);
            // 
            // btnMoveRightAll
            // 
            this.btnMoveRightAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveRightAll.Location = new System.Drawing.Point(305, 56);
            this.btnMoveRightAll.Name = "btnMoveRightAll";
            this.btnMoveRightAll.Size = new System.Drawing.Size(42, 31);
            this.btnMoveRightAll.TabIndex = 10;
            this.btnMoveRightAll.Text = ">>";
            this.btnMoveRightAll.UseVisualStyleBackColor = true;
            this.btnMoveRightAll.Click += new System.EventHandler(this.BtnMoveRightAll_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveRight.Location = new System.Drawing.Point(305, 93);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(42, 31);
            this.btnMoveRight.TabIndex = 11;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.BtnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLeft.Location = new System.Drawing.Point(305, 130);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(42, 31);
            this.btnMoveLeft.TabIndex = 12;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.BtnMoveLeft_Click);
            // 
            // btnMoveLeftAll
            // 
            this.btnMoveLeftAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveLeftAll.Location = new System.Drawing.Point(305, 167);
            this.btnMoveLeftAll.Name = "btnMoveLeftAll";
            this.btnMoveLeftAll.Size = new System.Drawing.Size(42, 31);
            this.btnMoveLeftAll.TabIndex = 13;
            this.btnMoveLeftAll.Text = "<<";
            this.btnMoveLeftAll.UseVisualStyleBackColor = true;
            this.btnMoveLeftAll.Click += new System.EventHandler(this.BtnMoveLeftAll_Click);
            // 
            // frmListas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 389);
            this.Controls.Add(this.btnMoveLeftAll);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.btnMoveRightAll);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnAgregar2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtItem2);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lstItem2);
            this.Controls.Add(this.lstItem);
            this.Name = "frmListas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasar elementos entre 2 listas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItem;
        private System.Windows.Forms.ListBox lstItem2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtItem2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnLimpiar2;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Button btnMoveRightAll;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnMoveLeftAll;
    }
}