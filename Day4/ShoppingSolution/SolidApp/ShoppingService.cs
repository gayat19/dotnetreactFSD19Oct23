using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidApp
{
    public class ShoppingService : IProductService, ICartservice
    {
        public void AddProduct()
        {
            throw new NotImplementedException();
        }

        public void ModifyProductPrice()
        {
            throw new NotImplementedException();
        }

        public void RemoveProductFromCart()
        {
           //THis is very very bad 
        }
    }
}
