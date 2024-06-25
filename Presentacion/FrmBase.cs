using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    //NO BORRAR
    //Este es el formulario plantilla el cual contiene bordes customizados
    //
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        //el boton de cerrar el formulario
        //
        public void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //el boton de minimizar el formulario
        //
        public void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Este conjunto de metodos y variables permiten arrastrar el formulario
        // debido a que la title bar original fue borrada y remplazada por una custom
        //
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
        }
        //
    }
}
