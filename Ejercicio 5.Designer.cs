namespace WindowsFormsApp10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListarOrdenado = new System.Windows.Forms.Button();
            this.btnMinimo = new System.Windows.Forms.Button();
            this.btnCalcularProm = new System.Windows.Forms.Button();
            this.btnMayoresAlPromedio = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbMaximo = new System.Windows.Forms.Label();
            this.lbMinimo = new System.Windows.Forms.Label();
            this.btnMaximo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promedio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minimo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(200, 50);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListarOrdenado
            // 
            this.btnListarOrdenado.Location = new System.Drawing.Point(245, 273);
            this.btnListarOrdenado.Name = "btnListarOrdenado";
            this.btnListarOrdenado.Size = new System.Drawing.Size(115, 34);
            this.btnListarOrdenado.TabIndex = 5;
            this.btnListarOrdenado.Text = "Listar Ordenado";
            this.btnListarOrdenado.UseVisualStyleBackColor = true;
            this.btnListarOrdenado.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMinimo
            // 
            this.btnMinimo.Location = new System.Drawing.Point(200, 236);
            this.btnMinimo.Name = "btnMinimo";
            this.btnMinimo.Size = new System.Drawing.Size(97, 23);
            this.btnMinimo.TabIndex = 6;
            this.btnMinimo.Text = "Calcular Minimo";
            this.btnMinimo.UseVisualStyleBackColor = true;
            this.btnMinimo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCalcularProm
            // 
            this.btnCalcularProm.Location = new System.Drawing.Point(200, 114);
            this.btnCalcularProm.Name = "btnCalcularProm";
            this.btnCalcularProm.Size = new System.Drawing.Size(119, 23);
            this.btnCalcularProm.TabIndex = 7;
            this.btnCalcularProm.Text = "Calcular Promedio";
            this.btnCalcularProm.UseVisualStyleBackColor = true;
            this.btnCalcularProm.Click += new System.EventHandler(this.btnCalcularProm_Click);
            // 
            // btnMayoresAlPromedio
            // 
            this.btnMayoresAlPromedio.Location = new System.Drawing.Point(245, 326);
            this.btnMayoresAlPromedio.Name = "btnMayoresAlPromedio";
            this.btnMayoresAlPromedio.Size = new System.Drawing.Size(115, 36);
            this.btnMayoresAlPromedio.TabIndex = 8;
            this.btnMayoresAlPromedio.Text = "Listado Superior al Promedio";
            this.btnMayoresAlPromedio.UseVisualStyleBackColor = true;
            this.btnMayoresAlPromedio.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(26, 273);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(149, 273);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(56, 328);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(100, 20);
            this.tbResultado.TabIndex = 11;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(75, 52);
            this.tbValor.Multiline = true;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 12;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(96, 119);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(35, 13);
            this.lbResultado.TabIndex = 13;
            this.lbResultado.Text = "label5";
            // 
            // lbMaximo
            // 
            this.lbMaximo.AutoSize = true;
            this.lbMaximo.Location = new System.Drawing.Point(103, 176);
            this.lbMaximo.Name = "lbMaximo";
            this.lbMaximo.Size = new System.Drawing.Size(35, 13);
            this.lbMaximo.TabIndex = 14;
            this.lbMaximo.Text = "label6";
            this.lbMaximo.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbMinimo
            // 
            this.lbMinimo.AutoSize = true;
            this.lbMinimo.Location = new System.Drawing.Point(103, 236);
            this.lbMinimo.Name = "lbMinimo";
            this.lbMinimo.Size = new System.Drawing.Size(35, 13);
            this.lbMinimo.TabIndex = 15;
            this.lbMinimo.Text = "label7";
            // 
            // btnMaximo
            // 
            this.btnMaximo.Location = new System.Drawing.Point(200, 176);
            this.btnMaximo.Name = "btnMaximo";
            this.btnMaximo.Size = new System.Drawing.Size(97, 23);
            this.btnMaximo.TabIndex = 16;
            this.btnMaximo.Text = "Calcular Maximo";
            this.btnMaximo.UseVisualStyleBackColor = true;
            this.btnMaximo.Click += new System.EventHandler(this.btnMaximo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.btnMaximo);
            this.Controls.Add(this.lbMinimo);
            this.Controls.Add(this.lbMaximo);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.btnMayoresAlPromedio);
            this.Controls.Add(this.btnCalcularProm);
            this.Controls.Add(this.btnMinimo);
            this.Controls.Add(this.btnListarOrdenado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListarOrdenado;
        private System.Windows.Forms.Button btnMinimo;
        private System.Windows.Forms.Button btnCalcularProm;
        private System.Windows.Forms.Button btnMayoresAlPromedio;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbMaximo;
        private System.Windows.Forms.Label lbMinimo;
        private System.Windows.Forms.Button btnMaximo;
    }
}

