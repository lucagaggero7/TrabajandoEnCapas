using System.Data;

public class Carrito
{
    public DataTable Productos { get; set; }

    public Carrito()
    {
        Productos = new DataTable();
        // Define las columnas de tu DataTable aquí, deben coincidir con las del DataGridView
    }

    public void AgregarProducto(DataRow row)
    {
        Productos.Rows.Add(row.ItemArray);
    }

    public void ClonarEstructura(DataTable tablaExistente)
    {
        Productos = tablaExistente.Clone();
    }
}