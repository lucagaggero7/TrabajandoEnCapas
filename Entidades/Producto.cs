using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region atributos
        private int codigoProd;

        private string nombre;
        private string marca;
        private string categoria;
        
        private int precio;
        private int stock;

        #endregion


        #region Constructor
        public Producto()
        {
            nombre = string.Empty;
            marca = string.Empty;
            categoria = string.Empty;
   
            codigoProd = 0;
            precio = 0;
            stock = 0;
        }
        #endregion


        #region propiedades/encapsulamiento

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int CodigoProd
        {
            get { return codigoProd; }
            set { codigoProd = value; }
        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        #endregion
    }
}
