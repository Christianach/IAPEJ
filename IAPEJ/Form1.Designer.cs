namespace IAPEJ
{
    partial class logo
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
            this.Ingreso = new System.Windows.Forms.Button();
            this.consulta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ingreso
            // 
            this.Ingreso.Location = new System.Drawing.Point(616, 326);
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.Size = new System.Drawing.Size(121, 71);
            this.Ingreso.TabIndex = 1;
            this.Ingreso.Text = "ingresar";
            this.Ingreso.UseVisualStyleBackColor = true;
            this.Ingreso.Click += new System.EventHandler(this.Ingreso_Click);
            // 
            // consulta
            // 
            this.consulta.Location = new System.Drawing.Point(65, 326);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(133, 71);
            this.consulta.TabIndex = 2;
            this.consulta.Text = "consultar";
            this.consulta.UseVisualStyleBackColor = true;
            this.consulta.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IAPEJ.Properties.Resources.IAPEJ;
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.consulta);
            this.Controls.Add(this.Ingreso);
            this.Name = "logo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Ingreso;
        private System.Windows.Forms.Button consulta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

