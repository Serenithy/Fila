namespace Fila
{
    partial class ItemBuy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemBuy));
            this.pbImagenItem = new System.Windows.Forms.PictureBox();
            this.pbImgenMoneda = new System.Windows.Forms.PictureBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgenMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagenItem
            // 
            this.pbImagenItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbImagenItem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagenItem.Image")));
            this.pbImagenItem.Location = new System.Drawing.Point(3, 5);
            this.pbImagenItem.Name = "pbImagenItem";
            this.pbImagenItem.Size = new System.Drawing.Size(42, 42);
            this.pbImagenItem.TabIndex = 1;
            this.pbImagenItem.TabStop = false;
            // 
            // pbImgenMoneda
            // 
            this.pbImgenMoneda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImgenMoneda.Image = ((System.Drawing.Image)(resources.GetObject("pbImgenMoneda.Image")));
            this.pbImgenMoneda.Location = new System.Drawing.Point(172, 3);
            this.pbImgenMoneda.Name = "pbImgenMoneda";
            this.pbImgenMoneda.Size = new System.Drawing.Size(39, 45);
            this.pbImgenMoneda.TabIndex = 6;
            this.pbImgenMoneda.TabStop = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(78, 12);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(97, 23);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "0";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(11)))));
            this.Controls.Add(this.pbImgenMoneda);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.pbImagenItem);
            this.Name = "ItemBuy";
            this.Size = new System.Drawing.Size(214, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgenMoneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenItem;
        private System.Windows.Forms.PictureBox pbImgenMoneda;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
