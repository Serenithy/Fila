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
    public partial class ListaFila : UserControl
    {
        public ListaFila()
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

        public void setNombreItem(string nombre)
        {
            lblNombre.Text = nombre;
        }

        public void setPrecioItem(string precio)
        {
            lblPrecio.Text = precio;
        }

        public void setColorItem(Color color)
        {
            lblNombre.ForeColor = color;
        }

        public void setToolTip(string tooltip)
        {
            tooltip.Contains(tooltip);
        }

        public Image getImageItem()
        {
            return pbImagenItem.Image;
        }

        public string getNombreItem()
        {
            return lblNombre.Text;
        }

        public string getPrecioItem()
        {
            return lblPrecio.Text;
        }

        private void listaFila_MouseDown (object sender, MouseEventArgs e)
        {
            List<object> saveDates = new List<object>();
            saveDates.Add(pbImagenItem.Image);
            saveDates.Add(lblPrecio.Text);
            saveDates.Add(lblNombre.ForeColor);

            this.DoDragDrop(saveDates, DragDropEffects.Copy);
        }
    }
}
