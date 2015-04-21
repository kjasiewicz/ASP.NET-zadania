using Events.Dal.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Dal.Repository
{
    public class RepositoryBase<T> : IRepository<T>, IDisposable
        where T:class 
    {
        private bool _disposed = false;
        private EventsDataContext _context;
        private System.Data.Entity.DbSet<T> _dbSet;
        public RepositoryBase()
        {
            _context = new EventsDataContext();
            _dbSet = _context.Set<T>();
        }
        public void Add(T entry)
        {
            _dbSet.Add(entry);
        }

        public void AddRange(IEnumerable<T> entries)
        {
            //_dbSet.AddRange(entries);
            _context.Configuration.AutoDetectChangesEnabled = false;
            foreach (var item in entries)
            {
                Add(item);
            }
        }

        public void Update(T entry)
        {
            _context.Entry(entry).State = EntityState.Modified;
            //_dbSet.Attach(entry);
        }

        public void Delete(T entry)
        {
            _dbSet.Attach(entry);
            _dbSet.Remove(entry);
        }

        public void Delete(System.Linq.Expressions.Expression<Func<T, bool>> query)
        {
            foreach (var item in _dbSet.Where(query))
            {
                Delete(item);
            }
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> single)
        {
            return _dbSet.SingleOrDefault(single);
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }
    }
}
