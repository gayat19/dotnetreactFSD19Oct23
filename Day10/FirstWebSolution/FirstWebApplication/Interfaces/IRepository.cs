namespace FirstWebApplication.Interfaces
{
    public interface IRepository<K,T>
        where T: class
    {
        public T Add(T item);
        public T Delete(K key);
        public T Get(K key);
        public IList<T> GetAll();
        public T Update(T item);
    }
}
