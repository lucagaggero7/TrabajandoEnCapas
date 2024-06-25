using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormFin : FrmBase
    {
        public FormFin()
        {
            InitializeComponent();
        }

        private void FormFin_Load(object sender, EventArgs e)
        {
            // Divide el texto para tomar el nombre
            string nombre = ((FormComprar)Owner).txtNombre.Text.Split(' ')[0];

            // Muestra un mensaje de felicitaciones junto al nombre en el label
            lblFin.Text = $"¡¡Felicitaciones por tu compra {nombre}!! \nVuelve pronto...";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Owner.Owner.Owner.Show(); // Muestra el formulario padre

            //Borra todos los productos del carrito ya finalizada la compra
            ((FormCarrito)Owner.Owner).carrito.Productos.Rows.Clear();
        }
    }
}
