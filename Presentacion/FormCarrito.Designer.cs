namespace Presentacion
{
    partial class FormCarrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrito));
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.datagridCarrito = new System.Windows.Forms.DataGridView();
            this.btnAgregarMas = new System.Windows.Forms.Button();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.panelCarrito = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCarrito)).BeginInit();
            this.panelCarrito.SuspendLayout();
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
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(524, 394);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(106, 52);
            this.btnFinalizar.TabIndex = 54;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // datagridCarrito
            // 
            this.datagridCarrito.AllowUserToAddRows = false;
            this.datagridCarrito.AllowUserToDeleteRows = false;
            this.datagridCarrito.AllowUserToResizeColumns = false;
            this.datagridCarrito.AllowUserToResizeRows = false;
            this.datagridCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridCarrito.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.datagridCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridCarrito.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.datagridCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridCarrito.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagridCarrito.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridCarrito.EnableHeadersVisualStyles = false;
            this.datagridCarrito.GridColor = System.Drawing.Color.DarkGray;
            this.datagridCarrito.Location = new System.Drawing.Point(0, 38);
            this.datagridCarrito.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.datagridCarrito.MultiSelect = false;
            this.datagridCarrito.Name = "datagridCarrito";
            this.datagridCarrito.ReadOnly = true;
            this.datagridCarrito.RowHeadersVisible = false;
            this.datagridCarrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagridCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCarrito.Size = new System.Drawing.Size(485, 198);
            this.datagridCarrito.TabIndex = 53;
            this.datagridCarrito.SelectionChanged += new System.EventHandler(this.datagridCarrito_SelectionChanged);
            // 
            // btnAgregarMas
            // 
            this.btnAgregarMas.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMas.Location = new System.Drawing.Point(404, 394);
            this.btnAgregarMas.Name = "btnAgregarMas";
            this.btnAgregarMas.Size = new System.Drawing.Size(110, 52);
            this.btnAgregarMas.TabIndex = 60;
            this.btnAgregarMas.Text = "Agregar mas productos";
            this.btnAgregarMas.UseVisualStyleBackColor = true;
            this.btnAgregarMas.Click += new System.EventHandler(this.btnAgregarMas_Click);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.BackColor = System.Drawing.Color.Transparent;
            this.lblCarrito.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.Location = new System.Drawing.Point(3, 0);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(120, 35);
            this.lblCarrito.TabIndex = 61;
            this.lblCarrito.Text = "MI CARRITO";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(145, 394);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(123, 52);
            this.btnQuitar.TabIndex = 62;
            this.btnQuitar.Text = "Quitar Producto del Carrito";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // panelCarrito
            // 
            this.panelCarrito.BackColor = System.Drawing.Color.AliceBlue;
            this.panelCarrito.Controls.Add(this.datagridCarrito);
            this.panelCarrito.Controls.Add(this.lblCarrito);
            this.panelCarrito.Location = new System.Drawing.Point(145, 84);
            this.panelCarrito.Name = "panelCarrito";
            this.panelCarrito.Size = new System.Drawing.Size(485, 236);
            this.panelCarrito.TabIndex = 63;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(400, 323);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 23);
            this.lblTotal.TabIndex = 64;
            this.lblTotal.Text = "EL TOTAL ES:";
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
            this.btnAtras.TabIndex = 65;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panelCarrito);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregarMas);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "FormCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCarrito";
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            this.Click += new System.EventHandler(this.FormCarrito_Click);
            this.Controls.SetChildIndex(this.btnFinalizar, 0);
            this.Controls.SetChildIndex(this.btnAgregarMas, 0);
            this.Controls.SetChildIndex(this.btnQuitar, 0);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.panelCarrito, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.btnAtras, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCarrito)).EndInit();
            this.panelCarrito.ResumeLayout(false);
            this.panelCarrito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAgregarMas;
        public System.Windows.Forms.DataGridView datagridCarrito;
        private System.Windows.Forms.Label lblCarrito;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Panel panelCarrito;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAtras;
    }
}