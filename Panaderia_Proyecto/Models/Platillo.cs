namespace Panaderia_Proyecto.Models
{

    public class Platillo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int TiempoPreparacion { get; set; } // en minutos
        public int Calorias { get; set; }
        public bool Disponible { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public int CategoriaId { get; set; }
    }
}