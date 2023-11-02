using ShoppingDALLibrary;
using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public class CustomerService : ICustomerService
    {
        IRepository<string, Customer> repository;
        public CustomerService()
        {
            repository = new CustomerRepository();
        }

        public bool Login(string username, string password)
        {
            var myCustomer = repository.GetById(username);
            if(myCustomer != null)
            {
                if(myCustomer.ComparePassword(password))
                    return true;
            }
          
            return false;
        }

        public  Customer Register(Customer customer)
        {
            var result = repository.Add(customer);
            if (result != null)
            {
                return result;
            }
            throw new UnableToRegisterCustomerException();
        }
    }
}
