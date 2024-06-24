using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;
using System.Security.Cryptography;

namespace Datos
{
    public class DatosUsuarios : DatosConexionBD
    {
       
        public int Compra(string accion, Usuario objUsuario, string listaProductos)
        {

            int realizada;

            string orden = string.Empty;

            if (accion == "Comprar")
                orden = "INSERT INTO Compras (Nombre, Direccion, Provincia, Localidad, CodigoPostal, Telefono, Dni, Carrito) " +
                         "VALUES (@Nombre, @Direccion, @Provincia, @Localidad, @CodPostal, @Telefono, @Dni, @Productos)";


            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Nombre", objUsuario.Nombre);
            cmd.Parameters.AddWithValue("@Direccion", objUsuario.Direccion);
            cmd.Parameters.AddWithValue("@Provincia", objUsuario.Provincia);
            cmd.Parameters.AddWithValue("@Localidad", objUsuario.Localidad);
            cmd.Parameters.AddWithValue("@CodPostal", objUsuario.CodPostal);
            cmd.Parameters.AddWithValue("@Telefono", objUsuario.Telefono);
            cmd.Parameters.AddWithValue("@Dni", objUsuario.Dni);
            cmd.Parameters.AddWithValue("@Productos", listaProductos);


            try
            {
                Abrirconexion();
                realizada = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de Productos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return realizada;
        }

    }
}
  

