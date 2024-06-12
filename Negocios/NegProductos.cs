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


        public int abmProdcutos(string accion, Producto objProfesional)
        {
            return objDatosProductos.abmProductos(accion, objProfesional);
        }
        public DataTable listadoProductos(string cual)
        {
            return objDatosProductos.listadoProductos(cual);
        }

        public object BuscarProducto(Producto objProfesional)
        {
            return objDatosProductos.BuscarProducto(objProfesional);
        }

        public DataTable BuscarFiltros(string columna)
        {
            return objDatosProductos.BuscarFiltros(columna);
        }

    }




}
