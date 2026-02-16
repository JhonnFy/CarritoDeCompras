using CarritoDeCompras.Entities;

namespace CarritoDeCompras.Entities
{
    public class CARRITO
    {
        public int IdCarrito { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }

        //Mapas De Navegación
        public CLIENTE Cliente { get; set; }
        public PRODUCTO PRODUCTO { get; set; }

    }
}
