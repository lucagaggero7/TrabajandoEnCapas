namespace Presentacion
{
    partial class FormAdmProfes
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.datagridProfesionales = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(174, 104);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(98, 188);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(80, 27);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(114, 107);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // datagridProfesionales
            // 
            this.datagridProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProfesionales.Location = new System.Drawing.Point(421, 59);
            this.datagridProfesionales.Name = "datagridProfesionales";
            this.datagridProfesionales.Size = new System.Drawing.Size(345, 197);
            this.datagridProfesionales.TabIndex = 3;
            this.datagridProfesionales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridProfesionales_CellClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 145);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(184, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 27);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(114, 152);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(114, 243);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 7;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(270, 188);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(80, 27);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(98, 221);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 27);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormAdmProfes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 331);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.datagridProfesionales);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FormAdmProfes";
            this.Text = "FormAdmProfes";
            this.Load += new System.EventHandler(this.FormAdmProfes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridProfesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView datagridProfesionales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
    }
}