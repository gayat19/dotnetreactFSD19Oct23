using Microsoft.EntityFrameworkCore;
using ShoppingApp.Contexts;
using ShoppingApp.Interfaces;
using ShoppingApp.Models;

namespace ShoppingApp.Reposittories
{
    public class CartRepository : IRepository<int, Cart>
    {
        private readonly ShoppingContext _context;
        public CartRepository(ShoppingContext context)
        {
            _context = context;
        }
        public Cart Add(Cart entity)
        {
            _context.Carts.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public Cart Delete(int key)
        {
            var cart = GetById(key);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
                _context.SaveChanges();
                return cart;
            }
            return null;
        }

        public IList<Cart> GetAll()
        {
            return _context.Carts.ToList();
        }

        public Cart GetById(int key)
        {
            var cart = _context.Carts.SingleOrDefault(u => u.cartNumber == key);
            return cart;
        }

        public Cart Update(Cart entity)
        {
            var cart = GetById(entity.cartNumber);
            if (cart != null)
            {
                _context.Entry<Cart>(cart).State = EntityState.Modified;
                _context.SaveChanges();
                return cart;
            }
            return null;
        }
    }
}
