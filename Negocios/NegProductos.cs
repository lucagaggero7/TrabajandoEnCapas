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

        DatosUsuarios objDatosUsuarios = new DatosUsuarios();

        public int abmProdcutos(string accion, Producto objProducto)
        {
            return objDatosProductos.abmProductos(accion, objProducto);
        }
        public DataTable listadoProductos(string cual)
        {
            return objDatosProductos.listadoProductos(cual);
        }


        public object BuscarProducto(Producto objProducto)
        {
            return objDatosProductos.BuscarProducto(objProducto);
        }

        public DataTable BuscarFiltros()
        {
            return objDatosProductos.BuscarFiltros();
        }

        public int Compra(string accion, Usuario objUsuario, string listaProuductos)
        {
            return objDatosUsuarios.Compra(accion, objUsuario, listaProuductos);
        }


    }




}
