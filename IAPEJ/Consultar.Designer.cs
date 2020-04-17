namespace IAPEJ
{
    partial class Consultar
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
            this.bmtro = new System.Windows.Forms.Button();
            this.balmn = new System.Windows.Forms.Button();
            this.qbusca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bmtro
            // 
            this.bmtro.Location = new System.Drawing.Point(28, 104);
            this.bmtro.Name = "bmtro";
            this.bmtro.Size = new System.Drawing.Size(93, 52);
            this.bmtro.TabIndex = 0;
            this.bmtro.Text = "Maestros";
            this.bmtro.UseVisualStyleBackColor = true;
            this.bmtro.Click += new System.EventHandler(this.bmtro_Click);
            // 
            // balmn
            // 
            this.balmn.Location = new System.Drawing.Point(250, 105);
            this.balmn.Name = "balmn";
            this.balmn.Size = new System.Drawing.Size(93, 51);
            this.balmn.TabIndex = 1;
            this.balmn.Text = "Alumnos";
            this.balmn.UseVisualStyleBackColor = true;
            this.balmn.Click += new System.EventHandler(this.balmn_Click);
            // 
            // qbusca
            // 
            this.qbusca.AutoSize = true;
            this.qbusca.Location = new System.Drawing.Point(122, 27);
            this.qbusca.Name = "qbusca";
            this.qbusca.Size = new System.Drawing.Size(129, 17);
            this.qbusca.TabIndex = 2;
            this.qbusca.Text = "¿Que va a buscar?";
            this.qbusca.Click += new System.EventHandler(this.qbusca_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 195);
            this.Controls.Add(this.qbusca);
            this.Controls.Add(this.balmn);
            this.Controls.Add(this.bmtro);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bmtro;
        private System.Windows.Forms.Button balmn;
        private System.Windows.Forms.Label qbusca;
    }
}