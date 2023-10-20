using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class ProductRepository
    {
        List<Product> products;
     
        public ProductRepository()
        {
            products = new List<Product>();
        }
        int GetNextId()
        {
            if (products.Count == 0)
                return 1;
            int id = products[products.Count - 1].Id;
            return ++id;
        }
        void TakeRemainingProductDetails(Product product)
        {
            Console.WriteLine("Please enter the product name");
            product.Name = Console.ReadLine();
            Console.WriteLine("Please enter the product price");
            product.Price = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter the product quantity");
            product.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the product description");
            product.Description = Console.ReadLine();
            Console.WriteLine("Please enter the product discount that you can offer");
            product.Discount = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter the product picture path");
            product.Picture = Console.ReadLine();
        }
        public Product Add()
        {
            int id = GetNextId();
            Product product = new Product();
            product.Id = id;
            //Getting the product details from theuser
            TakeRemainingProductDetails(product);
            //Adding to the collection
            products.Add(product);
            return product;
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public Product GetProductById(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id==id)
                    return products[i]; 
            }
            return null;
        }
        public Product Update(int id,Product product,string choice) 
        {
            Product myProduct = GetProductById(id);
            if(myProduct != null)
            {
               
                if (choice == "price")
                {
                    if(product.Price>0)
                    {
                        myProduct.Price = product.Price;
                        return myProduct;
                    }
                }
                else if (choice == "quanity")
                {
                    if (product.Quantity > 0)
                    {
                        myProduct.Quantity -= product.Quantity;
                        return myProduct;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
            Console.WriteLine("Could not update");
            return null;
        }
        public Product Delete(int id)
        {
            Product myProduct = GetProductById(id);
            if (myProduct != null)
            {
                products.Remove(myProduct);
                Console.WriteLine("Product deleted");
                return myProduct;
            }
            return null;

        }
    }
}
