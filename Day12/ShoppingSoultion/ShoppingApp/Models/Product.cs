namespace ShoppingApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int  Quantity { get; set; }
        public string Picture { get; set; }
        public ICollection<CartItems> CartItems { get; set; }
    }
}
