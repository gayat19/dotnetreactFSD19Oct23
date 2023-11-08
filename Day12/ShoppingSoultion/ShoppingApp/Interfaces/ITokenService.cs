using ShoppingApp.Models.DTOs;

namespace ShoppingApp.Interfaces
{
    public interface ITokenService
    {
        string GetToken(UserDTO user);
    }
}
