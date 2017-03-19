using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fila
{
    public partial class ItemBuy : UserControl
    {
        public ItemBuy()
        {
            InitializeComponent();
        }

        public void setImageItem(Image imagenItem)
        {
            pbImagenItem.Image = imagenItem;
        }

        public void setImageMoneda(Image imagenMoneda)
        {
            pbImgenMoneda.Image = imagenMoneda;
        }

        public void setPrecioItem(string precio)
        {
            lblPrecio.Text = precio;
        }

        public void setColorItem(Color color)
        {
            lblPrecio.ForeColor = color;
        }

        public string getPrecioItem()
        {
            return lblPrecio.Text;
        }
    }
}
