using FirstWebApplication.Interfaces;
using FirstWebApplication.Models;
using FirstWebApplication.Repositories;

namespace FirstWebApplication.Services
{
    public class ProductService : IProductService
    {
        IRepository<int, Product> repository;
        public ProductService(IRepository<int, Product> repo)
        {
            repository = repo;
        }

        public Product AddProduct(Product product)
        {
            product.Picture = "~/Images/"+product.Picture;
            var result = repository.Add(product);
            if (result != null)
                return result;
            throw new Exception();
        }

        public Product Delete(int id)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                repository.Delete(id);
                return product;
            }
            throw new Exception();
        }
        /// <summary>
        /// Returns the product for teh given Id
        /// </summary>
        /// <param name="id">Id of the product to be returned</param>
        /// <returns></returns>
        /// <exception cref="NoSuchProductException">No product with the given Id</exception>
        public Product GetProduct(int id)
        {
            var result = repository.Get(id);
            //if (result != null) 
            //    return result;
            //throw new NoSuchProductException();

            //null collasing operator
            //return result ?? throw new NoSuchProductException();

            return result == null ? throw new Exception() : result;
        }

        public List<Product> GetProducts()
        {
            var products = repository.GetAll();
            if (products.Count != 0)
                return products.ToList();
            throw new Exception();
        }

        public Product UpdateProductPrice(int id, float price)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                product.Price = price;
                var result = repository.Update(product);
                return result;
            }
            throw new Exception();
        }

        public Product UpdateProductQuantity(int id, int quantity, string action)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                if (action == "add")
                {
                    product.Quantity += quantity;
                }
                else if (action == "remove")
                {
                    product.Quantity -= quantity;
                }
                else
                    throw new Exception();
                var result = repository.Update(product);
                return result;
            }
            throw new Exception();
        }
    }

}
