namespace Presentacion
{
    partial class FormUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridProductosUser = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.filtroCategoria = new System.Windows.Forms.ComboBox();
            this.filtroMarca = new System.Windows.Forms.ComboBox();
            this.filtroPrecio = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductosUser)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridProductosUser
            // 
            this.datagridProductosUser.AllowUserToAddRows = false;
            this.datagridProductosUser.AllowUserToDeleteRows = false;
            this.datagridProductosUser.AllowUserToResizeColumns = false;
            this.datagridProductosUser.AllowUserToResizeRows = false;
            this.datagridProductosUser.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.datagridProductosUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridProductosUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridProductosUser.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.datagridProductosUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = "null";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridProductosUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridProductosUser.ColumnHeadersHeight = 30;
            this.datagridProductosUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridProductosUser.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridProductosUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridProductosUser.EnableHeadersVisualStyles = false;
            this.datagridProductosUser.GridColor = System.Drawing.Color.DarkGray;
            this.datagridProductosUser.Location = new System.Drawing.Point(308, 46);
            this.datagridProductosUser.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.datagridProductosUser.MultiSelect = false;
            this.datagridProductosUser.Name = "datagridProductosUser";
            this.datagridProductosUser.ReadOnly = true;
            this.datagridProductosUser.RowHeadersVisible = false;
            this.datagridProductosUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridProductosUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridProductosUser.Size = new System.Drawing.Size(455, 250);
            this.datagridProductosUser.TabIndex = 39;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Open Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(121, 57);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(128, 40);
            this.btnFiltrar.TabIndex = 40;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // filtroCategoria
            // 
            this.filtroCategoria.FormattingEnabled = true;
            this.filtroCategoria.Location = new System.Drawing.Point(121, 112);
            this.filtroCategoria.Name = "filtroCategoria";
            this.filtroCategoria.Size = new System.Drawing.Size(128, 21);
            this.filtroCategoria.TabIndex = 41;
            this.filtroCategoria.Text = "Categorias";
            this.filtroCategoria.Visible = false;
            this.filtroCategoria.SelectionChangeCommitted += new System.EventHandler(this.filtroCategoria_SelectionChangeCommitted);
            // 
            // filtroMarca
            // 
            this.filtroMarca.FormattingEnabled = true;
            this.filtroMarca.Location = new System.Drawing.Point(121, 148);
            this.filtroMarca.Name = "filtroMarca";
            this.filtroMarca.Size = new System.Drawing.Size(128, 21);
            this.filtroMarca.TabIndex = 42;
            this.filtroMarca.Text = "Marcas";
            this.filtroMarca.Visible = false;
            this.filtroMarca.SelectionChangeCommitted += new System.EventHandler(this.filtroMarca_SelectionChangeCommitted);
            // 
            // filtroPrecio
            // 
            this.filtroPrecio.FormattingEnabled = true;
            this.filtroPrecio.Location = new System.Drawing.Point(121, 186);
            this.filtroPrecio.Name = "filtroPrecio";
            this.filtroPrecio.Size = new System.Drawing.Size(128, 21);
            this.filtroPrecio.TabIndex = 43;
            this.filtroPrecio.Text = "Precio mayor a menor";
            this.filtroPrecio.Visible = false;
            this.filtroPrecio.SelectionChangeCommitted += new System.EventHandler(this.filtroPrecio_SelectionChangeCommitted);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Open Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(609, 314);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 40);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar al Carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.filtroPrecio);
            this.Controls.Add(this.filtroMarca);
            this.Controls.Add(this.filtroCategoria);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.datagridProductosUser);
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductosUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridProductosUser;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox filtroCategoria;
        private System.Windows.Forms.ComboBox filtroMarca;
        private System.Windows.Forms.ComboBox filtroPrecio;
        private System.Windows.Forms.Button btnAgregar;
    }
}