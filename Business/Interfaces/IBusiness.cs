using Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IBusiness<T> : IDisposable
        where T : Entity
    {
        T Insert(T entity);

        T GetById(int id);

        bool Update(T entity);

        IList<T> ListAll();
    }
}
