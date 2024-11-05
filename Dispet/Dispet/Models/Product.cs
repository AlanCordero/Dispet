using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Dispet.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Nueva propiedad para las reseñas
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
