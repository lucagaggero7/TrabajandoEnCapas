using System;
using System.Collections.Generic;
using System.Data;
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
        private string direccion;
        private string provincia;
        private string localidad;
        private int codpostal;
        private long telefono;
        private int dni;
        
        #endregion



        #region Constructor
        public Usuario()
        {
            nombre = string.Empty;
            direccion = string.Empty;
            provincia = string.Empty;
            localidad = string.Empty;
            codpostal = 0;
            telefono = 0;
            dni = 0;
        }
        #endregion



        #region propiedades/encapsulamiento

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public int CodPostal
        {
            get { return codpostal; }
            set { codpostal = value; }
        }

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        #endregion
    }
}
