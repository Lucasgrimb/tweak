namespace pruebaa
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtbnombre = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(162, 59);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(191, 25);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "ingresá tu nombre ";
            this.lblnombre.Click += new System.EventHandler(this.lblnombre_Click);
            // 
            // txtbnombre
            // 
            this.txtbnombre.ForeColor = System.Drawing.Color.Violet;
            this.txtbnombre.Location = new System.Drawing.Point(394, 59);
            this.txtbnombre.Name = "txtbnombre";
            this.txtbnombre.Size = new System.Drawing.Size(100, 31);
            this.txtbnombre.TabIndex = 1;
            this.txtbnombre.TextChanged += new System.EventHandler(this.txtbnombre_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(287, 243);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(259, 72);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "siguiente";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtbnombre);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblnombre;
        public System.Windows.Forms.TextBox txtbnombre;
        public System.Windows.Forms.Button btn1;
    }
}

