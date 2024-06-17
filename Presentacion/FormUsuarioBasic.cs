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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Presentacion
{
    public partial class FormUsuarioBasic : FrmBase
    {
        public Producto objEntProducto = new Producto();

        public NegProductos objNegProductos = new NegProductos();

        private Carrito carrito;

        //variables que cuentan los clicks de los textbox 
        int categoriaclick = 0;
        int marcaclick = 0;
        int preciominclick = 0;
        int preciomaxclick = 0;

        long Valorverif;
        long Verificacion;


        public FormUsuarioBasic()
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

            carrito = new Carrito();

            carrito.ClonarEstructura((DataTable)datagridProductosUser.DataSource);
        }
   

        private void LlenarDataGrid()
        {
            datagridProductosUser.DataSource = objNegProductos.listadoProductosUserV("Todos");

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


        private void FormUsuario_Load(object sender, EventArgs e)
        {
            datagridProductosUser.ClearSelection();
        }


        private void FormUsuario_Click(object sender, EventArgs e)
        {
            datagridProductosUser.ClearSelection();

            //Ejecutamos los evenetos leave para ahorrar lineas if
            txtPrecioMin_Leave(sender, e);
            txtPrecioMax_Leave(sender, e);
            //

            //Sacamos el foco de los textbox para no generar bugs del cursor
            lblCategoria.Focus();
            //
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            if (datagridProductosUser.SelectedRows.Count > 0)
            {
                var row = ((DataRowView)datagridProductosUser.SelectedRows[0].DataBoundItem).Row;
                carrito.AgregarProducto(row);
                MessageBox.Show("Prodcuto agregado al carrito");
                datagridProductosUser.ClearSelection();
            }
            else
            {
                MessageBox.Show("Seleccione un producto en la lista antes de agregarlo");
            }


        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            FormCarrito frm4 = new FormCarrito(carrito);
            frm4.Owner = this;
            frm4.Show(this); // Esto establece FormUsuarioBasic como el propietario de FormCarrito

            datagridProductosUser.ClearSelection();
            this.Hide();
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

        private void txtPrecioMin_Click(object sender, EventArgs e)
        {
            preciominclick++;

            if (preciominclick >= 1 && txtPrecioMin.Text == "Min")
            {
                txtPrecioMin.Text = "";
            }
            else
            {
                return;
            }
            
        }

        private void txtPrecioMax_Click(object sender, EventArgs e)
        {
            preciomaxclick++;

            if (preciomaxclick >= 1 && txtPrecioMax.Text == "Max")
            {
                txtPrecioMax.Text = "";
            }
            else
            {
                return;
            }
            
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            txtCategoria.ForeColor = Color.Black;

            BindingSource filterBs = new BindingSource();
            filterBs.DataSource = datagridProductosUser.DataSource;
            filterBs.Filter = string.Format("Categoria like '%" + txtCategoria.Text + "%'");
            datagridProductosUser.DataSource = filterBs;

            datagridProductosUser.ClearSelection();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            txtMarca.ForeColor = Color.Black;

            if (txtMarca.Text != "" && txtCategoria.Text != "Categoria")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%'", txtCategoria.Text, txtMarca.Text);
                datagridProductosUser.DataSource = filterBs;
            }

            if(txtMarca.Text == "" && txtCategoria.Text != "Categoria")
            {
                if (txtCategoria.Text != "")
                {
                    BindingSource filterBs = new BindingSource();
                    filterBs.DataSource = datagridProductosUser.DataSource;
                    filterBs.Filter = string.Format("Categoria like '%" + txtCategoria.Text + "%'");
                    datagridProductosUser.DataSource = filterBs;
                }
            }    

            if(txtCategoria.Text == "" && txtMarca.Text == "" && txtPrecioMin.Text == "Min" && txtPrecioMax.Text == "Max")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%" + txtCategoria.Text + "%'");
                datagridProductosUser.DataSource = filterBs;
            }
            datagridProductosUser.ClearSelection();
        }

        private void txtPrecioMin_TextChanged(object sender, EventArgs e)
        {
            txtPrecioMin.ForeColor = Color.Black;

            if(txtPrecioMin.Text != "" && txtPrecioMin.Text != "Min")
            {
            }
            else
            {
                return;
            }

            //Verificamos que el valor sea un valor entero
            if (long.TryParse(txtPrecioMin.Text, out Verificacion))

            {
                //borro el error 
                Valorverif = long.Parse(txtPrecioMin.Text);
            }
            else
            {
                txtPrecioMin.Text = "";
                return;
            }
            //

            if (txtPrecioMin.Text != "" && txtPrecioMin.Text != "Min" && txtPrecioMax.Text != "Max" &&  txtCategoria.Text != "Categoria" && txtMarca.Text != "Marca")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.Parse(txtPrecioMax.Text));

                datagridProductosUser.DataSource = filterBs;
            }
           
            if(txtPrecioMin.Text == "Min" && txtPrecioMax.Text != "Max" && txtCategoria.Text != "Categoria" && txtMarca.Text != "Marca")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.MinValue, int.Parse(txtPrecioMax.Text));

                datagridProductosUser.DataSource = filterBs;
            }

            if(txtPrecioMin.Text != "Min" && txtPrecioMin.Text != "" && txtPrecioMax.Text == "Max" && txtCategoria.Text == "" && txtMarca.Text == "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.MaxValue);

                datagridProductosUser.DataSource = filterBs;
            }
            datagridProductosUser.ClearSelection();


        }
        private void txtPrecioMax_TextChanged(object sender, EventArgs e)
        {
            txtPrecioMax.ForeColor = Color.Black;

            if (txtPrecioMax.Text != "" && txtPrecioMax.Text != "Max")
            {
            }
            else
            {
                return;
            }

            //Verificamos que el valor sea un valor entero
            if (long.TryParse(txtPrecioMax.Text, out Verificacion))

            {
                //borro el error 
                Valorverif = long.Parse(txtPrecioMax.Text);
            }
            else
            {
                txtPrecioMax.Text = "";
                return;
            }
            //

            if (txtPrecioMax.Text != "" && txtPrecioMax.Text != "Max" && txtPrecioMin.Text != "Min" 
                && txtCategoria.Text != "Categoria" && txtMarca.Text != "Marca")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                  txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.Parse(txtPrecioMax.Text));

                datagridProductosUser.DataSource = filterBs;
            }

            if (txtPrecioMin.Text != "" && txtPrecioMin.Text != "Min" && txtPrecioMax.Text == "Max" && txtCategoria.Text != "Categoria" && txtMarca.Text != "Marca")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.MaxValue);

                datagridProductosUser.DataSource = filterBs;
            }

            if(txtPrecioMin.Text == "Min" && txtPrecioMax.Text != "" && txtPrecioMax.Text != "Max")
            {
                
                    BindingSource filterBs = new BindingSource();
                    filterBs.DataSource = datagridProductosUser.DataSource;
                    filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                     txtCategoria.Text, txtMarca.Text, int.MinValue, int.Parse(txtPrecioMax.Text));

                    datagridProductosUser.DataSource = filterBs;
                
            }

            if (txtCategoria.Text == "" && txtMarca.Text == "" && txtPrecioMin.Text == "Min" && txtPrecioMax.Text == "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%" + txtCategoria.Text + "%'");
                datagridProductosUser.DataSource = filterBs;
            }

            if(txtCategoria.Text != "" && txtMarca.Text != "" && txtPrecioMin.Text != "Min" && txtPrecioMax.Text == "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.MaxValue);

                datagridProductosUser.DataSource = filterBs;
            }
            datagridProductosUser.ClearSelection();
        }

        private void txtPrecioMin_KeyDown(object sender, KeyEventArgs e)
        {
            preciominclick++;

            if (preciominclick >= 1 && txtPrecioMin.Text == "Min")
            {
                txtPrecioMin.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtPrecioMax_KeyDown(object sender, KeyEventArgs e)
        {
            preciomaxclick++;

            if (preciomaxclick >= 1 && txtPrecioMax.Text == "Max")
            {
                txtPrecioMax.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtPrecioMin_Leave(object sender, EventArgs e)
        {
            if (txtPrecioMin.Text == "")
            {
                txtPrecioMin.Text = "Min";
                txtPrecioMin.ForeColor = Color.DarkGray;
            }
        }

        private void txtPrecioMax_Leave(object sender, EventArgs e)
        {
            if (txtPrecioMax.Text == "")
            {
                txtPrecioMax.Text = "Max";
                txtPrecioMax.ForeColor = Color.DarkGray;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            Owner.Show(); // Muestra el formulario padre
        }

        private void btnBorrarFiltros_Click(object sender, EventArgs e)
        {
            txtCategoria.Text = "";
            txtMarca.Text = "";
            txtPrecioMin.Text = "";
            txtPrecioMax.Text = "";
            FormUsuario_Click(sender, e);

        }
    }
}
