namespace Presentacion
{
    partial class PreLogin
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnNoAcc = new System.Windows.Forms.Button();
            this.panelTransparente = new System.Windows.Forms.Panel();
            this.PanelBarraTitulo.SuspendLayout();
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Lavender;
            this.lblTitulo.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(178, 205);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(432, 27);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Para acceder como administrador Inicie Sesion";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(285, 247);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 51);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnNoAcc
            // 
            this.btnNoAcc.BackColor = System.Drawing.Color.White;
            this.btnNoAcc.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoAcc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNoAcc.Location = new System.Drawing.Point(285, 313);
            this.btnNoAcc.Name = "btnNoAcc";
            this.btnNoAcc.Size = new System.Drawing.Size(216, 51);
            this.btnNoAcc.TabIndex = 3;
            this.btnNoAcc.Text = "Continuar Sin Cuenta";
            this.btnNoAcc.UseVisualStyleBackColor = false;
            this.btnNoAcc.Click += new System.EventHandler(this.btnNoAcc_Click);
            // 
            // panelTransparente
            // 
            this.panelTransparente.BackColor = System.Drawing.Color.Transparent;
            this.panelTransparente.Location = new System.Drawing.Point(331, 92);
            this.panelTransparente.Name = "panelTransparente";
            this.panelTransparente.Size = new System.Drawing.Size(116, 110);
            this.panelTransparente.TabIndex = 7;
            this.panelTransparente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTransparente_Paint);
            // 
            // PreLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.btnNoAcc);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelTransparente);
            this.Name = "PreLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreLogin";
            this.Controls.SetChildIndex(this.panelTransparente, 0);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.btnNoAcc, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnNoAcc;
        private System.Windows.Forms.Panel panelTransparente;
    }
}