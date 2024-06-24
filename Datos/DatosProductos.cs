using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;
using System.Security.Cryptography;
using System.Web.Script.Serialization; // Necesario para la serialización JSON

namespace Datos
{
    public class DatosProductos : DatosConexionBD
    {
        public int abmProductos(string accion, Producto objProfesional)
        {
            int resultado;
            string orden = string.Empty;

            if (accion == "Agregar")
                //orden = "insert into Productos values (" + objProfesional.CodigoProd + ",'" + objProfesional.Nombre + "');";
                orden = "insert into Productos (Codigo, Nombre, Marca, Categoria, Precio, Stock) " +
                    "values (" + objProfesional.CodigoProd + ",'" + objProfesional.Nombre + "','" +
                                 objProfesional.Marca + "','" + objProfesional.Categoria + "','" +
                                 objProfesional.Precio + "','" + objProfesional.Stock + "');";

            if (accion == "Borrar")
                orden = "DELETE FROM Productos WHERE Codigo = " + objProfesional.CodigoProd + ";";

            // falta la orden de borrar
            OleDbCommand cmd = new OleDbCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
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
            return resultado;
        }

        ////con esta query solamente podemos saber si existe o no el registro
        //    if (accion == "Buscar")
        //        orden = "Select * FROM Productos WHERE Codigo = " + objProfesional.CodigoProd + ";";

        public object BuscarProducto(Producto objProfesional)
        {
            object CodObtenido;
            int CodInt;


            string orden = "SELECT Codigo FROM Productos WHERE Codigo = @Codigo";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Codigo", objProfesional.CodigoProd);


            try
            {
                Abrirconexion();

                CodObtenido = cmd.ExecuteScalar();

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
            CodInt = Convert.ToInt32(CodObtenido);
            return CodInt;
        }


        public DataTable listadoProductos(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Productos where CodigoProd = " + int.Parse(cual) + ";";
            else
                orden = "select * from Productos;";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar productos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return dt;
        }


        public DataTable BuscarFiltros()
        {
            DataTable dataTableFiltro = new DataTable();
            string orden = string.Empty;

            orden = "SELECT p.Categoria, p.Marca, p.Precio\r\nFROM Productos AS p\r\nINNER JOIN (\r\n    SELECT DISTINCT Categoria, Marca, Precio\r\n    FROM Productos\r\n) AS subconsulta\r\nON p.Categoria = subconsulta.Categoria\r\n    AND p.Marca = subconsulta.Marca\r\n    AND p.Precio = subconsulta.Precio;";


            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dataTableFiltro);
                foreach (DataRow row in dataTableFiltro.Rows)
                {
                    string renglon = row.ToString();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar filtros", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return dataTableFiltro;
            
        }

    }
}
  

