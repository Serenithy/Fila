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
    /// UserControl para la visualizacion del precio o saldo, y la imagen de la moneda
    /// </summary>
    public partial class ucPrecio : UserControl
    {
        /// <summary>
        /// Constructor e inicializacion de los componentes del UserControl
        /// </summary>
        public ucPrecio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cambia la imagen de la moneda del UserControl
        /// </summary>
        /// <param name="imagenItem"></param>
        public void setImagenModena(Image imagenItem)
        {
            pbImgenMoneda.Image = imagenItem;
        }

        /// <summary>
        /// Cambia el precio del UserControl
        /// </summary>
        /// <param name="precio"></param>
        public void setPrecio(string precio)
        {
            lblPrecio.Text = precio;
        }

        /// <summary>
        /// Devuelve el precio del UserControl
        /// </summary>
        /// <returns></returns>
        public string getPrecio()
        {
            return lblPrecio.Text;
        }
    }
}
