namespace CarritoDeCompras.Entities
{
    public class DETALLE_VENTA
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int Total { get; set; }

        //Mapa De Navegación
        public VENTA VENTA { get; set; }
        public PRODUCTO PRODUCTO { get; set; }

    }
}
