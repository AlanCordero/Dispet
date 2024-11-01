using System.Collections.Generic;

namespace Dispet.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Lista de reseñas para cada producto
        public List<Review> Reviews { get; set; } = new();
    }

    public class Review
    {
        public int Rating { get; set; }  // Calificación entre 1 y 5
        public string Comment { get; set; }
        public string User { get; set; } // Nombre del usuario o ID
    }
}
