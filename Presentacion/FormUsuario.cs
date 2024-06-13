using Entidades;
using INNOBRA_FE;
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
    public partial class FormUsuario : FrmBase
    {
        public Producto objEntProducto = new Producto();

        public NegProductos objNegProductos = new NegProductos();

        DataTable DataTableFiltros = new DataTable();

        

        private Timer selectionTimer = new Timer();

        public FormUsuario()
        {

            InitializeComponent();
            InitializeSelectionTimer();
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
        }

        private void InitializeSelectionTimer()
        {
            
            timer1.Interval = 1000; // 1 segundos
            timer1.Tick += SelectionTimer_Tick;
            timer1.Start();

            timer2.Interval = 1000; // 1 segundos
            timer2.Tick += SelectionTimer_Tick;
            timer2.Start();

            timer3.Interval = 1000; // 1 segundos
            timer3.Tick += SelectionTimer_Tick;
            timer3.Start();

        }

        private void SelectionTimer_Tick(object sender, EventArgs e)
        {
            
            // Habilita el CheckedListBox para permitir selecciones
            listCategorias.Enabled = true;
            listMarcas.Enabled = true;
            listPrecios.Enabled = true;
            timer1.Stop(); // Detén el Timer después del primer Tick
            timer2.Stop(); // Detén el Timer después del primer Tick
            timer3.Stop(); // Detén el Timer después del primer Tick
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
            if(btnFiltrar.Text == "Filtrar")
            {
                btnFiltrar.Text = "Borrar Filtros";

                DataTableFiltros = objNegProductos.BuscarFiltros();

                HashSet<string> categoriasUnicas = new HashSet<string>();

                // Recorrer los registros y agregar categorías al conjunto
                foreach (DataRow row in DataTableFiltros.Rows)
                {
                    string categoria = row["Categoria"].ToString();
                    if (!categoriasUnicas.Contains(categoria))
                    {
                        categoriasUnicas.Add(categoria);
                        listCategorias.Items.Add(categoria);
                    }
                }

             
            }
            else
            {
                btnFiltrar.Text = "Filtrar";
                //borrar filtros y borrar items de checkedlistbox
                listCategorias.Items.Clear();
                listMarcas.Items.Clear();
                listPrecios.Items.Clear();
                datagridProductosUser.DataSource = objNegProductos.listadoProductos("Todos");
                listCategorias.Visible = false;
                listMarcas.Visible = false;
                listPrecios.Visible = false;
            }
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            datagridProductosUser.ClearSelection();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            listCategorias.Visible = !listCategorias.Visible;
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            listMarcas.Visible = !listMarcas.Visible;
        }

        private void btnPrecio_Click(object sender, EventArgs e)
        {
            listPrecios.Visible = !listPrecios.Visible;
        }

        private void listCategorias_SelectedValueChanged(object sender, EventArgs e)
        {
            BindingSource filterBs = new BindingSource();
            filterBs.DataSource = datagridProductosUser.DataSource;
            filterBs.Filter = string.Format("Categoria = '{0}'", listCategorias.SelectedItem);
            datagridProductosUser.DataSource = filterBs;

            listMarcas.Items.Clear();
            

            DataTableFiltros = objNegProductos.BuscarFiltros();

            //foreach (DataRow row in DataTableFiltros.Rows)
            //{
            //    if (row["Categoria"].ToString() == listCategorias.SelectedItem.ToString()) 
            //    {
            //        listMarcas.Items.Add(row["Marca"].ToString());
            //        listPrecios.Items.Clear();
            //        datagridProductosUser.ClearSelection();
            //    }
            //}

            HashSet<string> marcasUnicas = new HashSet<string>();

            // Recorrer los registros y agregar categorías al conjunto
            foreach (DataRow row in DataTableFiltros.Rows)
            {
                string marca = row["Marca"].ToString();
                if (!marcasUnicas.Contains(marca) && row["Categoria"].ToString() == listCategorias.SelectedItem.ToString())
                {
                    marcasUnicas.Add(marca);
                    listMarcas.Items.Add(marca);
                    listPrecios.Items.Clear();
                    datagridProductosUser.ClearSelection();
                }
            }

            if (listCategorias.CheckedItems.Count == 0 )
            {
                BindingSource unfilterBs = new BindingSource();
                unfilterBs.DataSource = datagridProductosUser.DataSource;
                unfilterBs.Filter = null;
                datagridProductosUser.DataSource = unfilterBs;
                listMarcas.Items.Clear();
                listPrecios.Items.Clear();
                datagridProductosUser.ClearSelection();
            }
        }

        private void listCategorias_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < listCategorias.Items.Count; ++ix)
                if (ix != e.Index) listCategorias.SetItemChecked(ix, false);
            listCategorias.Enabled = false;
            timer1.Start();
            
        }

        private void listMarcas_SelectedValueChanged(object sender, EventArgs e)
        {
            BindingSource filterBs = new BindingSource();
            filterBs.DataSource = datagridProductosUser.DataSource;
            filterBs.Filter = $"Categoria ='{listCategorias.SelectedItem}' AND Marca ='{listMarcas.SelectedItem}'";
            datagridProductosUser.DataSource = filterBs;

            listPrecios.Items.Clear();

            DataTableFiltros = objNegProductos.BuscarFiltros();
            //foreach (DataRow row in DataTableFiltros.Rows)
            //{
            //    if (row["Marca"].ToString() == listMarcas.SelectedItem.ToString())
            //    {
            //        listPrecios.Items.Add(row["Precio"].ToString());
            //        datagridProductosUser.ClearSelection();
            //    }
            //}

            HashSet<string> preciosUnicos = new HashSet<string>();

            // Recorrer los registros y agregar categorías al conjunto
            foreach (DataRow row in DataTableFiltros.Rows)
            {
                string precio = row["Precio"].ToString();
                if (!preciosUnicos.Contains(precio) && (row["Marca"].ToString() == listMarcas.SelectedItem.ToString()))
                {
                    preciosUnicos.Add(precio);
                    listPrecios.Items.Add(precio);
                    datagridProductosUser.ClearSelection();

                }
            }


            if (listMarcas.CheckedItems.Count == 0)
            {
                BindingSource unfilterBs = new BindingSource();
                unfilterBs.DataSource = datagridProductosUser.DataSource;
                unfilterBs.Filter = null;
                datagridProductosUser.DataSource = unfilterBs;
                listMarcas.Items.Clear();
                listPrecios.Items.Clear();


                HashSet<string> marcasUnicas = new HashSet<string>();

                // Recorrer los registros y agregar categorías al conjunto
                foreach (DataRow row in DataTableFiltros.Rows)
                {
                    string marca = row["Marca"].ToString();
                    if (!marcasUnicas.Contains(marca) && row["Categoria"].ToString() == listCategorias.SelectedItem.ToString())
                    {
                        marcasUnicas.Add(marca);
                        listMarcas.Items.Add(marca);
                        listPrecios.Items.Clear();
                        datagridProductosUser.ClearSelection();
                    }
                }

                BindingSource unfilterMarcaBs = new BindingSource();
                unfilterMarcaBs.DataSource = datagridProductosUser.DataSource;
                unfilterMarcaBs.Filter = string.Format("Categoria = '{0}'", listCategorias.SelectedItem);
                datagridProductosUser.DataSource = unfilterMarcaBs;
                datagridProductosUser.ClearSelection();
            }
            
        }

        private void listMarcas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < listMarcas.Items.Count; ++ix)
                if (ix != e.Index) listMarcas.SetItemChecked(ix, false);
            listMarcas.Enabled = false;
            timer2.Start();
           
        }

        private void listPrecios_SelectedValueChanged(object sender, EventArgs e)
        {
            BindingSource filterBs = new BindingSource();
            filterBs.DataSource = datagridProductosUser.DataSource;
            filterBs.Filter = $"Categoria ='{listCategorias.SelectedItem}' AND Marca ='{listMarcas.SelectedItem}' AND Precio ='{listPrecios.SelectedItem}'";
            datagridProductosUser.DataSource = filterBs;

            if (listPrecios.CheckedItems.Count == 0)
            {
                BindingSource unfilterPrecioBs = new BindingSource();
                unfilterPrecioBs.DataSource = datagridProductosUser.DataSource;
                unfilterPrecioBs.Filter = $"Categoria ='{listCategorias.SelectedItem}' AND Marca ='{listMarcas.SelectedItem}'";
                datagridProductosUser.DataSource = unfilterPrecioBs;
               
                datagridProductosUser.ClearSelection();
                listPrecios.Items.Clear();

                HashSet<string> preciosUnicos = new HashSet<string>();

                // Recorrer los registros y agregar categorías al conjunto
                foreach (DataRow row in DataTableFiltros.Rows)
                {
                    string precio = row["Precio"].ToString();
                    if (!preciosUnicos.Contains(precio) && (row["Marca"].ToString() == listMarcas.SelectedItem.ToString()))
                    {
                        preciosUnicos.Add(precio);
                        listPrecios.Items.Add(precio);
                        datagridProductosUser.ClearSelection();

                    }
                }
            }
            datagridProductosUser.ClearSelection();
        }

        private void listPrecios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < listPrecios.Items.Count; ++ix)
                if (ix != e.Index) listPrecios.SetItemChecked(ix, false);
            listPrecios.Enabled = false;
            timer3.Start();
            
        }

        private void FormUsuario_Click(object sender, EventArgs e)
        {
            datagridProductosUser.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muy pronto, estoy cansado jefe....");
        }
    }
}
