﻿using Entidades;
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
    public partial class FormCarrito : FrmBase
    {

        public Carrito carrito;

        public FormCarrito(Carrito carrito)
        {
            InitializeComponent();
            this.carrito = carrito;
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            datagridCarrito.DataSource = carrito.Productos;

            decimal total = carrito.Productos.AsEnumerable().Sum(x => Convert.ToDecimal(x["Precio"]));
            lblTotal.Text = "EL TOTAL ES: " + total.ToString("C2");

            datagridCarrito.ClearSelection();
            btnQuitar.Visible = false;
            btnFinalizar.Visible = false;

            if (datagridCarrito.Rows.Count == 0)
            {
                // El DataGridView está vacío
                btnFinalizar.Visible = false;
            }
            else
            {
                // El DataGridView tiene al menos una fila
                btnFinalizar.Visible = true;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Owner.Hide(); // Oculta el formulario padre
            Owner.Owner.Show(); // Muestra el formulario padre del padre
        }

        private void btnAgregarMas_Click(object sender, EventArgs e)
        {
            datagridCarrito.ClearSelection();
            this.Hide(); // Oculta el formulario actual
            Owner.Show(); // Muestra el formulario padre
            //((FormUsuarioBasic)Owner).datagridProductosUser.ClearSelection();
        }

        private void FormCarrito_Click(object sender, EventArgs e)
        {
            datagridCarrito.ClearSelection();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (datagridCarrito.SelectedRows.Count > 0)
            {
                // Obtiene el índice de la fila seleccionada
                int rowIndex = datagridCarrito.SelectedRows[0].Index;

                // Elimina la fila del DataTable
                carrito.Productos.Rows.RemoveAt(rowIndex);

                // Actualiza el DataGridView
                datagridCarrito.DataSource = null;
                datagridCarrito.DataSource = carrito.Productos;
                datagridCarrito.ClearSelection();
            }
            decimal total = carrito.Productos.AsEnumerable().Sum(x => Convert.ToDecimal(x["Precio"]));
            lblTotal.Text = "EL TOTAL ES: " + total.ToString("C2");

            if (datagridCarrito.Rows.Count == 0)
            {
                btnFinalizar.Visible = false; 
            }

        }

        private void datagridCarrito_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridCarrito.SelectedRows.Count > 0)
            {
                btnQuitar.Visible = true;
            }
            else
            {
                btnQuitar.Visible = false;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FormComprar frm5 = new FormComprar();
            frm5.Owner = this;
            frm5.Show(this); // Esto establece FormUsuarioBasic como el propietario de FormCarrito

            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
