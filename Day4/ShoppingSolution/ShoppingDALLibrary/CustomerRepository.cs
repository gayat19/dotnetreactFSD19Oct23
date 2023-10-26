using ShoppingModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDALLibrary
{
    public class CustomerRepository : IRepository<string, Customer>
    {
        Dictionary<string, Customer> _customers = new Dictionary<string, Customer>();
        public Customer Add(Customer item)
        {
            _customers.Add(item.Email,item);
            return item;
        }

        public Customer Delete(string id)
        {
            var customer = GetById(id);
            if (customer != null)
            {
                _customers.Remove(customer.Email);
                return customer;
            }
            return null;
        }

        public List<Customer> GetAll()
        {
            if (_customers.Count == 0)
                return null;
            return _customers.Values.ToList();
        }

        public Customer GetById(string id)
        {
          if(_customers.ContainsKey(id))
            {
                return _customers[id];
            }
            return null;
        }

        public Customer Update(Customer item)
        {
            var customer = GetById(item.Email);
            if (customer != null)
            {
                _customers[item.Email] = item;
                return item;
            }
            return null;
        }
    }
}
