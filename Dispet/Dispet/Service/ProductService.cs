using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dispet.Models;

public class ProductService
{
    private readonly List<Product> products = new()
    {
        new Product { Id = 1, Name = "Producto 1", Description = "Descripción del producto 1", Price = 20.00m },
        new Product { Id = 2, Name = "Producto 2", Description = "Descripción del producto 2", Price = 35.00m },
        new Product { Id = 3, Name = "Producto 3", Description = "Descripción del producto 3", Price = 50.00m }
    };

    public Task<Product> GetProductById(int id)
    {
        // Busca el producto por su Id y devuelve la lista con sus reseñas
        var product = products.FirstOrDefault(p => p.Id == id);
        return Task.FromResult(product);
    }
}
