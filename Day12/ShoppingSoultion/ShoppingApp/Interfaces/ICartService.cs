using ShoppingApp.Models.DTOs;

namespace ShoppingApp.Interfaces
{
    public interface ICartService
    {
        /// <summary>
        /// Adds item to the cart. Careates a cart object when the user is adding item for teh first time.
        /// else adds item to the cart
        /// </summary>
        /// <param name="cartDTO">Contains username, product id and quantity</param>
        /// <returns>true if the add action is successfull else false</returns>
        bool AddToCart(CartDTO cartDTO);
        bool RemoveFromCart(CartDTO cartDTO);
    }
}
