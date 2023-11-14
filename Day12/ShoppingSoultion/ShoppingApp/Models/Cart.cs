using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingApp.Models
{
    public class Cart
    {
        public int cartNumber { get; set; }
        public string Username { get; set; }

        [ForeignKey("Username")]
        public User User { get; set; }
    }
}
