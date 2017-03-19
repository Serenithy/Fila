namespace Fila
{
    partial class ucPrecio
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPrecio));
            this.pbImgenMoneda = new System.Windows.Forms.PictureBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgenMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImgenMoneda
            // 
            this.pbImgenMoneda.Image = ((System.Drawing.Image)(resources.GetObject("pbImgenMoneda.Image")));
            this.pbImgenMoneda.Location = new System.Drawing.Point(100, 0);
            this.pbImgenMoneda.Name = "pbImgenMoneda";
            this.pbImgenMoneda.Size = new System.Drawing.Size(43, 45);
            this.pbImgenMoneda.TabIndex = 6;
            this.pbImgenMoneda.TabStop = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(6, 9);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(97, 23);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "0";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ucPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbImgenMoneda);
            this.Controls.Add(this.lblPrecio);
            this.Name = "ucPrecio";
            this.Size = new System.Drawing.Size(143, 46);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgenMoneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImgenMoneda;
        private System.Windows.Forms.Label lblPrecio;
    }
}
