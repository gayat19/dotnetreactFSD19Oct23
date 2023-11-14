using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApp.Models
{
    public class CartItems
    {
        public int CartNumber { get; set; }
        public int Product_Id { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Product_Id")]
        public Product Product { get; set; }
    }
}
