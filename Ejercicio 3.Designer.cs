namespace WindowsFormsApp8
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
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCalcularProm = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(103, 75);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 0;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(115, 197);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(100, 20);
            this.tbResultado.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(252, 75);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCalcularProm
            // 
            this.btnCalcularProm.Location = new System.Drawing.Point(252, 143);
            this.btnCalcularProm.Name = "btnCalcularProm";
            this.btnCalcularProm.Size = new System.Drawing.Size(116, 23);
            this.btnCalcularProm.TabIndex = 3;
            this.btnCalcularProm.Text = "Calcular Promedio";
            this.btnCalcularProm.UseVisualStyleBackColor = true;
            this.btnCalcularProm.Click += new System.EventHandler(this.btnCalcularProm_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(100, 148);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(35, 13);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Promedio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCalcularProm);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCalcularProm;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

