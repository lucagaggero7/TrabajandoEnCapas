using Presentacion.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class PreLogin : FrmBase
    {
        public PreLogin()
        {
            InitializeComponent();
        }

        private void panelTransparente_Paint(object sender, PaintEventArgs e)
        {
            // Accede a la imagen desde los recursos del proyecto
            Image imagenConFondoTransparente = Properties.Resources.signin; // Reemplaza 'NombreDeTuImagen' con el nombre real de tu recurso

            // Escala y dibuja la imagen para que se ajuste al tamaño del Panel
            e.Graphics.DrawImage(imagenConFondoTransparente, new Rectangle(0, 0, panelTransparente.Width, panelTransparente.Height));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login frm2 = new Login();
            this.AddOwnedForm(frm2);

            frm2.Show();
            this.Hide();
        }

        private void btnNoAcc_Click(object sender, EventArgs e)
        {
            FormUsuarioBasic frm3 = new FormUsuarioBasic();
            this.AddOwnedForm(frm3);

            frm3.Show();
            this.Hide();
        }
    }
}
