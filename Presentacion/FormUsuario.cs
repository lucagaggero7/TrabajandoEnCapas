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

namespace Presentacion
{
    public partial class FormUsuario : Form
    {
        int filtrarclick = 0;

        public Producto objEntProducto = new Producto();

        public NegProductos objNegProductos = new NegProductos();

        

        DataTable DataTableMarcas = new DataTable();
        DataTable DataTableCategorias = new DataTable();
        DataTable DataTablePrecios = new DataTable();

        DataTable DataTableProductos = new DataTable();

        public FormUsuario()
        {
            InitializeComponent();
            //datagridProductosUser.ColumnCount = 6;
            //datagridProductosUser.Columns[0].HeaderText = "Codigo";
            //datagridProductosUser.Columns[1].HeaderText = "Nombre";
            //datagridProductosUser.Columns[2].HeaderText = "Marca";
            //datagridProductosUser.Columns[3].HeaderText = "Categoria";
            //datagridProductosUser.Columns[4].HeaderText = "Precio";
            //datagridProductosUser.Columns[5].HeaderText = "Stock";


            //datagridProductosUser.Columns[0].Width = 60;
            //datagridProductosUser.Columns[1].Width = 90;
            //datagridProductosUser.Columns[2].Width = 90;
            //datagridProductosUser.Columns[3].Width = 90;
            //datagridProductosUser.Columns[4].Width = 60;
            //datagridProductosUser.Columns[5].Width = 60;
            LlenarDataGrid();

            datagridProductosUser.ClearSelection();


        }

        private void LlenarDataGrid()
        {

            datagridProductosUser.DataSource = objNegProductos.listadoProductos("Todos");


            //datagridProductosUser.Rows.Clear();
            //DataSet ds = new DataSet();
            //ds = objNegProductos.listadoProductos("Todos");
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {
            //        datagridProductosUser.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5]);
            //        datagridProductosUser.ClearSelection();
            //    }
            //}
            //else
            //    MessageBox.Show("No hay profesionales cargados en el sistema");
        }

        private void TxtBox_a_Clase(string accion) //Prepara el objeto a enviar a la capa de Negocio
        {

        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtrarclick++;
            if ((filtrarclick % 2) == 0)
            {
                btnFiltrar.Text = "Filtrar";
                filtroMarca.Visible = false;
                filtroCategoria.Visible = false;
                filtroPrecio.Visible = false;
            }
            else
            {
                btnFiltrar.Text = "Borrar Filtros";
                filtroMarca.Visible = true;
                filtroCategoria.Visible = true;
                filtroPrecio.Visible = true;
            }
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            DataTableMarcas = objNegProductos.BuscarFiltros("Marca");
            foreach (DataRow row in DataTableMarcas.Rows)
            {
                filtroMarca.Items.Add(row["Marca"].ToString());
            }

            DataTableCategorias = objNegProductos.BuscarFiltros("Categoria");
            foreach (DataRow row in DataTableCategorias.Rows)
            {
                filtroCategoria.Items.Add(row["Categoria"].ToString());
            }

            DataTablePrecios = objNegProductos.BuscarFiltros("Precio");
            foreach (DataRow row in DataTablePrecios.Rows)
            {
                filtroPrecio.Items.Add(row["Precio"].ToString());
            }

            filtroCategoria.SelectedIndex = 1;

           
        }
        private string filtroActual = string.Empty;
        private void filtroCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BindingSource filterBs = new BindingSource();
            filterBs.DataSource = datagridProductosUser.DataSource;
            filterBs.Filter = string.Format("Categoria = '{0}'", filtroCategoria.SelectedItem);
            datagridProductosUser.DataSource = filterBs;


            // mostrarclick = 0;
        }

        private void filtroMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BindingSource filterBs = new BindingSource();
            filterBs.DataSource = datagridProductosUser.DataSource;
           // filterBs.Filter = string.Format("Marca = '{0}'", filtroMarca.SelectedItem);
            filterBs.Filter = $"Categoria ='{filtroCategoria.SelectedItem}' AND Marca ='{filtroMarca.SelectedItem}' ";
            datagridProductosUser.DataSource = filterBs;

        }

        private void filtroPrecio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BindingSource filterBs = new BindingSource();
            filterBs.DataSource = datagridProductosUser.DataSource;
            //filterBs.Filter = string.Format("Precio = {0}", filtroPrecio.SelectedItem);
            filterBs.Filter = $"Categoria ='{filtroCategoria.SelectedItem}' AND Marca ='{filtroMarca.SelectedItem}' And Precio ='{filtroPrecio.SelectedItem}'";
            datagridProductosUser.DataSource = filterBs;

        }
       

    }
}
