namespace ShoppingApp.Exceptions
{
    public class NoProductsAvailableException : Exception
    {
        string message;
        public NoProductsAvailableException()
        {
            message = "No products are available for sale";
        }
        public override string Message => message;
    }
}
