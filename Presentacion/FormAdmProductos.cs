using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;


namespace Presentacion
{
    public partial class FormAdmProductos : FrmBase
    {
        public Producto objEntProducto = new Producto();

        public NegProductos objNegProductos = new NegProductos();

        public string index;

        public string accion;

        long Valorverif;
        long Verificacion;

        int codigoclick;
        int nombreclick;
        int marcaclick;
        int categoriaclick;
        int precioclick;
        int stockclick;

        public FormAdmProductos()
        {
            InitializeComponent();
            LlenarDataGrid();
        }

        private void FormAdmProductos_Load(object sender, EventArgs e)
        {
            datagridProductos.ClearSelection();
        }

        private void LlenarDataGrid()
        {
            datagridProductos.DataSource = objNegProductos.ListadoProductos("Todos");
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;

            txtCodigo_Leave(txtCodigo, EventArgs.Empty);
            txtNombre_Leave(txtNombre, EventArgs.Empty);
            txtMarca_Leave(txtMarca, EventArgs.Empty);
            txtCategoria_Leave(txtCategoria, EventArgs.Empty);
            txtPrecio_Leave(txtPrecio, EventArgs.Empty);
            txtStock_Leave(txtStock, EventArgs.Empty);

            FormAdmProductos_Click(this, EventArgs.Empty);
        }

        private void TxtBox_a_Clase(string accion) //Prepara el objeto a enviar a la capa de Negocio
        {
            if (accion == "Buscar o Borrar")
            {
                objEntProducto.CodigoProd = int.Parse(txtCodigo.Text);
            }
            else
            {
                objEntProducto.CodigoProd = int.Parse(txtCodigo.Text);
                objEntProducto.Nombre = txtNombre.Text;
                objEntProducto.Marca = txtMarca.Text;
                objEntProducto.Categoria = txtCategoria.Text;
                objEntProducto.Precio = int.Parse(txtPrecio.Text);
                objEntProducto.Stock = int.Parse(txtStock.Text);
            }
        }

        private void Ds_a_TxtBox(DataSet ds)
        {
            txtCodigo.Text = ds.Tables[0].Rows[0]["CodProf"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtMarca.Text = ds.Tables[0].Rows[0]["Marca"].ToString();
            txtCategoria.Text = ds.Tables[0].Rows[0]["Categoria"].ToString();
            txtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();
            txtStock.Text = ds.Tables[0].Rows[0]["Stock"].ToString();

            txtCodigo.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Verificamos que el codigo sea un valor entero
            if (long.TryParse(txtCodigo.Text, out Verificacion))
            {
                Valorverif = long.Parse(txtCodigo.Text);
                //borro el error 
                errorCodigo.Clear();
            }
            else
            {
                //seteo el error y salgo de la estructura
                errorCodigo.SetError(txtCodigo, "Ingrese un codigo valido");
                return;
            }

            //Verificamos que el codigo no exista ya en la lista de productos
            accion = "Buscar o Borrar";
            TxtBox_a_Clase(accion);
            index = objNegProductos.BuscarProducto(objEntProducto).ToString();
            foreach (DataGridViewRow Row in datagridProductos.Rows)
            {
                String strFila = Row.Index.ToString();
                foreach (DataGridViewCell cell in Row.Cells)
                {
                    string Valor = Convert.ToString(cell.Value);
                    if (Valor != index)
                    {
                        //borro el error 
                        errorCodigo.Clear();
                    }
                    else
                    {
                        //seteo el error y salgo de la estructura
                        errorCodigo.SetError(txtCodigo, "Este codigo ya esta cargado en el la lista");
                        return;
                    }
                }
            }

            //Verificamos que el nombre sea valido
            if (txtNombre.Text != "" && txtNombre.Text != "Nombre")

            {
                //borro el error 
                errorNombre.Clear();
            }
            else
            {
                //seteo el error y salgo de la estructura
                errorNombre.SetError(txtNombre, "Ingrese un nombre valido");
                return;
            }

            //Verificamos que la marca sea valida
            if (txtMarca.Text != "" && txtMarca.Text != "Marca")
            {
                //borro el error 
                errorMarca.Clear();
            }
            else
            {
                //seteo el error y salgo de la estructura
                errorMarca.SetError(txtMarca, "Ingrese una marca valida");
                return;
            }

            //Verificamos que la categoria sea valida
            if (txtCategoria.Text != "" && txtCategoria.Text != "Categoria")
            {
                //borro el error 
                errorCategoria.Clear();
            }
            else
            {
                //seteo el error y salgo de la estructura
                errorCategoria.SetError(txtCategoria, "Ingrese una categoria valida");
                return;
            }

            //Verificamos que el precio sea un valor entero
            if (long.TryParse(txtPrecio.Text, out Verificacion))
            {
                Valorverif = long.Parse(txtPrecio.Text);
                //borro el error
                errorPrecio.Clear();
            }
            else
            {
                //seteo el error y salgo de la estructura
                errorPrecio.SetError(txtPrecio, "Ingrese un precio valido");
                return;
            }

            //Verificamos que el stock sea un valor entero
            if (long.TryParse(txtStock.Text, out Verificacion))

            {
                Valorverif = long.Parse(txtStock.Text);
                //borro el error 
                errorStock.Clear();
            }
            else
            {
                //seteo el error y salgo de la estructura
                errorStock.SetError(txtStock, "Ingrese un stock valido");
                return;
            }


            int nGrabados = -1;
            accion = "Cargar";
            TxtBox_a_Clase(accion);

            //llamo al método que agrega los productos a la base de datos
            nGrabados = objNegProductos.AbmProdcutos("Agregar", objEntProducto); 
                
            if (nGrabados == -1)
            MessageBox.Show ("No se pudo grabar productos en el sistema");
            else
            {
                MessageBox.Show("Se grabó con éxito productos");
                LlenarDataGrid();
                Limpiar();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Verificamos que el codigo sea un valor entero
            if (long.TryParse(txtCodigo.Text, out Verificacion))
            {
                Valorverif = long.Parse(txtCodigo.Text);
                //borro el error 
                errorCodigo.Clear();
            }
            else
            {
                //seteo el error y salgo de la estructura
                errorCodigo.SetError(txtCodigo, "Ingrese un codigo para cargar");
                return;
            }

            int nBorrados = -1;
            accion = "Buscar o Borrar";
            TxtBox_a_Clase(accion);

            //llamo al método que borra el producto de la base ded datos
            nBorrados = objNegProductos.AbmProdcutos("Borrar", objEntProducto);

            if (nBorrados > 0)
            {
                MessageBox.Show("Se borro con éxito productos");
                LlenarDataGrid();
                Limpiar();
            }
            else
            {
                MessageBox.Show("El codigo que ingreso no existe");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Verificamos que el codigo sea un valor entero
            if (long.TryParse(txtCodigo.Text, out Verificacion))
            {
                Valorverif = long.Parse(txtCodigo.Text);
                //borro el error 
                errorCodigo.Clear();
            }
            else
            {
                //seteo el error y salgo de la estructura
                errorCodigo.SetError(txtCodigo, "Ingrese un codigo para buscar");
                return;
            }

            accion = "Buscar o Borrar";
            TxtBox_a_Clase(accion);

            index = objNegProductos.BuscarProducto(objEntProducto).ToString();
            foreach (DataGridViewRow Row in datagridProductos.Rows)
            {
                String strFila = Row.Index.ToString();
                foreach (DataGridViewCell cell in Row.Cells)
                {
                    string Valor = Convert.ToString(cell.Value);
                    if (Valor == index)
                    {
                        datagridProductos.Rows[Convert.ToInt32(strFila)].Selected = true;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("El codigo buscado no existe");
                        datagridProductos.ClearSelection();
                    }
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Owner.Show(); // Muestra el formulario padre
        }

        private void FormAdmProductos_Click(object sender, EventArgs e)
        {
            lblTitulo.Focus();
            datagridProductos.ClearSelection();
        }

        private void panelCarga_Click(object sender, EventArgs e)
        {
            lblTitulo.Focus();
            datagridProductos.ClearSelection();
        }

        private void PanelBarraTitulo_Click(object sender, EventArgs e)
        {
            datagridProductos.ClearSelection();
        }

        private void PanelBarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            FormAdmProductos_Click(sender, e);
        }

        private void txtCodigo_Click(object sender, EventArgs e)
        {
            codigoclick++;

            if (codigoclick >= 1 && txtCodigo.Text == "Codigo")
            {
                txtCodigo.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            nombreclick++;

            if (nombreclick >= 1 && txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtMarca_Click(object sender, EventArgs e)
        {
            marcaclick++;

            if (marcaclick >= 1 && txtMarca.Text == "Marca")
            {
                txtMarca.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCategoria_Click(object sender, EventArgs e)
        {
            categoriaclick++;

            if (categoriaclick >= 1 && txtCategoria.Text == "Categoria")
            {
                txtCategoria.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {
            precioclick++;

            if (precioclick >= 1 && txtPrecio.Text == "Precio")
            {
                txtPrecio.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtStock_Click(object sender, EventArgs e)
        {
            stockclick++;

            if (stockclick >= 1 && txtStock.Text == "Stock")
            {
                txtStock.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            codigoclick++;

            if (codigoclick >= 1 && txtCodigo.Text == "Codigo")
            {
                txtCodigo.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            nombreclick++;

            if (nombreclick >= 1 && txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            marcaclick++;

            if (marcaclick >= 1 && txtMarca.Text == "Marca")
            {
                txtMarca.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            categoriaclick++;

            if (categoriaclick >= 1 && txtCategoria.Text == "Categoria")
            {
                txtCategoria.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            precioclick++;

            if (precioclick >= 1 && txtPrecio.Text == "Precio")
            {
                txtPrecio.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtStock_KeyDown(object sender, KeyEventArgs e)
        {
            stockclick++;

            if (stockclick >= 1 && txtStock.Text == "Stock")
            {
                txtStock.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de borrar (Backspace)
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            // Limitar a 20 caracteres
            if (txtCodigo.Text.Length >= 20 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, números, espacios y la tecla de borrar (Backspace)
            e.Handled = !(Char.IsLetterOrDigit(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || e.KeyChar == 8);

            // Limitar a 20 caracteres
            if (txtNombre.Text.Length >= 20 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y la tecla de borrar (Backspace)
            e.Handled = !(Char.IsLetter(e.KeyChar) || e.KeyChar == 8);

            // Limitar a 20 caracteres
            if (txtMarca.Text.Length >= 20 && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y la tecla de borrar (Backspace)
            e.Handled = !(Char.IsLetter(e.KeyChar) || e.KeyChar == 8);

            // Limitar a 20 caracteres
            if (txtMarca.Text.Length >= 20 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de borrar (Backspace)
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            // Limitar a 9 caracteres
            if (txtPrecio.Text.Length >= 9 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de borrar (Backspace)
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

            // Limitar a 9 caracteres
            if (txtStock.Text.Length >= 9 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = "Codigo";
                txtCodigo.ForeColor = Color.DarkGray;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DarkGray;
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Marca";
                txtMarca.ForeColor = Color.DarkGray;
            }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                txtCategoria.Text = "Categoria";
                txtCategoria.ForeColor = Color.DarkGray;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Precio";
                txtPrecio.ForeColor = Color.DarkGray;
            }
        }

        private void txtStock_Leave(object sender, EventArgs e)
        {
            if (txtStock.Text == "")
            {
                txtStock.Text = "Stock";
                txtStock.ForeColor = Color.DarkGray;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            codigoclick++;
            txtCodigo.ForeColor = Color.Black;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombreclick++;
            txtNombre.ForeColor = Color.Black;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            marcaclick++;
            txtMarca.ForeColor = Color.Black;
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            categoriaclick++;
            txtCategoria.ForeColor = Color.Black;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            precioclick++;
            txtPrecio.ForeColor = Color.Black;
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            stockclick++;
            txtStock.ForeColor = Color.Black;
        }
    }
}
