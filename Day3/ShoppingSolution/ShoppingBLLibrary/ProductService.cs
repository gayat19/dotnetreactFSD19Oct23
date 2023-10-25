using ShoppingDALLibrary;
using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public class ProductService : IProductService
    {
        IRepository<int,Product> repository;
        public ProductService()
        {
            repository =  new ProductRepository();
        }
       
        public Product AddProduct(Product product)
        {
            var result = repository.Add(product);
            if(result != null) 
                return result;
            throw new NotAddedException();
        }
       
        public Product Delete(int id)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                repository.Delete(id);
                return product; 
            }
            throw new NoSuchProductException();
        }
        /// <summary>
        /// Returns the product for teh given Id
        /// </summary>
        /// <param name="id">Id of the product to be returned</param>
        /// <returns></returns>
        /// <exception cref="NoSuchProductException">No product with the given Id</exception>
        public Product GetProduct(int id)
        {
            var result = repository.GetById(id);
            //if (result != null) 
            //    return result;
            //throw new NoSuchProductException();

            //null collasing operator
            //return result ?? throw new NoSuchProductException();

            return result == null ? throw new NoSuchProductException() : result;
        }

        public List<Product> GetProducts()
        {
            var products = repository.GetAll();
            if(products.Count != 0)
               return products;
            throw new NoProductsAvailableException();
        }

        public Product UpdateProductPrice(int id, float price)
        {
            var product = GetProduct(id);
            if(product != null)
            {
                product.Price = price;
                var result = repository.Update(product);
                return result;
            }
            throw new NoSuchProductException();
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
                    throw new InValidUpdateActionException();
                var result = repository.Update(product);
                return result;
            }
            throw new NoSuchProductException();
        }
    }
}
