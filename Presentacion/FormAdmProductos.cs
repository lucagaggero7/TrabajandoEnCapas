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

        public FormAdmProductos()
        {
            InitializeComponent();
            //datagridProductos.ColumnCount = 6;
            //datagridProductos.Columns[0].HeaderText = "Código";
            //datagridProductos.Columns[1].HeaderText = "Nombre";
            //datagridProductos.Columns[2].HeaderText = "Marca";
            //datagridProductos.Columns[3].HeaderText = "Categoria";
            //datagridProductos.Columns[4].HeaderText = "Precio";
            //datagridProductos.Columns[5].HeaderText = "Stock";


            //datagridProductos.Columns[0].Width = 60;
            //datagridProductos.Columns[1].Width = 90;
            //datagridProductos.Columns[2].Width = 90;
            //datagridProductos.Columns[3].Width = 90;
            //datagridProductos.Columns[4].Width = 60;
            //datagridProductos.Columns[5].Width = 60;
            LlenarDataGrid();
        }

        private void FormAdmProductos_Load(object sender, EventArgs e)
        {
            datagridProductos.ClearSelection();
        }

        private void LlenarDataGrid()
        {
            datagridProductos.DataSource = objNegProductos.listadoProductos("Todos");
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty; 
            
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
            int nGrabados = -1;
            //llamo al método que carga los datos del objeto
            string accion = "Cargar";
            TxtBox_a_Clase(accion);
            nGrabados = objNegProductos.abmProdcutos("Agregar", objEntProducto); //invoco a la capa de negocio
                
                if (nGrabados == -1)
                lblMensaje.Text = " No pudo grabar productos en el sistema";
            else
            {
                lblMensaje.Text = " Se grabó con éxito productos.";
                LlenarDataGrid();
                Limpiar();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int nBorrados = -1;
            //llamo al método que carga los datos del objeto
            string accion = "Buscar o Borrar";
            TxtBox_a_Clase(accion);
            nBorrados = objNegProductos.abmProdcutos("Borrar", objEntProducto); //invoco a la capa de negocio

            if (nBorrados > 0)
            {
                lblMensaje.Text = " Se borro con éxito profesionales.";
                LlenarDataGrid();
                Limpiar();
            }
            else
            {
                lblMensaje.Text = " El codigo que ingreso no existe";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string accion = "Buscar o Borrar";
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
                        lblMensaje.Text = " Si existe en el sistema";
                        return;
                    }
                    else
                    {
                        lblMensaje.Text = " No existe en el sistema";
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
    }
}
