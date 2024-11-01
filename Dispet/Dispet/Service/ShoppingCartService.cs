using Dispet.Models;
using System.Collections.Generic;
using System.Linq;

public class ShoppingCartService
{
    private List<Product> cartItems = new();

    public void AddToCart(Product product)
    {
        cartItems.Add(product);
    }

    public List<Product> GetCartItems()
    {
        return cartItems;
    }

    public decimal GetTotal()
    {
        return cartItems.Sum(p => p.Price);
    }

    public void ClearCart()
    {
        cartItems.Clear();
    }
}
