namespace Cartelera
{
    partial class Admin
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAltaPelicula = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(189, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAltaPelicula
            // 
            this.btnAltaPelicula.Location = new System.Drawing.Point(24, 22);
            this.btnAltaPelicula.Name = "btnAltaPelicula";
            this.btnAltaPelicula.Size = new System.Drawing.Size(284, 28);
            this.btnAltaPelicula.TabIndex = 8;
            this.btnAltaPelicula.Text = "1.- Alta de Película";
            this.btnAltaPelicula.UseVisualStyleBackColor = true;
            this.btnAltaPelicula.Click += new System.EventHandler(this.btnAltaPelicula_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(284, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "3.- Baja de Película";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(24, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(284, 28);
            this.button5.TabIndex = 12;
            this.button5.Text = "5.- Modificar Película";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(284, 28);
            this.button6.TabIndex = 13;
            this.button6.Text = "6.- Consultar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(331, 277);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAltaPelicula);
            this.Controls.Add(this.btnExit);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAltaPelicula;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}