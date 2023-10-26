using System.Runtime.Serialization;

namespace ShoppingBLLibrary
{
    [Serializable]
    public class NoProductsAvailableException : Exception
    {
        string message;
        public NoProductsAvailableException()
        {
            message = "No products are available currently";
        }

        public override string Message => message;
    }
}