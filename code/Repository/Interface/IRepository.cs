namespace code.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Insert(T obj);
        T Update(T obj);
        void Delete(T obj);
    }
}
