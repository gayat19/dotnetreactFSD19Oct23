using Microsoft.EntityFrameworkCore;
using ShoppingApp.Contexts;
using ShoppingApp.Interfaces;
using ShoppingApp.Models;

namespace ShoppingApp.Reposittories
{
    public class CartItemsRepository : IRepository<int, CartItems>
    {
        private readonly ShoppingContext _context;
        public CartItemsRepository(ShoppingContext context)
        {
            _context = context;
        }

        public CartItems Add(CartItems entity)
        {
            _context.CartItems.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public CartItems Delete(int key)
        {
            var item = _context.CartItems.FirstOrDefault(ci=>ci.Product_Id == key);
            if (item != null)
            {
                _context.CartItems.Remove(item);
                _context.SaveChanges();
               return item;
            }
            return null;
        }

        public IList<CartItems> GetAll()
        {
             return _context.CartItems.ToList();
        }

        public CartItems GetById(int key)
        {
            var item  = _context.CartItems.FirstOrDefault(ci=>ci.Product_Id == key);
            return item;
        }

        public CartItems Update(CartItems entity)
        {
            var cart = GetById(entity.Product_Id);
            if (cart != null)
            {
                _context.Entry<CartItems>(cart).State = EntityState.Modified;
                _context.SaveChanges();
                return cart;
            }
            return null;
        }
    }
}
