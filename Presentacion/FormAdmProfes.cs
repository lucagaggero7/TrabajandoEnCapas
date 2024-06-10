using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;


namespace Presentacion
{
    public partial class FormAdmProfes : Form
    {
        public Profesional objEntProf = new Profesional();

        public NegProfesionales objNegProf = new NegProfesionales();

        public FormAdmProfes()
        {
            InitializeComponent();
            datagridProfesionales.ColumnCount = 2;
            datagridProfesionales.Columns[0].HeaderText = "Código";
            datagridProfesionales.Columns[1].HeaderText = "Nombre";
            datagridProfesionales.Columns[0].Width = 60;
            datagridProfesionales.Columns[1].Width = 200;
            LlenarDataGrid();
        }

        private void FormAdmProfes_Load(object sender, EventArgs e)
        {

        }

        private void LlenarDataGrid()
        {
            
            datagridProfesionales.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegProf.listadoProfesionales("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    datagridProfesionales.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else
                lblMensaje.Text = "No hay profesionales cargados en el sistema";
        }
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void TxtBox_a_Clase() //Prepara el objeto a enviar a la capa de Negocio
        {
            objEntProf.CodProf = int.Parse(txtCodigo.Text);
            objEntProf.Nombre = txtNombre.Text;
        }

        private void Ds_a_TxtBox(DataSet ds)
        {
            txtCodigo.Text = ds.Tables[0].Rows[0]["CodProf"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtCodigo.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            //llamo al método que carga los datos del objeto
            TxtBox_a_Clase();
            nGrabados = objNegProf.abmProfesionales("Agregar", objEntProf); //invoco a la capa de negocio
                
                if (nGrabados == -1)
                lblMensaje.Text = " No pudo grabar profesionales en el sistema";
            else
            {
                lblMensaje.Text = " Se grabó con éxito profesionales.";
                LlenarDataGrid();
                Limpiar();
            }
        }

        private void datagridProfesionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objEntProf.CodProf = Convert.ToInt32(datagridProfesionales.CurrentRow.Cells[0].Value);
            ds = objNegProf.listadoProfesionales(objEntProf.CodProf.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                btnCargar.Visible = false;
                lblMensaje.Text = string.Empty;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int nResultado = -1;
            TxtBox_a_Clase();
            nResultado = objNegProf.abmProfesionales("Modificar", objEntProf); //invoco a la capa de negocio
            
            if (nResultado != -1)
            {
                MessageBox.Show("Aviso", "El Profesional fue Modificado con éxito");
                Limpiar();
                LlenarDataGrid();

                txtCodigo.Enabled = true;

            }
            else
                MessageBox.Show("Error", "Se produjo un error al intentar modificar el Profesional", MessageBoxButtons.OK, MessageBoxIcon.Error);
}

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int nBorrados = -1;
            //llamo al método que carga los datos del objeto
            TxtBox_a_Clase();
            nBorrados = objNegProf.abmProfesionales("Borrar", objEntProf); //invoco a la capa de negocio

            if (nBorrados == -1)
                lblMensaje.Text = " No pudo borrar profesionales en el sistema";
            else
            {
                lblMensaje.Text = " Se borro con éxito profesionales.";
                LlenarDataGrid();
                Limpiar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //int nBuscado = -1;
            //TxtBox_a_Clase();
            //nBuscado = objNegProf.abmProfesionales("Buscar", objEntProf); //invoco a la capa de negocio

            //if (nBuscado == -1)
            //    lblMensaje.Text = " Ya existe en el sistema";
            //else
            //{
            //    lblMensaje.Text = " No existe en el sistema";
            //    LlenarDataGrid();
            //    Limpiar();
            //}
        }
    }
}
