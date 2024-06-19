﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Presentacion
{
    public partial class FormComprar : FrmBase
    {

        //variables que cuentan los clicks de los textbox para simular placeholders
        int nombreclick = 0;
        int linea1click = 0;
        int linea2click = 0;
        int codpostalclick = 0;
        int telefonoclick = 0;
        int dniclick = 0;
        //
        public FormComprar()
        {
            InitializeComponent();
        }

        private void FormComprar_Load(object sender, EventArgs e)
        {
            // Asumiendo que 'dataGridView' es tu DataGridView y 'listBox' es tu ListBox
            foreach (DataGridViewRow row in ((FormCarrito)Owner).datagridCarrito.Rows)
            {
                // Obtiene los valores de las columnas específicas
                string nombre = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                string marca = row.Cells["Marca"].Value?.ToString() ?? string.Empty;
                // Omite la columna 'Stock'
                string precio = row.Cells["Precio"].Value?.ToString() ?? string.Empty;

                // Formatea la cadena para el ítem del ListBox y lo añade
                listResumen.Items.Add($"{nombre}, {marca}, ${precio}");
            }

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
            lblIva.Text = "(IVA incluido $" + iva.ToString("N2") + ")"; // Formatea y muestra el IVA en el label

            lblProductos.Text = listResumen.Items.Count.ToString() + " Productos";

            //Ejecutamos los evenetos leave para ahorrar lineas if
            txtNombre_Leave(sender, e);
            txtLinea1_Leave(sender, e);
            txtLinea2_Leave(sender, e);
            txtCodPostal_Leave(sender, e);
            txtTelefono_Leave(sender, e);
            txtDni_Leave(sender, e);
            //

            //Sacamos el foco de los textbox para no generar bugs del cursor
            lblResumen.Focus();
            //

            this.ActiveControl = lblResumen;

            rtbCampos.Rtf = @"{\rtf1\ansi \cf1\b * \cf0\b0 Campos Obligatorios\par}";
            rtbCampos.Select(0, 1); // Selecciona solo el asterisco
            rtbCampos.SelectionColor = Color.Red; // Cambia el color del texto seleccionado a rojo
            rtbCampos.DeselectAll(); // Deselecciona el texto
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            // Valida el nombre y apellido
            if (!EsNombreValido(txtNombre.Text))
            {
                errorNombre.SetError(panelNombre, "Ingrese un nombre y apellido válidos.");
                return;
            }
            else
            {
                errorNombre.Clear(); // Limpia el mensaje de error si es válido
            }

            // Valida la primera línea de una dirección
            if (!EsDireccionValida(txtLinea1.Text))
            {
                errorLinea1.SetError(panelLinea1, "Ingrese la primera línea de la dirección.");
                return;
            }
            else
            {
                errorLinea1.Clear(); // Limpia el mensaje de error si es válido
            }

            // Continúa con la lógica de compra si ambos campos son válidos
            // ...



            // Reemplaza 'EsCodigoPostalValido' con tu lógica de validación de códigos postales
            if (!EsCodigoPostalValido(txtCodPostal.Text))
            {
                // Muestra un mensaje de error si el código postal no es válido
                errorCodigoPostal.SetError(panelCodPostal, "El código postal no es válido.");
                return;
            }
            else
            {
                // Limpia el mensaje de error si el código postal es válido
                errorCodigoPostal.Clear();
                // Procede con la lógica de compra
                // ...
            }


            // Elimina todos los caracteres que no sean dígitos
            string digitsOnly = new String(txtTelefono.Text.Where(char.IsDigit).ToArray());

            // Verifica si la longitud está fuera del rango permitido
            if (digitsOnly.Length < 8 || digitsOnly.Length > 15)
            {
                // Maneja el caso de longitud inválida, por ejemplo, mostrando un mensaje de error
                errorTelefono.SetError(panelTelefono, "Debe ingresar un telefono valido");
                return;
            }
            else
            {
                errorTelefono.Clear();
            }

            // Verifica si 'txtDni' tiene exactamente 8 dígitos numéricos
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDni.Text, @"^\d{8}$"))
            {
                // Muestra un mensaje de error si 'txtDni' no tiene 8 dígitos
                errorDni.SetError(panelDni, "El DNI debe tener 8 dígitos numéricos.");
                return;
            }
            else
            {
                // Limpia el mensaje de error si 'txtDni' es válido
                errorDni.Clear();
                // Procede con la lógica de compra
                // ...
            }

            

            FormFin frm6 = new FormFin();
            frm6.Owner = this;
            frm6.Show(this); // Esto establece FormUsuarioBasic como el propietario de FormCarrito
            this.Hide();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Owner.Show(); // Muestra el formulario padre

        }

        private void FormComprar_Click(object sender, EventArgs e)
        {
            lblResumen.Focus();
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

        private void txtLinea1_Click(object sender, EventArgs e)
        {
            linea1click++;

            if (linea1click >= 1 && txtLinea1.Text == "Direccion Linea #1")
            {
                txtLinea1.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtLinea2_Click(object sender, EventArgs e)
        {

            linea2click++;

            if (linea2click >= 1 && txtLinea2.Text == "Direccion Linea #2 (opcional)")
            {
                txtLinea2.Text = "";
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

        private void txtLinea1_TextChanged(object sender, EventArgs e)
        {
            linea1click++;
            txtLinea1.ForeColor = Color.Black;
        }

        private void txtLinea2_TextChanged(object sender, EventArgs e)
        {
            linea2click++;
            txtLinea2.ForeColor = Color.Black;
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

        private void txtLinea1_KeyDown(object sender, KeyEventArgs e)
        {
            linea1click++;

            if (linea1click >= 1 && txtLinea1.Text == "Direccion Linea #1")
            {
                txtLinea1.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtLinea2_KeyDown(object sender, KeyEventArgs e)
        {
            linea1click++;

            if (linea2click >= 1 && txtLinea2.Text == "Direccion Linea #2 (opcional)")
            {
                txtLinea2.Text = "";
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

        private void txtLinea1_Leave(object sender, EventArgs e)
        {
            if (txtLinea1.Text == "")
            {
                txtLinea1.Text = "Direccion Linea #1";
                txtLinea1.ForeColor = Color.DarkGray;
            }
        }

        private void txtLinea2_Leave(object sender, EventArgs e)
        {
            if (txtLinea2.Text == "")
            {
                txtLinea2.Text = "Direccion Linea #2 (opcional)";
                txtLinea2.ForeColor = Color.DarkGray;
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

        private void txtLinea1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, la tecla de retroceso, espacios y algunos signos de puntuación
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != '-' && e.KeyChar != '/')
            {
                e.Handled = true; // Rechaza el carácter
            }
        }

        private void txtLinea2_KeyPress(object sender, KeyPressEventArgs e)
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

        // Método para validar un nombre y apellido (ajusta según tus necesidades)
        private bool EsNombreValido(string nombre)
        {
            // Ejemplo: verifica si hay al menos dos palabras separadas por espacio
            return System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[A-Za-z]+(?:\s[A-Za-z]+)+$");
        }

        // Método para validar la primera línea de una dirección (ajusta según tus necesidades)
        private bool EsDireccionValida(string direccion)
        {
            // Ejemplo: verifica si contiene letras y números (ajusta según tus necesidades)
            return System.Text.RegularExpressions.Regex.IsMatch(direccion, @"^[A-Za-z0-9\s.,'-]+$");
        }

        // Aquí debes definir tu método de validación de códigos postales
        private bool EsCodigoPostalValido(string codPostal)
        {
            // Verifica si tiene entre 4 y 6 dígitos
            return System.Text.RegularExpressions.Regex.IsMatch(codPostal, @"^\d{4,6}$");
        }
    }
}