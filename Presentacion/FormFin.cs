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

            // Divide el texto por espacios y toma la primera palabra
            string nombre = ((FormComprar)Owner).txtNombre.Text.Split(' ')[0];

            // Asegúrate de que este código se ejecute en el contexto adecuado, por ejemplo, después de una compra exitosa
            lblFin.Text = $"¡¡Felicitaciones por tu compra {nombre}!! \nVuelve pronto...";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Owner.Owner.Owner.Show(); // Muestra el formulario padre

            ((FormCarrito)Owner.Owner).carrito.Productos.Rows.Clear();
        }
    }
}
