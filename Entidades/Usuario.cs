using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region atributos

        private string nombre;
        private string nombredeusuario;
        private string contraseña;
        private string direccion;

        #endregion
        #region Constructor
        public Usuario()
        {
            nombre = string.Empty;
            nombredeusuario = string.Empty;
            contraseña = string.Empty;
            direccion = string.Empty;
        }
        #endregion
        #region propiedades/encapsulamiento

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Nombredeusuario
        {
            get { return nombredeusuario; }
            set { nombredeusuario = value; }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        #endregion
    }
}
