using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Events.Dal.Repository
{
    public interface IRepository<T>
    {
        //CRUD
        void Add(T entry);
        void AddRange(IEnumerable<T> entry);
        void Update(T entry);
        void Delete(T entry);
        //homework
        void Delete(Expression<Func<T, bool>> query);
        T Get(Expression<Func<T, bool>> query);

        T Get(int id);
        IQueryable<T> GetAll();
        

        void Commit();
    }
}
