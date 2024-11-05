using Dispet.Models;
using MongoDB.Driver;

namespace Dispet.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _productsCollection;

        public ProductService(MongoDbService dbService)
        {
            _productsCollection = dbService.GetCollection<Product>("Products");
        }

        public async Task<List<Product>> GetProductsAsync() => await _productsCollection.Find(_ => true).ToListAsync();

        public async Task<Product> GetProductByIdAsync(string id) => await _productsCollection.Find(p => p.Id == id).FirstOrDefaultAsync();

        public async Task AddProductAsync(Product product) => await _productsCollection.InsertOneAsync(product);

        public async Task UpdateProductAsync(Product product) => await _productsCollection.ReplaceOneAsync(p => p.Id == product.Id, product);

        public async Task DeleteProductAsync(string id) => await _productsCollection.DeleteOneAsync(p => p.Id == id);
    }
}
