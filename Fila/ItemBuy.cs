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
    /// <summary>
    /// UserControl para la visualizacion del item de compra
    /// </summary>
    public partial class ItemBuy : UserControl
    {
        /// <summary>
        /// Constructor y inicializacion de los componenetes del UserControl
        /// </summary>
        public ItemBuy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cambia la imagen del Item del UserControl
        /// </summary>
        /// <param name="imagenItem"></param>
        public void setImageItem(Image imagenItem)
        {
            pbImagenItem.Image = imagenItem;
        }

        /// <summary>
        /// Cambia la imagen de la moneda del UserControl
        /// </summary>
        /// <param name="imagenMoneda"></param>
        public void setImageMoneda(Image imagenMoneda)
        {
            pbImgenMoneda.Image = imagenMoneda;
        }

        /// <summary>
        /// Cambia el precio del item del UserControl
        /// </summary>
        /// <param name="precio"></param>
        public void setPrecioItem(string precio)
        {
            lblPrecio.Text = precio;
        }

        /// <summary>
        /// Cambia el color precio del item del UserControl
        /// </summary>
        /// <param name="color"></param>
        public void setColorItem(Color color)
        {
            lblPrecio.ForeColor = color;
        }

        /// <summary>
        /// Devuelve el precio del Item del UserControl
        /// </summary>
        /// <returns></returns>
        public string getPrecioItem()
        {
            return lblPrecio.Text;
        }
    }
}
