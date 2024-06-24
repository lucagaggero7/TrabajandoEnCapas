using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Datos
{
    public class DatosConexionBD
    {
        public OleDbConnection conexion;

        public string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Bases de Datos\TiendaOnlineBD.accdb;Persist Security Info=True";



        public DatosConexionBD()
        {
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }
}


