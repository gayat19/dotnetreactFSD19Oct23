using Microsoft.EntityFrameworkCore;
using ShoppingApp.Contexts;
using ShoppingApp.Interfaces;
using ShoppingApp.Models;

namespace ShoppingApp.Reposittories
{
    public class ProductRepository : IRepository<int, Product>
    {
        private readonly ShoppingContext _context;
        public ProductRepository(ShoppingContext context)
        {
            _context = context;
        }
        public Product Add(Product entity)
        {
            _context.Products.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Product Delete(int key)
        {
            var product = GetById(key);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return product;
            }
            return null;
        }

        public IList<Product> GetAll()
        {
            if (_context.Products.Count() == 0)
                return null;
            return _context.Products.ToList();
        }

        public Product GetById(int key)
        {
            var product = _context.Products.SingleOrDefault(u => u.Id == key);
            return product;
        }

        public Product Update(Product entity)
        {
            var product = GetById(entity.Id);
            if (product != null)
            {
                _context.Entry<Product>(product).State = EntityState.Modified;
                _context.SaveChanges();
                return product;
            }
            return null;
        }
    }
}
