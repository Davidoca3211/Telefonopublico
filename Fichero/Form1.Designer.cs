namespace Fichero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnq1 = new System.Windows.Forms.Button();
            this.btnq05 = new System.Windows.Forms.Button();
            this.btnq025 = new System.Windows.Forms.Button();
            this.Lbcont = new System.Windows.Forms.Label();
            this.tim100 = new System.Windows.Forms.Timer(this.components);
            this.tim50 = new System.Windows.Forms.Timer(this.components);
            this.tim25 = new System.Windows.Forms.Timer(this.components);
            this.btncolgar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnq1
            // 
            this.btnq1.Location = new System.Drawing.Point(376, 218);
            this.btnq1.Name = "btnq1";
            this.btnq1.Size = new System.Drawing.Size(54, 33);
            this.btnq1.TabIndex = 0;
            this.btnq1.Text = "Q. 1.00";
            this.btnq1.UseVisualStyleBackColor = true;
            this.btnq1.Click += new System.EventHandler(this.btnq1_Click);
            // 
            // btnq05
            // 
            this.btnq05.Location = new System.Drawing.Point(374, 260);
            this.btnq05.Name = "btnq05";
            this.btnq05.Size = new System.Drawing.Size(56, 40);
            this.btnq05.TabIndex = 1;
            this.btnq05.Text = "Q. 0.50";
            this.btnq05.UseVisualStyleBackColor = true;
            this.btnq05.Click += new System.EventHandler(this.btnq05_Click);
            // 
            // btnq025
            // 
            this.btnq025.Location = new System.Drawing.Point(376, 315);
            this.btnq025.Name = "btnq025";
            this.btnq025.Size = new System.Drawing.Size(54, 35);
            this.btnq025.TabIndex = 2;
            this.btnq025.Text = "Q. 0.25";
            this.btnq025.UseVisualStyleBackColor = true;
            this.btnq025.Click += new System.EventHandler(this.btnq025_Click);
            // 
            // Lbcont
            // 
            this.Lbcont.AutoSize = true;
            this.Lbcont.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbcont.Location = new System.Drawing.Point(378, 119);
            this.Lbcont.Name = "Lbcont";
            this.Lbcont.Size = new System.Drawing.Size(52, 29);
            this.Lbcont.TabIndex = 3;
            this.Lbcont.Text = "000";
            this.Lbcont.Click += new System.EventHandler(this.Lbcont_Click);
            // 
            // tim100
            // 
            this.tim100.Interval = 1000;
            this.tim100.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tim50
            // 
            this.tim50.Interval = 1000;
            this.tim50.Tick += new System.EventHandler(this.tim50_Tick);
            // 
            // tim25
            // 
            this.tim25.Interval = 1000;
            this.tim25.Tick += new System.EventHandler(this.tim25_Tick);
            // 
            // btncolgar
            // 
            this.btncolgar.Location = new System.Drawing.Point(111, 198);
            this.btncolgar.Name = "btncolgar";
            this.btncolgar.Size = new System.Drawing.Size(76, 36);
            this.btncolgar.TabIndex = 4;
            this.btncolgar.Text = "Colgar";
            this.btncolgar.UseVisualStyleBackColor = true;
            this.btncolgar.Click += new System.EventHandler(this.btncolgar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fichero.Properties.Resources.Telefono;
            this.ClientSize = new System.Drawing.Size(517, 467);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncolgar);
            this.Controls.Add(this.Lbcont);
            this.Controls.Add(this.btnq025);
            this.Controls.Add(this.btnq05);
            this.Controls.Add(this.btnq1);
            this.Name = "Form1";
            this.Text = "Telefono";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnq1;
        private System.Windows.Forms.Button btnq05;
        private System.Windows.Forms.Button btnq025;
        private System.Windows.Forms.Label Lbcont;
        private System.Windows.Forms.Timer tim100;
        private System.Windows.Forms.Timer tim50;
        private System.Windows.Forms.Timer tim25;
        private System.Windows.Forms.Button btncolgar;
        private System.Windows.Forms.Button button2;
    }
}

