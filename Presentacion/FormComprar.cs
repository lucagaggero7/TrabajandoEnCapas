using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Presentacion
{
    public partial class FormComprar : FrmBase
    {
        //variables que cuentan los clicks de los textbox para simular placeholders
        int nombreclick = 0;
        int direccionclick = 0;
        int localidadclick = 0;
        int codpostalclick = 0;
        int telefonoclick = 0;
        int dniclick = 0;
        //

        public string accion;

        public Usuario objEntUsuario = new Usuario();

        public Carrito carrito = new Carrito();

        public NegProductos objNegProductos = new NegProductos();

        public NegUsuarios objNegUsuarios = new NegUsuarios();

        public FormComprar()
        {
            InitializeComponent();
            timerCarga.Interval = 600;
            progressFin.Maximum = 100;
        }

        private void FormComprar_Load(object sender, EventArgs e)
        {
            // Trae los campos redundantes para la lista Resumen
            foreach (DataGridViewRow row in ((FormCarrito)Owner).datagridCarrito.Rows)
            {
                string nombre = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                string marca = row.Cells["Marca"].Value?.ToString() ?? string.Empty;
                string precio = row.Cells["Precio"].Value?.ToString() ?? string.Empty;

                // Formatea la cadena para el items de listResumen y lo añade
                listResumen.Items.Add($"{nombre}, {marca}, ${precio}");
            }

            // Trae los campos redundantes para la lista Carrito (solo el codigo)
            foreach (DataGridViewRow row in ((FormCarrito)Owner).datagridCarrito.Rows)
            {
                string codigo = row.Cells["Codigo"].Value?.ToString() ?? string.Empty;

                // Formatea la cadena para el items de listCarrito y lo añade
                listCarrito.Items.Add($"{codigo}");
            }

            //Calcula el subtotal
            lblSubtotal.Text = $"Productos: {listResumen.Items.Count}";

            decimal total = 0m;
            foreach (DataGridViewRow row in ((FormCarrito)Owner).datagridCarrito.Rows)
            {
                if (row.Cells["Precio"].Value != null)
                {
                    string precioStr = row.Cells["Precio"].Value.ToString();
                    if (decimal.TryParse(precioStr, out decimal precio))
                    {
                        total += precio;
                    }
                }
            }

            lblSubtotal.Text = $"Subtotal: ${total}";

            decimal totalConIVA = total * 1.21m; // Suma el 21% al total
            lblNTotal.Text = "$" + totalConIVA.ToString("N2"); // Formatea y muestra el resultado

            decimal iva = total * 0.21m; // Calcula el 21% de IVA del total
            lblIva.Text = "(IVA incluido $" + iva.ToString("N2") + ")"; // Formatea y muestra el IVA

            //Cuenta los productos del carrito
            lblProductos.Text = listResumen.Items.Count.ToString() + " Productos";

            //Ejecutamos los evenetos leave para ahorrar repeticiones de codigo
            txtNombre_Leave(sender, e);
            txtDireccion_Leave(sender, e);
            txtLocalidad_Leave(sender, e);
            txtCodPostal_Leave(sender, e);
            txtTelefono_Leave(sender, e);
            txtDni_Leave(sender, e);
            //

            //Sacamos el foco de los textbox para no generar bugs del cursor
            lblResumen.Focus();
            this.ActiveControl = lblResumen;

            //Personalizamos el richtextbox Campos
            rtbCampos.Rtf = @"{\rtf1\ansi \cf1\b * \cf0\b0 Campos Obligatorios\par}";
            rtbCampos.Select(0, 1); // Selecciona solo el asterisco
            rtbCampos.SelectionColor = Color.Red; // Cambia el color del texto seleccionado a rojo
            rtbCampos.DeselectAll(); // Deselecciona el texto

            //Simulamos un placeholder en el combobox Provincia
            txtProvincia.SelectedItem = "Provincia";
        }

        private void TxtBox_a_Clase(string accion) //Prepara el objeto a enviar a la capa de Negocio
        {
            if (accion == "Comprar")
            {
                objEntUsuario.Nombre = txtNombre.Text;
                objEntUsuario.Direccion = txtDireccion.Text;
                objEntUsuario.Provincia = txtProvincia.Text;
                objEntUsuario.Localidad = txtLocalidad.Text;
                objEntUsuario.CodPostal = int.Parse(txtCodPostal.Text);
                objEntUsuario.Telefono = Int64.Parse(txtTelefono.Text);
                objEntUsuario.Dni = int.Parse(txtDni.Text);
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Valida el nombre y apellido
            if (EsNombreValido(txtNombre.Text))
            {
                errorNombre.Clear(); // Limpia el mensaje de error si es válido
            }
            else
            {
                // Setea el error y sale de la estructura
                errorNombre.SetError(panelNombre, "Ingrese un nombre y apellido válidos.");
                return;
            }

            // Valida la direccion
            if (EsDireccionValida(txtDireccion.Text))
            {
                errorDireccion.Clear(); // Limpia el mensaje de error si es válido
            }
            else
            {
                // Setea el error y sale de la estructura
                errorDireccion.SetError(panelDireccion, "Ingrese la primera línea de la dirección.");
                return;
            }

            // Valida la provincia
            if (txtProvincia.Text != "Provincia" || txtProvincia.Text != "")
            {
                errorProvincia.Clear(); // Limpia el mensaje de error si es válido
            }
            else
            {
                // Setea el error y sale de la estructura
                errorProvincia.SetError(panelProvincia, "Seleccione una provincia");
                return;
            }

            // Valida la Localidad
            if (txtLocalidad.Text != "Localidad" || txtLocalidad.Text != "")
            {
                errorLocalidad.Clear(); // Limpia el mensaje de error si es válido
            }
            else
            {
                // Setea el error y sale de la estructura
                errorLocalidad.SetError(panelLocalidad, "Ingrese una localidad valida");
                return;
            }

            // Valida el codigo postal
            if (EsCodigoPostalValido(txtCodPostal.Text))
            {
                errorCodigoPostal.Clear(); // Limpia el mensaje de error si es válido
            }
            else
            {
                // Setea el error y sale de la estructura
                errorCodigoPostal.SetError(panelCodPostal, "El código postal no es válido.");
                return;
            }

            // Elimina todos los caracteres de telefono que no sean numeros
            string digitsOnly = new String(txtTelefono.Text.Where(char.IsDigit).ToArray());

            // Verifica si la longitud del telefono está fuera del rango permitido
            if (digitsOnly.Length < 8 || digitsOnly.Length > 15)
            {
                if (txtTelefono.Text == "Telefono (8 a 15 digitos)")
                {
                    errorTelefono.Clear(); // Limpia el mensaje de error si es válido
                    txtTelefono.Text = "0";
                }
                else
                {
                    // Setea el error y sale de la estructura
                    errorTelefono.SetError(panelTelefono, "Debe ingresar un telefono valido");
                    return;
                }
            }
            else
            {
                errorTelefono.Clear(); // Limpia el mensaje de error si es válido
            }

            // Valida el Dni
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDni.Text, @"^\d{8}$"))
            {
                errorDni.Clear(); // Limpia el mensaje de error si es válido
            }
            else
            {
                // Setea el error y sale de la estructura
                errorDni.SetError(panelDni, "El DNI debe tener 8 dígitos numéricos.");
                return;
            }

            // Inicia el timer para la barra de progreso
            timerCarga.Start();
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            if (progressFin.Value < 95)
            {
                progressFin.Increment(10);
                progressFin.Update();
            }
            else
            {
                // Cuando se produce un tick en el timer
                // y la barra de progreso llega a 95 detiene el timer
                timerCarga.Stop(); 

                //Al detenerse el timer ejecuta la compra y muestra el form de finalizacion               
                FormFin frm7 = new FormFin();
                this.AddOwnedForm(frm7);
                frm7.Show();
                this.Hide();

                accion = "Comprar";
                TxtBox_a_Clase(accion);

                int nComprados = -1;

                // Diccionario para rastrear las repeticiones
                Dictionary<string, int> repetitions = new Dictionary<string, int>();

                // Recorre todos los elementos en la listCarrito
                foreach (var item in listCarrito.Items)
                {
                    string itemString = item.ToString();
                    if (repetitions.ContainsKey(itemString))
                    {
                        repetitions[itemString]++;
                    }
                    else
                    {
                        repetitions[itemString] = 1;
                    }
                }

                // Construye el string de salida con repeticiones
                List<string> listaProductosRepetidos = new List<string>();
                foreach (var kvp in repetitions)
                {
                    string producto = kvp.Key;
                    int cantidad = kvp.Value;
                    for (int i = 0; i < cantidad; i++)
                    {
                        listaProductosRepetidos.Add(producto);
                    }
                }

                // Convierte la lista de productos repetidos en un solo string
                string listaProductos = string.Join(", ", listaProductosRepetidos);

                // Ejecuta el método que carga los datos de compra en la base de datos
                nComprados = objNegUsuarios.Compra("Comprar", objEntUsuario, listaProductos);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Owner.Show(); // Muestra el formulario padre

        }

        private void FormComprar_Click(object sender, EventArgs e)
        {
            // Cambia los focos para evitar bugs en los controles
            lblResumen.Focus();
            this.ActiveControl = lblResumen;
        }

        private void txtProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProvincia.ForeColor = Color.Black;

            // Quita el highlight bugeado del combobox
            this.ActiveControl = null;
        }

        private void txtProvincia_DropDown(object sender, EventArgs e)
        {
            // Quita el item que simula el placeholder en el combobox de Provincias
            // una vez que este se abre por primera vez
            txtProvincia.Items.Remove("Provincia");

            txtProvincia.ForeColor = Color.Black;
        }

        private void txtProvincia_DropDownClosed(object sender, EventArgs e)
        {
            FormComprar_Click(sender, e);
        }

        // Valida el nombre y le quita los espacios en blanco
        private bool EsNombreValido(string nombre)
        {
            nombre = nombre.Trim();

            return System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[A-Za-z]+(?:\s[A-Za-z]+)+$");
        }

        // Valida la direccion
        private bool EsDireccionValida(string direccion)
        {
            if (txtDireccion.Text == "Direccion")
            {
                return false;
            }

            return System.Text.RegularExpressions.Regex.IsMatch(direccion, @"^[A-Za-z0-9\s.,'-]+$");
        }

        // Valida el codigo postal entre 4 y 6 dígitos
        private bool EsCodigoPostalValido(string codPostal)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(codPostal, @"^\d{4,6}$");
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            nombreclick++;
            if (nombreclick >= 1 && txtNombre.Text == "Nombre(s) y Apellido")
            {
                txtNombre.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtDireccion_Click(object sender, EventArgs e)
        {
            direccionclick++;
            if (direccionclick >= 1 && txtDireccion.Text == "Direccion")
            {
                txtDireccion.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtLocalidad_Click(object sender, EventArgs e)
        {
            localidadclick++;
            if (localidadclick >= 1 && txtLocalidad.Text == "Localidad")
            {
                txtLocalidad.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCodPostal_Click(object sender, EventArgs e)
        {
            codpostalclick++;
            if (codpostalclick >= 1 && txtCodPostal.Text == "Codigo Postal")
            {
                txtCodPostal.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {
            telefonoclick++;
            if (telefonoclick >= 1 && txtTelefono.Text == "Telefono (8 a 15 digitos)")
            {
                txtTelefono.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtDni_Click(object sender, EventArgs e)
        {
            dniclick++;
            if (dniclick >= 1 && txtDni.Text == "DNI (ej. 12345678)")
            {
                txtDni.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombreclick++;
            txtNombre.ForeColor = Color.Black;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            direccionclick++;
            txtDireccion.ForeColor = Color.Black;
        }

        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            localidadclick++;
            txtLocalidad.ForeColor = Color.Black;
        }

        private void txtCodPostal_TextChanged(object sender, EventArgs e)
        {
            codpostalclick++;
            txtCodPostal.ForeColor = Color.Black;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            telefonoclick++;
            txtTelefono.ForeColor = Color.Black;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            dniclick++;
            txtDni.ForeColor = Color.Black;
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            nombreclick++;
            if (nombreclick >= 1 && txtNombre.Text == "Nombre(s) y Apellido")
            {
                txtNombre.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            direccionclick++;
            if (direccionclick >= 1 && txtDireccion.Text == "Direccion")
            {
                txtDireccion.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtLocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            localidadclick++;
            if (localidadclick >= 1 && txtLocalidad.Text == "Localidad")
            {
                txtLocalidad.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtCodPostal_KeyDown(object sender, KeyEventArgs e)
        {
            codpostalclick++;
            if (codpostalclick >= 1 && txtCodPostal.Text == "Codigo Postal")
            {
                txtCodPostal.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            telefonoclick++;

            if (telefonoclick >= 1 && txtTelefono.Text == "Telefono (8 a 15 digitos)")
            {
                txtTelefono.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            dniclick++;
            if (dniclick >= 1 && txtDni.Text == "DNI (ej. 12345678)")
            {
                txtDni.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre(s) y Apellido";
                txtNombre.ForeColor = Color.DarkGray;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                txtDireccion.Text = "Direccion";
                txtDireccion.ForeColor = Color.DarkGray;
            }
        }

        private void txtLocalidad_Leave(object sender, EventArgs e)
        {
            if (txtLocalidad.Text == "")
            {
                txtLocalidad.Text = "Localidad";
                txtLocalidad.ForeColor = Color.DarkGray;
            }
        }

        private void txtCodPostal_Leave(object sender, EventArgs e)
        {
            if (txtCodPostal.Text == "")
            {
                txtCodPostal.Text = "Codigo Postal";
                txtCodPostal.ForeColor = Color.DarkGray;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono (8 a 15 digitos)";
                txtTelefono.ForeColor = Color.DarkGray;
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "DNI (ej. 12345678)";
                txtDni.ForeColor = Color.DarkGray;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, la tecla de retroceso, espacios, guiones y apóstrofes
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                && e.KeyChar != '-' && e.KeyChar != '\'')
            {
                e.Handled = true; // Rechaza el carácter
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, la tecla de retroceso, espacios y algunos signos de puntuación
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '-' && e.KeyChar != '/')
            {
                e.Handled = true; // Rechaza el carácter
            }
        }


        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, la tecla de retroceso, espacios y algunos signos de puntuación
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '-' && e.KeyChar != '/')
            {
                e.Handled = true; // Rechaza el carácter
            }
        }

        private void txtCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Rechaza el carácter
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números, la tecla de retroceso, guiones y espacios
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ')
            {
                e.Handled = true; // Rechaza el carácter
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Rechaza el carácter
            }
        }
    }
}



