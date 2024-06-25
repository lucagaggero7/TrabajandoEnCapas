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
    public class NegUsuarios
    {
        DatosUsuarios objDatosUsuarios = new DatosUsuarios();
        public int Compra(string accion, Usuario objUsuario, string listaProuductos)
        {
            return objDatosUsuarios.Compra(accion, objUsuario, listaProuductos);
        }
    }
}
