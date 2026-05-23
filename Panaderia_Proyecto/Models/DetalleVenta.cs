namespace Panaderia_Proyecto.Models
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int VentaId { get; set; }
        public Venta? Venta { get; set; }
        public int ProductoApiId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}