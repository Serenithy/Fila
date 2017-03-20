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
    /// UserControl para la visualizacion de los Items en el panel lista
    /// </summary>
    public partial class ListaFila : UserControl
    {
        /// <summary>
        /// Constructor e inicializacion de los componentes del UserControl
        /// </summary>
        public ListaFila()
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
        /// Cambia la imagen de las modenas del UserControl
        /// </summary>
        /// <param name="imagenMoneda"></param>
        public void setImageMoneda(Image imagenMoneda)
        {
            pbImgenMoneda.Image = imagenMoneda;
        }

        /// <summary>
        /// Cambia el nombre del Item del UserControl
        /// </summary>
        /// <param name="nombre"></param>
        public void setNombreItem(string nombre)
        {
            lblNombre.Text = nombre;
        }

        /// <summary>
        /// Cambia el precio del Item del UserControl
        /// </summary>
        /// <param name="precio"></param>
        public void setPrecioItem(string precio)
        {
            lblPrecio.Text = precio;
        }

        /// <summary>
        /// Cambia el color del nombre del Item del UserControl
        /// </summary>
        /// <param name="color"></param>
        public void setColorItem(Color color)
        {
            lblNombre.ForeColor = color;
        }

        /// <summary>
        /// Cambia el texto de ayuda del UserControl
        /// </summary>
        /// <param name="tooltip"></param>
        public void setToolTip(string tooltip)
        {
            tooltip.Contains(tooltip);
        }

        /// <summary>
        /// Devuleve la imagen del Item del UserControl
        /// </summary>
        /// <returns></returns>
        public Image getImageItem()
        {
            return pbImagenItem.Image;
        }

        /// <summary>
        /// Devuelve el nombre del Item del UserControl
        /// </summary>
        /// <returns></returns>
        public string getNombreItem()
        {
            return lblNombre.Text;
        }

        /// <summary>
        /// Devuelve el precio del Item del UserControl
        /// </summary>
        /// <returns></returns>
        public string getPrecioItem()
        {
            return lblPrecio.Text;
        }

        /// <summary>
        /// Metodo para guardar los datos necesarios y establecer el DragandDrop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
