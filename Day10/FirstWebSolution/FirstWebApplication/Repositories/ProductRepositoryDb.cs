using FirstWebApplication.Contexts;
using FirstWebApplication.Interfaces;
using FirstWebApplication.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FirstWebApplication.Repositories
{
    public class ProductRepositoryDb : IRepository<int, Product>
    {
        private readonly ShoppingContext _context;

        public ProductRepositoryDb(ShoppingContext context) 
        { 
            _context = context;
        }
        public Product Add(Product item)
        {
            _context.Products.Add(item);//Add local collection
            _context.SaveChanges();//THis is make teh change in DB
            return item;
        }

        public Product Delete(int key)
        {
            var product =Get(key);
            _context.Products.Remove(product);//removes from local collection
            _context.SaveChanges();//Makes the delete in database
            return product;
        }

        public Product Get(int key)
        {
            var product = _context.Products.SingleOrDefault(p=>p.Id== key);
            return product;
        }

        public IList<Product> GetAll()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Product Update(Product item)
        {
            var product = Get(item.Id);
            if(product != null)
            {
                _context.Entry<Product>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return product;
            }
            return null;
        }
    }
}
