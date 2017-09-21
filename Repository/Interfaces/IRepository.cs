using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Interfaces
{
    public interface IRepository<T>
    {
        T Get(int id);
        
        List<T> Find(Func<T, bool> predicate);
        
        IEnumerable<T> ListAll();
        
        bool Update(T entity);

        T Add(T entity);

        void Delete(T entity);

    }
}
