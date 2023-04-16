using code.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace code.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ServiceAgencyContext _context;
        private readonly DbSet<T> table;

        public Repository(ServiceAgencyContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T Insert(T obj)
        {
            table.Add(obj);
            Save();
            return obj;
        }

        public T Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            Save();
            return obj;
        }

        public void Delete(T obj)
        {
            table.Remove(obj);
            Save();
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
