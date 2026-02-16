namespace CarritoDeCompras.Entities
{
    public class CATEGORIA
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
