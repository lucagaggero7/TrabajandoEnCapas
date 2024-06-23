using System.Windows.Forms;

namespace Presentacion
{
    partial class FormUsuarioBasic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarioBasic));
            this.datagridProductosUser = new System.Windows.Forms.DataGridView();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnBorrarFiltros = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductosUser)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            // 
            // datagridProductosUser
            // 
            this.datagridProductosUser.AllowUserToAddRows = false;
            this.datagridProductosUser.AllowUserToDeleteRows = false;
            this.datagridProductosUser.AllowUserToResizeColumns = false;
            this.datagridProductosUser.AllowUserToResizeRows = false;
            this.datagridProductosUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridProductosUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridProductosUser.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.datagridProductosUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridProductosUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridProductosUser.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.datagridProductosUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridProductosUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridProductosUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridProductosUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridProductosUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridProductosUser.EnableHeadersVisualStyles = false;
            this.datagridProductosUser.GridColor = System.Drawing.Color.DarkGray;
            this.datagridProductosUser.Location = new System.Drawing.Point(0, 38);
            this.datagridProductosUser.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.datagridProductosUser.MultiSelect = false;
            this.datagridProductosUser.Name = "datagridProductosUser";
            this.datagridProductosUser.ReadOnly = true;
            this.datagridProductosUser.RowHeadersVisible = false;
            this.datagridProductosUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridProductosUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridProductosUser.Size = new System.Drawing.Size(485, 276);
            this.datagridProductosUser.TabIndex = 38;
            this.datagridProductosUser.SelectionChanged += new System.EventHandler(this.datagridProductosUser_SelectionChanged);
            // 
            // btnCarrito
            // 
            this.btnCarrito.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.Location = new System.Drawing.Point(621, 420);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(133, 40);
            this.btnCarrito.TabIndex = 44;
            this.btnCarrito.Text = "Ir al Carrito";
            this.btnCarrito.UseVisualStyleBackColor = true;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCategoria.Location = new System.Drawing.Point(64, 38);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(119, 22);
            this.txtCategoria.TabIndex = 45;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            this.txtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoria_KeyPress);
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMarca.Location = new System.Drawing.Point(64, 64);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(119, 22);
            this.txtMarca.TabIndex = 46;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            this.txtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMarca_KeyPress);
            // 
            // txtPrecioMin
            // 
            this.txtPrecioMin.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMin.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrecioMin.Location = new System.Drawing.Point(64, 92);
            this.txtPrecioMin.Name = "txtPrecioMin";
            this.txtPrecioMin.Size = new System.Drawing.Size(51, 22);
            this.txtPrecioMin.TabIndex = 47;
            this.txtPrecioMin.Text = "Min";
            this.txtPrecioMin.Click += new System.EventHandler(this.txtPrecioMin_Click);
            this.txtPrecioMin.TextChanged += new System.EventHandler(this.txtPrecioMin_TextChanged);
            this.txtPrecioMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioMin_KeyDown);
            this.txtPrecioMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMin_KeyPress);
            this.txtPrecioMin.Leave += new System.EventHandler(this.txtPrecioMin_Leave);
            // 
            // txtPrecioMax
            // 
            this.txtPrecioMax.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMax.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrecioMax.Location = new System.Drawing.Point(121, 92);
            this.txtPrecioMax.Name = "txtPrecioMax";
            this.txtPrecioMax.Size = new System.Drawing.Size(62, 22);
            this.txtPrecioMax.TabIndex = 48;
            this.txtPrecioMax.Text = "Max";
            this.txtPrecioMax.Click += new System.EventHandler(this.txtPrecioMax_Click);
            this.txtPrecioMax.TextChanged += new System.EventHandler(this.txtPrecioMax_TextChanged);
            this.txtPrecioMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioMax_KeyDown);
            this.txtPrecioMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMax_KeyPress);
            this.txtPrecioMax.Leave += new System.EventHandler(this.txtPrecioMax_Leave);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(6, 42);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 49;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(6, 68);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 50;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(6, 96);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 51;
            this.lblPrecio.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(482, 420);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 40);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar al Carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.BackColor = System.Drawing.Color.Transparent;
            this.lblCarrito.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.Location = new System.Drawing.Point(3, 0);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(123, 35);
            this.lblCarrito.TabIndex = 62;
            this.lblCarrito.Text = "PRODUCTOS";
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.ForeColor = System.Drawing.Color.White;
            this.lblFiltros.Location = new System.Drawing.Point(3, 0);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(85, 35);
            this.lblFiltros.TabIndex = 63;
            this.lblFiltros.Text = "FILTROS";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(25)))), ((int)(((byte)(67)))));
            this.panelFiltros.Controls.Add(this.btnBorrarFiltros);
            this.panelFiltros.Controls.Add(this.txtPrecioMax);
            this.panelFiltros.Controls.Add(this.txtCategoria);
            this.panelFiltros.Controls.Add(this.lblFiltros);
            this.panelFiltros.Controls.Add(this.txtMarca);
            this.panelFiltros.Controls.Add(this.txtPrecioMin);
            this.panelFiltros.Controls.Add(this.lblCategoria);
            this.panelFiltros.Controls.Add(this.lblMarca);
            this.panelFiltros.Controls.Add(this.lblPrecio);
            this.panelFiltros.Location = new System.Drawing.Point(28, 79);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(220, 157);
            this.panelFiltros.TabIndex = 64;
            // 
            // btnBorrarFiltros
            // 
            this.btnBorrarFiltros.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFiltros.Location = new System.Drawing.Point(64, 120);
            this.btnBorrarFiltros.Name = "btnBorrarFiltros";
            this.btnBorrarFiltros.Size = new System.Drawing.Size(119, 28);
            this.btnBorrarFiltros.TabIndex = 65;
            this.btnBorrarFiltros.Text = "Borrar Filtros";
            this.btnBorrarFiltros.UseVisualStyleBackColor = true;
            this.btnBorrarFiltros.Click += new System.EventHandler(this.btnBorrarFiltros_Click);
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.AliceBlue;
            this.panelProductos.Controls.Add(this.lblCarrito);
            this.panelProductos.Controls.Add(this.datagridProductosUser);
            this.panelProductos.Location = new System.Drawing.Point(269, 79);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(485, 335);
            this.panelProductos.TabIndex = 65;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAtras.Location = new System.Drawing.Point(12, 40);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(31, 28);
            this.btnAtras.TabIndex = 66;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormUsuarioBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCarrito);
            this.Name = "FormUsuarioBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuarioBasic";
            this.Load += new System.EventHandler(this.FormUsuarioBasic_Load);
            this.Click += new System.EventHandler(this.FormUsuarioBasic_Click);
            this.Controls.SetChildIndex(this.btnCarrito, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.panelFiltros, 0);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.panelProductos, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductosUser)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelProductos.ResumeLayout(false);
            this.panelProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCarrito;
        private TextBox txtCategoria;
        private TextBox txtMarca;
        private TextBox txtPrecioMin;
        private TextBox txtPrecioMax;
        private Label lblCategoria;
        private Label lblMarca;
        private Label lblPrecio;
        private Button btnAgregar;
        private Label lblCarrito;
        private Label lblFiltros;
        private Panel panelFiltros;
        public DataGridView datagridProductosUser;
        private Button btnBorrarFiltros;
        private Panel panelProductos;
        private Button btnAtras;
    }
}