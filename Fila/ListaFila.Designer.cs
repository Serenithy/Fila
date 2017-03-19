namespace Fila
{
    partial class ListaFila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaFila));
            this.pbImagenItem = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pbImgenMoneda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgenMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenItem
            // 
            this.pbImagenItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbImagenItem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagenItem.Image")));
            this.pbImagenItem.Location = new System.Drawing.Point(12, 13);
            this.pbImagenItem.Name = "pbImagenItem";
            this.pbImagenItem.Size = new System.Drawing.Size(42, 42);
            this.pbImagenItem.TabIndex = 0;
            this.pbImagenItem.TabStop = false;
            this.pbImagenItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listaFila_MouseDown);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(72, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(232, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listaFila_MouseDown);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(362, 22);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(97, 23);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "0";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrecio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listaFila_MouseDown);
            // 
            // pbImgenMoneda
            // 
            this.pbImgenMoneda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImgenMoneda.Image = ((System.Drawing.Image)(resources.GetObject("pbImgenMoneda.Image")));
            this.pbImgenMoneda.Location = new System.Drawing.Point(456, 13);
            this.pbImgenMoneda.Name = "pbImgenMoneda";
            this.pbImgenMoneda.Size = new System.Drawing.Size(39, 45);
            this.pbImgenMoneda.TabIndex = 4;
            this.pbImgenMoneda.TabStop = false;
            this.pbImgenMoneda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listaFila_MouseDown);
            // 
            // ListaFila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(11)))));
            this.Controls.Add(this.pbImgenMoneda);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbImagenItem);
            this.Name = "ListaFila";
            this.Size = new System.Drawing.Size(498, 61);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listaFila_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgenMoneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenItem;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.PictureBox pbImgenMoneda;
    }
}
