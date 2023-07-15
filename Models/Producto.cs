namespace API_REST_SP.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}