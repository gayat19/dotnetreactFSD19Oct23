using ShoppingDALLibrary;
using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public interface IProductService
    {
        /// <summary>
        /// Adds the product to the collection using the repository
        /// </summary>
        /// <param name="product">The product to be added</param>
        /// <returns></returns>
        /// <exception cref="NotAddedException">Product Id duplicated</exception>
        public Product AddProduct(Product product);
        public Product UpdateProductPrice(int id,float price);
        public Product GetProduct(int id);
        public List<Product> GetProducts();
        public Product UpdateProductQuantity(int id, int quantity,string action);
        /// <summary>
        /// Deletes teh product with teh given Id
        /// </summary>
        /// <param name="id">Product id for delete</param>
        /// <returns></returns>
        /// <exception cref="NoSuchProductException">The product your are deleting s not tehre</exception>
        public Product Delete(int id);
    }
}
