namespace ProyWinC_Sem03
{
    partial class MDIPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejemplosSemana3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplosSemana3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejemplosSemana3ToolStripMenuItem
            // 
            this.ejemplosSemana3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplo1ToolStripMenuItem,
            this.ejemplo2ToolStripMenuItem,
            this.ejemplo3ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reiniciarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ejemplosSemana3ToolStripMenuItem.Image = global::ProyWinC_Sem03.Properties.Resources.Home2;
            this.ejemplosSemana3ToolStripMenuItem.Name = "ejemplosSemana3ToolStripMenuItem";
            this.ejemplosSemana3ToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.ejemplosSemana3ToolStripMenuItem.Text = "Ejemplos Semana 3";
            // 
            // ejemplo1ToolStripMenuItem
            // 
            this.ejemplo1ToolStripMenuItem.Image = global::ProyWinC_Sem03.Properties.Resources.user1;
            this.ejemplo1ToolStripMenuItem.Name = "ejemplo1ToolStripMenuItem";
            this.ejemplo1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejemplo1ToolStripMenuItem.Text = "Ejemplo 1";
            this.ejemplo1ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo1ToolStripMenuItem_Click);
            // 
            // ejemplo2ToolStripMenuItem
            // 
            this.ejemplo2ToolStripMenuItem.Image = global::ProyWinC_Sem03.Properties.Resources.hat_gray;
            this.ejemplo2ToolStripMenuItem.Name = "ejemplo2ToolStripMenuItem";
            this.ejemplo2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejemplo2ToolStripMenuItem.Text = "Ejemplo 2";
            this.ejemplo2ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo2ToolStripMenuItem_Click);
            // 
            // ejemplo3ToolStripMenuItem
            // 
            this.ejemplo3ToolStripMenuItem.Image = global::ProyWinC_Sem03.Properties.Resources.note;
            this.ejemplo3ToolStripMenuItem.Name = "ejemplo3ToolStripMenuItem";
            this.ejemplo3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejemplo3ToolStripMenuItem.Text = "Ejemplo 3";
            this.ejemplo3ToolStripMenuItem.Click += new System.EventHandler(this.ejemplo3ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Image = global::ProyWinC_Sem03.Properties.Resources.RefreshCL;
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ProyWinC_Sem03.Properties.Resources.Shutdown_32x32_32;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal Semana 3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejemplosSemana3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplo3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}