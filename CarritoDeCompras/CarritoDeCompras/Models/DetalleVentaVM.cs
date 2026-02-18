namespace CarritoDeCompras.Models
{
    public class DetalleVentaVM
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }

    }
}
