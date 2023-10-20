using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class ShoppingHome
    {
        
        ProductRepository productRepository;
        public ShoppingHome()
        {
            productRepository = new ProductRepository();
        }
        void DisplayAdminMenu()
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Product Price");
            Console.WriteLine("3. Delete Product");
            Console.WriteLine("4. Print All Products");
            Console.WriteLine("0. Exit");
        }
        void StartAdminActivities()
        {
            int choice;
            do
            {
                DisplayAdminMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye bye");
                        break;
                    case 1:
                        productRepository.Add();
                        break;
                    case 2:
                        UpdatePrice();
                        break;
                    case 3:
                        DeleteProduct();
                        break;
                    case 4:
                        PrintAllProducts();
                        break;
                    default: 
                        Console.WriteLine("Invalid choice. Try again");
                        break;
                }
            } while (choice !=0 );
        }

        private void PrintAllProducts()
        {
            Console.WriteLine("***********************************");
            var products = productRepository.GetProducts();
            foreach (var item in products)
            {
                Console.WriteLine(item);
                Console.WriteLine("-------------------------------");
            }
            Console.WriteLine("***********************************");
        }

        int GetProductIdFromUser()
        {
            int id;
            Console.WriteLine("Please enter the product id");
            id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        private void DeleteProduct()
        {
            int id = GetProductIdFromUser();
            if(productRepository.Delete(id) != null)
                Console.WriteLine("Product deleted");
        }

        private void UpdatePrice()
        {
            var id = GetProductIdFromUser();
            Console.WriteLine("Please enter the new price");
            float price = Convert.ToSingle(Console.ReadLine());
            Product product = new Product();
            product.Price = price;
            product.Id = id;
            var result = productRepository.Update(id, product,"price");
            if(result != null)
                Console.WriteLine("Update success");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Shopping App");
            ShoppingHome home = new ShoppingHome();
            home.StartAdminActivities();
        }
    }
}
