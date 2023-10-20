using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class ManageProduct
    {
        Product product;
        public ManageProduct()
        {
            product = new Product();
        }
        int GenerateId()
        {
            return new Random().Next(1, 100);
        }
        public void GetProductDetailsFromUser()
        {
            product.Id = GenerateId();
            TakeRemainingProductDetails();
        }
        public void GetProductDetailsFromUser(int id) 
        {
            product.Id = id;
            TakeRemainingProductDetails();
        }
        void TakeRemainingProductDetails()
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
        public void PrintProductDetails()
        {
            Console.WriteLine(product);
        }
        public bool UpdatePrice(float price)
        {
            if(price >=0)
            {
                product.Price = price;
                return true;
            }
            return false; 
        }
        public bool UpdateQuantity(int quantity)
        {
            if(product.Quantity > quantity)
            {
                product.Quantity -= quantity;
                return true;
            }
            return false;
        }
        public Product MyProduct
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
            }
        }

    }
}
