using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Models
{
    public class Product
    {
        public int Id { get; set; }//identity - GUID
        [Required(ErrorMessage ="Name of the product cannot be empty")]
        public string Name { get; set; }
        [Range(1,1000,ErrorMessage ="Price of thr product should be within 1 to 1000")]
        public float Price { get; set; }
        [Range(1,100,ErrorMessage ="Quantity has to be minimum 1 and maximum 100")]
        public int  Quantity { get; set; }
        public string? Picture { get; set; }
        public ICollection<CartItems>? CartItems { get; set; }
    }
}
