using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegProductos
    {
        DatosProductos objDatosProductos = new DatosProductos();

        public int AbmProdcutos(string accion, Producto objProducto)
        {
            return objDatosProductos.AbmProductos(accion, objProducto);
        }
        public DataTable ListadoProductos(string cual)
        {
            return objDatosProductos.ListadoProductos(cual);
        }

        public object BuscarProducto(Producto objProducto)
        {
            return objDatosProductos.BuscarProducto(objProducto);
        }

        public DataTable BuscarFiltros()
        {
            return objDatosProductos.BuscarFiltros();
        }
    }
}
