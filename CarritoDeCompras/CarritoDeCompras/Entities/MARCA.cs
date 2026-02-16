namespace CarritoDeCompras.Entities
{
    public class MARCA
    {
        public int IdMarca { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; } = true;

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
