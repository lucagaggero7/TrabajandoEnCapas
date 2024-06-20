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
            btnAgregar.Visible = false;
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


            ///SIN MARCA
            //si se ingresa categoria sin ingresar precio min ni precio max ni marca
            if (txtPrecioMin.Text == "Min" && txtPrecioMax.Text == "Max" && txtMarca.Text == "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%" + txtCategoria.Text + "%'");
                datagridProductosUser.DataSource = filterBs;
            }

            //si se ingresa categoria y precio min sin ingresar precio max ni marca
            if (txtPrecioMin.Text != "Min" && txtPrecioMax.Text == "Max" && txtMarca.Text == "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtCategoria.Text, int.Parse(txtPrecioMin.Text), int.MaxValue);
                datagridProductosUser.DataSource = filterBs;
            }

            //si se ingresa categoria y precio max sin ingresar precio min ni marca
            if (txtPrecioMin.Text == "Min" && txtPrecioMax.Text != "Max" && txtMarca.Text == "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtCategoria.Text, int.MinValue, int.Parse(txtPrecioMax.Text));
                datagridProductosUser.DataSource = filterBs;
            }

            //si se ingresa categoria, precio min y precio max sin ingresar marca
            if (txtPrecioMin.Text != "Min" && txtPrecioMax.Text != "Max" && txtMarca.Text == "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtCategoria.Text, int.Parse(txtPrecioMin.Text), int.Parse(txtPrecioMax.Text));
                datagridProductosUser.DataSource = filterBs;
            }

            //////////////////////////////////


            ///CON MARCA
            //si se ingresa categoria y marca sin ingresar precio min ni precio max 
            if (txtPrecioMin.Text == "Min" && txtPrecioMax.Text == "Max" && txtMarca.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%'",
                                                 txtCategoria.Text, txtMarca.Text);
                datagridProductosUser.DataSource = filterBs;
            }

            //si se ingresa categoria, precio min y marca sin ingresar precio max
            if (txtPrecioMin.Text != "Min" && txtPrecioMax.Text == "Max" && txtMarca.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.MaxValue);
                datagridProductosUser.DataSource = filterBs;
            }

            //si se ingresa categoria, precio max y marca sin ingresar precio min 
            if (txtPrecioMin.Text == "Min" && txtPrecioMax.Text != "Max" && txtMarca.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.MinValue, int.Parse(txtPrecioMax.Text));
                datagridProductosUser.DataSource = filterBs;
            }

            //si se ingresa categoria, precio min, precio max y marca
            if (txtPrecioMin.Text != "Min" && txtPrecioMax.Text != "Max" && txtMarca.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.Parse(txtPrecioMax.Text));
                datagridProductosUser.DataSource = filterBs;
            }

            datagridProductosUser.ClearSelection();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            txtMarca.ForeColor = Color.Black;

            if (txtMarca.Text != "" && txtCategoria.Text == "" && txtPrecioMin.Text == "Min" && txtPrecioMax.Text == "Max")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Marca like '%" + txtMarca.Text + "%'");
                datagridProductosUser.DataSource = filterBs;
            }

            if (txtMarca.Text != "" && txtCategoria.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%'", txtCategoria.Text, txtMarca.Text);
                datagridProductosUser.DataSource = filterBs;
            }

            if(txtMarca.Text == "" && txtCategoria.Text != "")
            {
                if (txtCategoria.Text != "")
                {
                    BindingSource filterBs = new BindingSource();
                    filterBs.DataSource = datagridProductosUser.DataSource;
                    filterBs.Filter = string.Format("Categoria like '%" + txtCategoria.Text + "%'");
                    datagridProductosUser.DataSource = filterBs;
                }
            }

            if (txtCategoria.Text == "" && txtMarca.Text == "" && txtPrecioMin.Text == "Min" && txtPrecioMax.Text == "Max")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%" + txtCategoria.Text + "%'");
                datagridProductosUser.DataSource = filterBs;
            }


            //////////////
            if (txtCategoria.Text == "" && txtMarca.Text != "" && txtPrecioMin.Text != "Min" && txtPrecioMax.Text == "Max")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Marca like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtMarca.Text, int.Parse(txtPrecioMin.Text), int.MaxValue);
                datagridProductosUser.DataSource = filterBs;
            }

            //////////////
            if (txtCategoria.Text == "" && txtMarca.Text != "" && txtPrecioMin.Text == "Min" && txtPrecioMax.Text != "Max")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Marca like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtMarca.Text, int.MinValue, int.Parse(txtPrecioMax.Text));
                datagridProductosUser.DataSource = filterBs;
            }

            //////////////
            if (txtCategoria.Text == "" && txtMarca.Text != "" && txtPrecioMin.Text != "Min" && txtPrecioMax.Text != "Max")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Marca like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtMarca.Text, int.Parse(txtPrecioMin.Text), int.Parse(txtPrecioMax.Text));
                datagridProductosUser.DataSource = filterBs;
            }

            datagridProductosUser.ClearSelection();
        }

        private void txtPrecioMin_TextChanged(object sender, EventArgs e)
        {
            txtPrecioMin.ForeColor = Color.Black;

            //////////
            if (txtPrecioMin.Text == "" && txtCategoria.Text != "")
            {
              
   
                    BindingSource filterBs = new BindingSource();
                    filterBs.DataSource = datagridProductosUser.DataSource;
                    filterBs.Filter = string.Format("Categoria like '%" + txtCategoria.Text + "%'");
                    datagridProductosUser.DataSource = filterBs;
                
            }

            //////////
            if (txtPrecioMin.Text == "" && txtMarca.Text != "")
            {
               
                    BindingSource filterBs = new BindingSource();
                    filterBs.DataSource = datagridProductosUser.DataSource;
                    filterBs.Filter = string.Format("Marca like '%" + txtMarca.Text + "%'");
                    datagridProductosUser.DataSource = filterBs;
            }

            //////////
            if (txtPrecioMin.Text != "" && txtPrecioMin.Text != "Min" && txtMarca.Text != "" && txtPrecioMax.Text == "Max")
            {

                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Marca like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtMarca.Text, int.Parse(txtPrecioMin.Text), int.MaxValue);
                datagridProductosUser.DataSource = filterBs;
            }

            //////////
            if (txtPrecioMin.Text == "Min" && txtCategoria.Text != "" && txtMarca.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%'",
                                                txtCategoria.Text, txtMarca.Text);
                datagridProductosUser.DataSource = filterBs;
            }


            //////////
            if (txtPrecioMin.Text != "Min" && txtPrecioMin.Text != "" && txtPrecioMax.Text == "Max" && txtMarca.Text == "" && txtCategoria.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtCategoria.Text, int.Parse(txtPrecioMin.Text), int.MaxValue);
                datagridProductosUser.DataSource = filterBs;
            }

            //////////
            if (txtPrecioMin.Text != "Min" && txtPrecioMin.Text != "" && txtPrecioMax.Text == "Max" && txtMarca.Text != "" && txtCategoria.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.MaxValue);
                datagridProductosUser.DataSource = filterBs;
            }


            if (txtPrecioMin.Text != "" && txtPrecioMin.Text != "Min")
            {
            }
            else
            {
                datagridProductosUser.ClearSelection();
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
                datagridProductosUser.ClearSelection();
                return;
            }
            //

            if (txtPrecioMin.Text != "" && txtPrecioMin.Text != "Min" && txtPrecioMax.Text != "Max" &&  txtCategoria.Text != "" && txtMarca.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.Parse(txtPrecioMax.Text));

                datagridProductosUser.DataSource = filterBs;
            }
           
            if(txtPrecioMin.Text == "Min" && txtPrecioMax.Text != "Max" && txtCategoria.Text != "" && txtMarca.Text != "")
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

            if (txtPrecioMax.Text == "" && txtCategoria.Text == "" && txtMarca.Text == "" && txtPrecioMin.Text == "Min")
            {
                //REINICIAR FILTROS
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = null;
                datagridProductosUser.DataSource = filterBs;
                //

                datagridProductosUser.ClearSelection();
            }


            //////////
            if (txtPrecioMax.Text == "" && txtCategoria.Text != "")
            {
                

                    BindingSource filterBs = new BindingSource();
                    filterBs.DataSource = datagridProductosUser.DataSource;
                    filterBs.Filter = string.Format("Categoria like '%" + txtCategoria.Text + "%'");
                    datagridProductosUser.DataSource = filterBs;
               
            }

            //////////
            if (txtPrecioMax.Text != "" && txtPrecioMax.Text != "Max" && txtMarca.Text != "" && txtPrecioMin.Text == "Min")
            {

                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Marca like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtMarca.Text, int.MinValue, int.Parse(txtPrecioMax.Text));
                datagridProductosUser.DataSource = filterBs;
            }

            //////////
            if (txtPrecioMax.Text == "" && txtMarca.Text != "" && txtPrecioMin.Text == "Min" && txtCategoria.Text == "")
            {

                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Marca like '%" + txtMarca.Text + "%'");
                datagridProductosUser.DataSource = filterBs;
            }

            //////////
            if (txtPrecioMax.Text == "" && txtMarca.Text != "" && txtCategoria.Text == "")
            {
            
                    BindingSource filterBs = new BindingSource();
                    filterBs.DataSource = datagridProductosUser.DataSource;
                    filterBs.Filter = string.Format("Marca like '%" + txtMarca.Text + "%'");
                    datagridProductosUser.DataSource = filterBs;
            }

            //////////
            if (txtPrecioMax.Text == "" && txtCategoria.Text != "" && txtMarca.Text != "")
            {
                    BindingSource filterBs = new BindingSource();
                    filterBs.DataSource = datagridProductosUser.DataSource;
                    filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%'",
                                                 txtCategoria.Text, txtMarca.Text);
                    datagridProductosUser.DataSource = filterBs;
                
            }

            //////////
            if (txtPrecioMax.Text != "Max" && txtPrecioMax.Text != "" && txtPrecioMin.Text == "Min" && txtMarca.Text == "" && txtCategoria.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Precio >= {1} AND Precio <= {2}",
                                                 txtCategoria.Text, int.MinValue, int.Parse(txtPrecioMax.Text));
                datagridProductosUser.DataSource = filterBs;
            }

            //////////
            if (txtPrecioMax.Text != "Max" && txtPrecioMax.Text != "" && txtPrecioMin.Text == "Min" && txtMarca.Text != "" && txtCategoria.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                 txtCategoria.Text, txtMarca.Text, int.MinValue, int.Parse(txtPrecioMax.Text));
                datagridProductosUser.DataSource = filterBs;
            }

            if (txtPrecioMax.Text != "" && txtPrecioMax.Text != "Max")
            {
            }
            else
            {
                datagridProductosUser.ClearSelection();
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
                datagridProductosUser.ClearSelection();
                return;
            }
            //

            if (txtPrecioMax.Text != "" && txtPrecioMax.Text != "Max" && txtPrecioMin.Text != "Min" 
                && txtCategoria.Text != "" && txtMarca.Text != "")
            {
                BindingSource filterBs = new BindingSource();
                filterBs.DataSource = datagridProductosUser.DataSource;
                filterBs.Filter = string.Format("Categoria like '%{0}%' AND Marca like '%{1}%' AND Precio >= {2} AND Precio <= {3}",
                                                  txtCategoria.Text, txtMarca.Text, int.Parse(txtPrecioMin.Text), int.Parse(txtPrecioMax.Text));

                datagridProductosUser.DataSource = filterBs;
            }

            if (txtPrecioMin.Text != "" && txtPrecioMin.Text != "Min" && txtPrecioMax.Text == "Max" && txtCategoria.Text != "" && txtMarca.Text != "")
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
            //Limpiar textboxs
            txtCategoria.Text = "";
            txtMarca.Text = "";
            txtPrecioMin.Text = "";
            txtPrecioMax.Text = "";

            //REINICIAR FILTROS
            BindingSource filterBs = new BindingSource();
            filterBs.DataSource = datagridProductosUser.DataSource;
            filterBs.Filter  = null;
            datagridProductosUser.DataSource = filterBs;
            //

            //Corregir textos
            txtPrecioMin_Leave(sender, e);
            txtPrecioMax_Leave(sender, e);

            //quitar focos
            FormUsuario_Click(sender, e);

        }

        private void datagridProductosUser_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridProductosUser.SelectedRows.Count > 0)
            {
                btnAgregar.Visible = true;
            }
            else
            {
                btnAgregar.Visible = false;
            }
          
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void txtPrecioMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un dígito o la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la entrada no válida
            }

            // Limitar la longitud del texto a 9 dígitos
            if (txtPrecioMin.Text.Length >= 9 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la entrada si ya hay 9 dígitos
            }
        }

        private void txtPrecioMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un dígito o la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la entrada no válida
            }

            // Limitar la longitud del texto a 9 dígitos
            if (txtPrecioMax.Text.Length >= 9 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la entrada si ya hay 9 dígitos
            }
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra o la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la entrada no válida
            }

            // Limitar la longitud del texto a 13 caracteres
            if (txtCategoria.Text.Length >= 13 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la entrada si ya hay 13 caracteres
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra, un número o la tecla de retroceso
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la entrada no válida
            }

            // Limitar la longitud del texto a 13 caracteres
            if (txtMarca.Text.Length >= 13 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la entrada si ya hay 13 caracteres
            }
        }
    }
}
