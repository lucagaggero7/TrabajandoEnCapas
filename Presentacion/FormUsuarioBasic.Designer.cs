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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridProductosUser = new System.Windows.Forms.DataGridView();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecioMin = new System.Windows.Forms.TextBox();
            this.txtPrecioMax = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.btnBorrarFiltros = new System.Windows.Forms.Button();
            this.panelProductos = new System.Windows.Forms.Panel();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "null";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridProductosUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridProductosUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridProductosUser.DefaultCellStyle = dataGridViewCellStyle4;
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
            // 
            // btnCarrito
            // 
            this.btnCarrito.Font = new System.Drawing.Font("Open Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.Location = new System.Drawing.Point(609, 420);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(154, 40);
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
            this.txtPrecioMax.Leave += new System.EventHandler(this.txtPrecioMax_Leave);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 42);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 49;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 68);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 50;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 96);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 51;
            this.lblPrecio.Text = "Precio";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(666, 40);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(108, 33);
            this.btnCerrarSesion.TabIndex = 52;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Open Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(449, 420);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 40);
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
            this.lblFiltros.Location = new System.Drawing.Point(3, 0);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(85, 35);
            this.lblFiltros.TabIndex = 63;
            this.lblFiltros.Text = "FILTROS";
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.SystemColors.MenuHighlight;
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
            // FormUsuarioBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCarrito);
            this.Name = "FormUsuarioBasic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuarioBasic";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.Click += new System.EventHandler(this.FormUsuario_Click);
            this.Controls.SetChildIndex(this.btnCarrito, 0);
            this.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.panelFiltros, 0);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.panelProductos, 0);
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
        private Button btnCerrarSesion;
        private Button btnAgregar;
        private Label lblCarrito;
        private Label lblFiltros;
        private Panel panelFiltros;
        public DataGridView datagridProductosUser;
        private Button btnBorrarFiltros;
        private Panel panelProductos;
    }
}