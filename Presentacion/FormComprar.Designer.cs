namespace Presentacion
{
    partial class FormComprar
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
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelNombre = new System.Windows.Forms.Panel();
            this.panelLinea1 = new System.Windows.Forms.Panel();
            this.txtLinea1 = new System.Windows.Forms.TextBox();
            this.panelLinea2 = new System.Windows.Forms.Panel();
            this.txtLinea2 = new System.Windows.Forms.TextBox();
            this.panelCodPostal = new System.Windows.Forms.Panel();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.panelTelefono = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.panelDni = new System.Windows.Forms.Panel();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listResumen = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblNTotal = new System.Windows.Forms.Label();
            this.lblGratis = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodigoPostal = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLinea1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.rtbCampos = new System.Windows.Forms.RichTextBox();
            this.lblCampo1 = new System.Windows.Forms.Label();
            this.blCampo2 = new System.Windows.Forms.Label();
            this.lblCampo3 = new System.Windows.Forms.Label();
            this.lblCampo4 = new System.Windows.Forms.Label();
            this.lblCampo5 = new System.Windows.Forms.Label();
            this.PanelBarraTitulo.SuspendLayout();
            this.panelNombre.SuspendLayout();
            this.panelLinea1.SuspendLayout();
            this.panelLinea2.SuspendLayout();
            this.panelCodPostal.SuspendLayout();
            this.panelTelefono.SuspendLayout();
            this.panelDni.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoPostal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLinea1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.Visible = false;
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.Visible = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Visible = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(36, 47);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(151, 23);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion de envio";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNombre.Location = new System.Drawing.Point(6, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 18);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre(s) y Apellido";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // panelNombre
            // 
            this.panelNombre.BackColor = System.Drawing.Color.White;
            this.panelNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNombre.Controls.Add(this.txtNombre);
            this.panelNombre.Location = new System.Drawing.Point(40, 85);
            this.panelNombre.Name = "panelNombre";
            this.panelNombre.Size = new System.Drawing.Size(154, 35);
            this.panelNombre.TabIndex = 3;
            // 
            // panelLinea1
            // 
            this.panelLinea1.BackColor = System.Drawing.Color.White;
            this.panelLinea1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLinea1.Controls.Add(this.txtLinea1);
            this.panelLinea1.Location = new System.Drawing.Point(40, 137);
            this.panelLinea1.Name = "panelLinea1";
            this.panelLinea1.Size = new System.Drawing.Size(154, 35);
            this.panelLinea1.TabIndex = 4;
            // 
            // txtLinea1
            // 
            this.txtLinea1.BackColor = System.Drawing.Color.White;
            this.txtLinea1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLinea1.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea1.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLinea1.Location = new System.Drawing.Point(6, 3);
            this.txtLinea1.Name = "txtLinea1";
            this.txtLinea1.Size = new System.Drawing.Size(147, 18);
            this.txtLinea1.TabIndex = 2;
            this.txtLinea1.Text = "Direccion Linea #1";
            this.txtLinea1.Click += new System.EventHandler(this.txtLinea1_Click);
            this.txtLinea1.TextChanged += new System.EventHandler(this.txtLinea1_TextChanged);
            this.txtLinea1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLinea1_KeyDown);
            this.txtLinea1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLinea1_KeyPress);
            this.txtLinea1.Leave += new System.EventHandler(this.txtLinea1_Leave);
            // 
            // panelLinea2
            // 
            this.panelLinea2.BackColor = System.Drawing.Color.White;
            this.panelLinea2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLinea2.Controls.Add(this.txtLinea2);
            this.panelLinea2.Location = new System.Drawing.Point(40, 188);
            this.panelLinea2.Name = "panelLinea2";
            this.panelLinea2.Size = new System.Drawing.Size(154, 35);
            this.panelLinea2.TabIndex = 5;
            // 
            // txtLinea2
            // 
            this.txtLinea2.BackColor = System.Drawing.Color.White;
            this.txtLinea2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLinea2.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea2.ForeColor = System.Drawing.Color.DarkGray;
            this.txtLinea2.Location = new System.Drawing.Point(6, 3);
            this.txtLinea2.Name = "txtLinea2";
            this.txtLinea2.Size = new System.Drawing.Size(147, 18);
            this.txtLinea2.TabIndex = 2;
            this.txtLinea2.Text = "Direccion Linea #2 (opcional)";
            this.txtLinea2.Click += new System.EventHandler(this.txtLinea2_Click);
            this.txtLinea2.TextChanged += new System.EventHandler(this.txtLinea2_TextChanged);
            this.txtLinea2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLinea2_KeyDown);
            this.txtLinea2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLinea2_KeyPress);
            this.txtLinea2.Leave += new System.EventHandler(this.txtLinea2_Leave);
            // 
            // panelCodPostal
            // 
            this.panelCodPostal.BackColor = System.Drawing.Color.White;
            this.panelCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCodPostal.Controls.Add(this.txtCodPostal);
            this.panelCodPostal.Location = new System.Drawing.Point(40, 239);
            this.panelCodPostal.Name = "panelCodPostal";
            this.panelCodPostal.Size = new System.Drawing.Size(154, 35);
            this.panelCodPostal.TabIndex = 6;
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.BackColor = System.Drawing.Color.White;
            this.txtCodPostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodPostal.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPostal.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCodPostal.Location = new System.Drawing.Point(6, 3);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(147, 18);
            this.txtCodPostal.TabIndex = 2;
            this.txtCodPostal.Text = "Codigo Postal";
            this.txtCodPostal.Click += new System.EventHandler(this.txtCodPostal_Click);
            this.txtCodPostal.TextChanged += new System.EventHandler(this.txtCodPostal_TextChanged);
            this.txtCodPostal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodPostal_KeyDown);
            this.txtCodPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPostal_KeyPress);
            this.txtCodPostal.Leave += new System.EventHandler(this.txtCodPostal_Leave);
            // 
            // panelTelefono
            // 
            this.panelTelefono.BackColor = System.Drawing.Color.White;
            this.panelTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTelefono.Controls.Add(this.txtTelefono);
            this.panelTelefono.Location = new System.Drawing.Point(40, 289);
            this.panelTelefono.Name = "panelTelefono";
            this.panelTelefono.Size = new System.Drawing.Size(154, 35);
            this.panelTelefono.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.Location = new System.Drawing.Point(6, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(147, 18);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.Text = "Telefono (8 a 15 digitos)";
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Click);
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // panelDni
            // 
            this.panelDni.BackColor = System.Drawing.Color.White;
            this.panelDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDni.Controls.Add(this.txtDni);
            this.panelDni.Location = new System.Drawing.Point(40, 339);
            this.panelDni.Name = "panelDni";
            this.panelDni.Size = new System.Drawing.Size(154, 35);
            this.panelDni.TabIndex = 8;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.White;
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDni.Location = new System.Drawing.Point(6, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(147, 18);
            this.txtDni.TabIndex = 2;
            this.txtDni.Text = "DNI (ej. 12345678)";
            this.txtDni.Click += new System.EventHandler(this.txtDni_Click);
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(639, 400);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(99, 43);
            this.btnComprar.TabIndex = 55;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(534, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 43);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listResumen
            // 
            this.listResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listResumen.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResumen.FormattingEnabled = true;
            this.listResumen.ItemHeight = 17;
            this.listResumen.Location = new System.Drawing.Point(-1, -1);
            this.listResumen.Name = "listResumen";
            this.listResumen.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listResumen.Size = new System.Drawing.Size(332, 70);
            this.listResumen.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblResumen);
            this.panel1.Controls.Add(this.lblIva);
            this.panel1.Controls.Add(this.lblNTotal);
            this.panel1.Controls.Add(this.lblGratis);
            this.panel1.Controls.Add(this.lblSubtotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.lblEntrega);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Controls.Add(this.listResumen);
            this.panel1.Location = new System.Drawing.Point(380, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 211);
            this.panel1.TabIndex = 58;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(3, 70);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(186, 23);
            this.lblResumen.TabIndex = 59;
            this.lblResumen.Text = "RESUMEN DEL PEDIDO";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.ForeColor = System.Drawing.Color.DarkGray;
            this.lblIva.Location = new System.Drawing.Point(3, 188);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(79, 22);
            this.lblIva.TabIndex = 64;
            this.lblIva.Text = "(IVA incluido)";
            // 
            // lblNTotal
            // 
            this.lblNTotal.AutoSize = true;
            this.lblNTotal.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTotal.Location = new System.Drawing.Point(204, 169);
            this.lblNTotal.Name = "lblNTotal";
            this.lblNTotal.Size = new System.Drawing.Size(48, 22);
            this.lblNTotal.TabIndex = 63;
            this.lblNTotal.Text = "NTotal";
            // 
            // lblGratis
            // 
            this.lblGratis.AutoSize = true;
            this.lblGratis.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratis.Location = new System.Drawing.Point(204, 127);
            this.lblGratis.Name = "lblGratis";
            this.lblGratis.Size = new System.Drawing.Size(40, 22);
            this.lblGratis.TabIndex = 62;
            this.lblGratis.Text = "Gratis";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(204, 105);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(54, 22);
            this.lblSubtotal.TabIndex = 61;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(3, 169);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 22);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "Total";
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrega.Location = new System.Drawing.Point(3, 127);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(49, 22);
            this.lblEntrega.TabIndex = 59;
            this.lblEntrega.Text = "Entrega";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Open Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(3, 105);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(63, 22);
            this.lblProductos.TabIndex = 58;
            this.lblProductos.Text = "Productos";
            // 
            // errorTelefono
            // 
            this.errorTelefono.ContainerControl = this;
            // 
            // errorCodigoPostal
            // 
            this.errorCodigoPostal.ContainerControl = this;
            // 
            // errorDni
            // 
            this.errorDni.ContainerControl = this;
            // 
            // errorLinea1
            // 
            this.errorLinea1.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // rtbCampos
            // 
            this.rtbCampos.BackColor = System.Drawing.Color.Azure;
            this.rtbCampos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCampos.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCampos.Location = new System.Drawing.Point(40, 400);
            this.rtbCampos.Name = "rtbCampos";
            this.rtbCampos.Size = new System.Drawing.Size(154, 26);
            this.rtbCampos.TabIndex = 60;
            this.rtbCampos.Text = "* Campos Obligatorios";
            // 
            // lblCampo1
            // 
            this.lblCampo1.AutoSize = true;
            this.lblCampo1.BackColor = System.Drawing.Color.Transparent;
            this.lblCampo1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo1.ForeColor = System.Drawing.Color.Red;
            this.lblCampo1.Location = new System.Drawing.Point(19, 89);
            this.lblCampo1.Name = "lblCampo1";
            this.lblCampo1.Size = new System.Drawing.Size(16, 19);
            this.lblCampo1.TabIndex = 62;
            this.lblCampo1.Text = "*";
            // 
            // blCampo2
            // 
            this.blCampo2.AutoSize = true;
            this.blCampo2.BackColor = System.Drawing.Color.Transparent;
            this.blCampo2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blCampo2.ForeColor = System.Drawing.Color.Red;
            this.blCampo2.Location = new System.Drawing.Point(19, 141);
            this.blCampo2.Name = "blCampo2";
            this.blCampo2.Size = new System.Drawing.Size(16, 19);
            this.blCampo2.TabIndex = 63;
            this.blCampo2.Text = "*";
            // 
            // lblCampo3
            // 
            this.lblCampo3.AutoSize = true;
            this.lblCampo3.BackColor = System.Drawing.Color.Transparent;
            this.lblCampo3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo3.ForeColor = System.Drawing.Color.Red;
            this.lblCampo3.Location = new System.Drawing.Point(19, 243);
            this.lblCampo3.Name = "lblCampo3";
            this.lblCampo3.Size = new System.Drawing.Size(16, 19);
            this.lblCampo3.TabIndex = 65;
            this.lblCampo3.Text = "*";
            // 
            // lblCampo4
            // 
            this.lblCampo4.AutoSize = true;
            this.lblCampo4.BackColor = System.Drawing.Color.Transparent;
            this.lblCampo4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo4.ForeColor = System.Drawing.Color.Red;
            this.lblCampo4.Location = new System.Drawing.Point(19, 292);
            this.lblCampo4.Name = "lblCampo4";
            this.lblCampo4.Size = new System.Drawing.Size(16, 19);
            this.lblCampo4.TabIndex = 66;
            this.lblCampo4.Text = "*";
            // 
            // lblCampo5
            // 
            this.lblCampo5.AutoSize = true;
            this.lblCampo5.BackColor = System.Drawing.Color.Transparent;
            this.lblCampo5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo5.ForeColor = System.Drawing.Color.Red;
            this.lblCampo5.Location = new System.Drawing.Point(19, 343);
            this.lblCampo5.Name = "lblCampo5";
            this.lblCampo5.Size = new System.Drawing.Size(16, 19);
            this.lblCampo5.TabIndex = 67;
            this.lblCampo5.Text = "*";
            // 
            // FormComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.lblCampo5);
            this.Controls.Add(this.lblCampo4);
            this.Controls.Add(this.lblCampo3);
            this.Controls.Add(this.blCampo2);
            this.Controls.Add(this.lblCampo1);
            this.Controls.Add(this.rtbCampos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.panelDni);
            this.Controls.Add(this.panelTelefono);
            this.Controls.Add(this.panelCodPostal);
            this.Controls.Add(this.panelLinea2);
            this.Controls.Add(this.panelLinea1);
            this.Controls.Add(this.panelNombre);
            this.Controls.Add(this.lblDireccion);
            this.Name = "FormComprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormComprar";
            this.Load += new System.EventHandler(this.FormComprar_Load);
            this.Click += new System.EventHandler(this.FormComprar_Click);
            this.Controls.SetChildIndex(this.lblDireccion, 0);
            this.Controls.SetChildIndex(this.panelNombre, 0);
            this.Controls.SetChildIndex(this.panelLinea1, 0);
            this.Controls.SetChildIndex(this.panelLinea2, 0);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.panelCodPostal, 0);
            this.Controls.SetChildIndex(this.panelTelefono, 0);
            this.Controls.SetChildIndex(this.panelDni, 0);
            this.Controls.SetChildIndex(this.btnComprar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.rtbCampos, 0);
            this.Controls.SetChildIndex(this.lblCampo1, 0);
            this.Controls.SetChildIndex(this.blCampo2, 0);
            this.Controls.SetChildIndex(this.lblCampo3, 0);
            this.Controls.SetChildIndex(this.lblCampo4, 0);
            this.Controls.SetChildIndex(this.lblCampo5, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            this.panelNombre.ResumeLayout(false);
            this.panelNombre.PerformLayout();
            this.panelLinea1.ResumeLayout(false);
            this.panelLinea1.PerformLayout();
            this.panelLinea2.ResumeLayout(false);
            this.panelLinea2.PerformLayout();
            this.panelCodPostal.ResumeLayout(false);
            this.panelCodPostal.PerformLayout();
            this.panelTelefono.ResumeLayout(false);
            this.panelTelefono.PerformLayout();
            this.panelDni.ResumeLayout(false);
            this.panelDni.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoPostal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLinea1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Panel panelNombre;
        private System.Windows.Forms.Panel panelLinea1;
        private System.Windows.Forms.TextBox txtLinea1;
        private System.Windows.Forms.Panel panelLinea2;
        private System.Windows.Forms.TextBox txtLinea2;
        private System.Windows.Forms.Panel panelCodPostal;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Panel panelTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Panel panelDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox listResumen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNTotal;
        private System.Windows.Forms.Label lblGratis;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.ErrorProvider errorTelefono;
        private System.Windows.Forms.ErrorProvider errorCodigoPostal;
        private System.Windows.Forms.ErrorProvider errorDni;
        private System.Windows.Forms.ErrorProvider errorLinea1;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.RichTextBox rtbCampos;
        private System.Windows.Forms.Label lblCampo5;
        private System.Windows.Forms.Label lblCampo4;
        private System.Windows.Forms.Label lblCampo3;
        private System.Windows.Forms.Label blCampo2;
        private System.Windows.Forms.Label lblCampo1;
        public System.Windows.Forms.TextBox txtNombre;
    }
}