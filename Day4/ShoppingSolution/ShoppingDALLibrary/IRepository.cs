using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingModelLibrary;

namespace ShoppingDALLibrary
{
    public interface IRepository<K,T>  where T : class
    {
        public T Add(T item);
        public T Update(T item);
        public T Delete(K id);
        public T GetById(K id);
        public List<T> GetAll();
    }
}
