using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagridProductosUser = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelGrupo1 = new System.Windows.Forms.Panel();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.listPrecios = new System.Windows.Forms.CheckedListBox();
            this.btnMarca = new System.Windows.Forms.Button();
            this.listMarcas = new System.Windows.Forms.CheckedListBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.listCategorias = new System.Windows.Forms.CheckedListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductosUser)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelGrupo1.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
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
            this.datagridProductosUser.Location = new System.Drawing.Point(277, 92);
            this.datagridProductosUser.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.datagridProductosUser.MultiSelect = false;
            this.datagridProductosUser.Name = "datagridProductosUser";
            this.datagridProductosUser.ReadOnly = true;
            this.datagridProductosUser.RowHeadersVisible = false;
            this.datagridProductosUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridProductosUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridProductosUser.Size = new System.Drawing.Size(485, 250);
            this.datagridProductosUser.TabIndex = 38;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Open Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(32, 92);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(119, 35);
            this.btnFiltrar.TabIndex = 40;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Open Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(608, 360);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 40);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar al Carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelGrupo1);
            this.panelMenu.Location = new System.Drawing.Point(20, 133);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(228, 323);
            this.panelMenu.TabIndex = 47;
            this.panelMenu.Visible = false;
            // 
            // panelGrupo1
            // 
            this.panelGrupo1.Controls.Add(this.btnPrecio);
            this.panelGrupo1.Controls.Add(this.listPrecios);
            this.panelGrupo1.Controls.Add(this.btnMarca);
            this.panelGrupo1.Controls.Add(this.listMarcas);
            this.panelGrupo1.Controls.Add(this.btnCategoria);
            this.panelGrupo1.Controls.Add(this.listCategorias);
            this.panelGrupo1.Location = new System.Drawing.Point(9, 19);
            this.panelGrupo1.Name = "panelGrupo1";
            this.panelGrupo1.Size = new System.Drawing.Size(168, 301);
            this.panelGrupo1.TabIndex = 48;
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(3, 198);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(119, 23);
            this.btnPrecio.TabIndex = 52;
            this.btnPrecio.Text = "Precio";
            this.btnPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // listPrecios
            // 
            this.listPrecios.CheckOnClick = true;
            this.listPrecios.FormattingEnabled = true;
            this.listPrecios.Location = new System.Drawing.Point(3, 227);
            this.listPrecios.Name = "listPrecios";
            this.listPrecios.Size = new System.Drawing.Size(119, 64);
            this.listPrecios.TabIndex = 51;
            this.listPrecios.Visible = false;
            this.listPrecios.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listPrecios_ItemCheck);
            this.listPrecios.SelectedValueChanged += new System.EventHandler(this.listPrecios_SelectedValueChanged);
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(3, 99);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(119, 23);
            this.btnMarca.TabIndex = 50;
            this.btnMarca.Text = "Marca";
            this.btnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // listMarcas
            // 
            this.listMarcas.CheckOnClick = true;
            this.listMarcas.FormattingEnabled = true;
            this.listMarcas.Location = new System.Drawing.Point(3, 126);
            this.listMarcas.Name = "listMarcas";
            this.listMarcas.Size = new System.Drawing.Size(119, 64);
            this.listMarcas.TabIndex = 49;
            this.listMarcas.Visible = false;
            this.listMarcas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listMarcas_ItemCheck);
            this.listMarcas.SelectedValueChanged += new System.EventHandler(this.listMarcas_SelectedValueChanged);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(3, 3);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(119, 23);
            this.btnCategoria.TabIndex = 48;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // listCategorias
            // 
            this.listCategorias.CheckOnClick = true;
            this.listCategorias.FormattingEnabled = true;
            this.listCategorias.Location = new System.Drawing.Point(3, 29);
            this.listCategorias.Name = "listCategorias";
            this.listCategorias.Size = new System.Drawing.Size(119, 64);
            this.listCategorias.TabIndex = 48;
            this.listCategorias.Visible = false;
            this.listCategorias.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listCategorias_ItemCheck);
            this.listCategorias.SelectedValueChanged += new System.EventHandler(this.listCategorias_SelectedValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.SelectionTimer_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.SelectionTimer_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.SelectionTimer_Tick);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.datagridProductosUser);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.Click += new System.EventHandler(this.FormUsuario_Click);
            this.Controls.SetChildIndex(this.datagridProductosUser, 0);
            this.Controls.SetChildIndex(this.btnFiltrar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.panelMenu, 0);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductosUser)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelGrupo1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridProductosUser;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGrupo1;
        private System.Windows.Forms.CheckedListBox listCategorias;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.CheckedListBox listPrecios;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.CheckedListBox listMarcas;
        private Timer timer1;
        private Timer timer2;
        private Timer timer3;
    }
}