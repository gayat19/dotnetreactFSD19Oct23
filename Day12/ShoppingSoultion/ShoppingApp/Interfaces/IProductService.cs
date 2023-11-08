using ShoppingApp.Models;

namespace ShoppingApp.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product Add(Product product);
    }
}
