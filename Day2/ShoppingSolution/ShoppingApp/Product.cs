using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public float Discount { get; set; }
        public Product()
        {
            Price = 0.0f;
            Discount = 0.5f;
            Quantity = 1;
            Rating = 0;
        }

        public Product(int id, string name, int quantity, float price, string picture, string description, double rating, float discount)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Picture = picture;
            Description = description;
            Rating = rating;
            Discount = discount;
        }
        public override string ToString()
        {
            float netPrice = Price - (Price * Discount / 100);
            return $"Product Id : {Id}\nProduct Name : {Name}\nProduct Price : Rs. {Price}\nProduct Quantity In Hand : {Quantity}" +
                $"\nDiscount offered : {Discount}%\nRating : {Rating}\nNet Price : {netPrice}";
        }
    }
}
