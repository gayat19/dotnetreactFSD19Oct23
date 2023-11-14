using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models.DTOs
{
    public class CartDTO
    {
        [Required(ErrorMessage ="Username is empty")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Product Id is empty")]
        public int ProductId { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
