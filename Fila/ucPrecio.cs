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
    public partial class ucPrecio : UserControl
    {
        public ucPrecio()
        {
            InitializeComponent();
        }

        public void setImagenModena(Image imagenItem)
        {
            pbImgenMoneda.Image = imagenItem;
        }

        public void setPrecio(string precio)
        {
            lblPrecio.Text = precio;
        }

        public string getPrecio()
        {
            return lblPrecio.Text;
        }
    }
}
