namespace Cartelera
{
    partial class CarteleraCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.DGVPeliculas = new System.Windows.Forms.DataGridView();
            this.txtBuscaNumbre = new System.Windows.Forms.TextBox();
            this.cbxClasificacion = new System.Windows.Forms.ComboBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.btnAscendente = new System.Windows.Forms.Button();
            this.btnDescendente = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscarClasifica = new System.Windows.Forms.Button();
            this.btnBuscarGenero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.- Buscar Por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.- Buscar Por Clasificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "3.- Buscar Por Genero";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(507, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DGVPeliculas
            // 
            this.DGVPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPeliculas.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DGVPeliculas.Location = new System.Drawing.Point(34, 152);
            this.DGVPeliculas.Name = "DGVPeliculas";
            this.DGVPeliculas.RowHeadersWidth = 51;
            this.DGVPeliculas.RowTemplate.Height = 24;
            this.DGVPeliculas.Size = new System.Drawing.Size(593, 243);
            this.DGVPeliculas.TabIndex = 15;
            // 
            // txtBuscaNumbre
            // 
            this.txtBuscaNumbre.Location = new System.Drawing.Point(288, 20);
            this.txtBuscaNumbre.Name = "txtBuscaNumbre";
            this.txtBuscaNumbre.Size = new System.Drawing.Size(240, 22);
            this.txtBuscaNumbre.TabIndex = 16;
            // 
            // cbxClasificacion
            // 
            this.cbxClasificacion.FormattingEnabled = true;
            this.cbxClasificacion.Items.AddRange(new object[] {
            "elige una opcion "});
            this.cbxClasificacion.Location = new System.Drawing.Point(288, 53);
            this.cbxClasificacion.Name = "cbxClasificacion";
            this.cbxClasificacion.Size = new System.Drawing.Size(240, 24);
            this.cbxClasificacion.TabIndex = 17;
            // 
            // cbxGenero
            // 
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "elige una opcion "});
            this.cbxGenero.Location = new System.Drawing.Point(288, 88);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(240, 24);
            this.cbxGenero.TabIndex = 18;
            // 
            // btnAscendente
            // 
            this.btnAscendente.Location = new System.Drawing.Point(34, 400);
            this.btnAscendente.Name = "btnAscendente";
            this.btnAscendente.Size = new System.Drawing.Size(76, 38);
            this.btnAscendente.TabIndex = 19;
            this.btnAscendente.Text = "↑";
            this.btnAscendente.UseVisualStyleBackColor = true;
            this.btnAscendente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDescendente
            // 
            this.btnDescendente.Location = new System.Drawing.Point(117, 400);
            this.btnDescendente.Name = "btnDescendente";
            this.btnDescendente.Size = new System.Drawing.Size(75, 38);
            this.btnDescendente.TabIndex = 20;
            this.btnDescendente.Text = "↓";
            this.btnDescendente.UseVisualStyleBackColor = true;
            this.btnDescendente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(551, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 24);
            this.button2.TabIndex = 22;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnBuscarClasifica
            // 
            this.btnBuscarClasifica.Location = new System.Drawing.Point(551, 53);
            this.btnBuscarClasifica.Name = "btnBuscarClasifica";
            this.btnBuscarClasifica.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarClasifica.TabIndex = 23;
            this.btnBuscarClasifica.Text = "Buscar";
            this.btnBuscarClasifica.UseVisualStyleBackColor = true;
            this.btnBuscarClasifica.Click += new System.EventHandler(this.btnBuscarClasifica_Click);
            // 
            // btnBuscarGenero
            // 
            this.btnBuscarGenero.Location = new System.Drawing.Point(551, 88);
            this.btnBuscarGenero.Name = "btnBuscarGenero";
            this.btnBuscarGenero.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarGenero.TabIndex = 24;
            this.btnBuscarGenero.Text = "Buscar";
            this.btnBuscarGenero.UseVisualStyleBackColor = true;
            this.btnBuscarGenero.Click += new System.EventHandler(this.btnBuscarGenero_Click);
            // 
            // CarteleraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.btnBuscarGenero);
            this.Controls.Add(this.btnBuscarClasifica);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnDescendente);
            this.Controls.Add(this.btnAscendente);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.cbxClasificacion);
            this.Controls.Add(this.txtBuscaNumbre);
            this.Controls.Add(this.DGVPeliculas);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarteleraCliente";
            this.Text = "Cartelera";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView DGVPeliculas;
        private System.Windows.Forms.TextBox txtBuscaNumbre;
        private System.Windows.Forms.ComboBox cbxClasificacion;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Button btnAscendente;
        private System.Windows.Forms.Button btnDescendente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscarClasifica;
        private System.Windows.Forms.Button btnBuscarGenero;
    }
}