using Dispet.Models;
using Dispet.Services;

namespace Dispet.ViewModels
{
    public class ProductViewModel
    {
        private readonly ProductService _productService;
        public List<Product> Products { get; private set; } = new();

        public ProductViewModel(ProductService productService)
        {
            _productService = productService;
        }

        public async Task LoadProductsAsync()
        {
            Products = await _productService.GetProductsAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            await _productService.AddProductAsync(product);
            await LoadProductsAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productService.UpdateProductAsync(product);
            await LoadProductsAsync();
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productService.DeleteProductAsync(id);
            await LoadProductsAsync();
        }
    }
}
