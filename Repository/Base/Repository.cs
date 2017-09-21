using System;
using System.Collections.Generic;
using Repository.Interfaces;
using System.Data.Entity;
using Repository.Exceptions;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace Repository.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContactSystemContext _dbContext;
        private IDbSet<T> _dbSet;
        
        public Repository(DbContactSystemContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = _dbContext.Set<T>();
        }

        public T Add(T entity)
        {
            try
            {
                return this._dbSet.Add(entity);
            } catch (Exception re)
            {
                throw new RepositoryException(re.Message, re);
            }
        }

        public void Delete(T entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _dbSet.Remove(entity);
            }
            catch (Exception e)
            {
                throw new RepositoryException(e.Message);
            }
        }

        public List<T> Find(Func<T, bool> predicate)
        {
            try
            {
                return _dbSet.Where(predicate).ToList();
            }
            catch (Exception e)
            {
                throw new RepositoryException(e.Message, e);
            }
        }

        public T Get(int id)
        {
            try
            {
                return _dbSet.Find(id);
            }
            catch (Exception e)
            {
                throw new RepositoryException(e.Message, e);
            }
        }

        public IEnumerable<T> ListAll()
        {
            try
            {
                return _dbSet;
            }
            catch (Exception e)
            {
                throw new RepositoryException(e.Message,e);
            }
        }

        public bool Update(T entity)
        {
            try
            {
                DbEntityEntry dbEntityEntry = _dbContext.Entry(entity);

                if (dbEntityEntry.State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }

                dbEntityEntry.State = EntityState.Modified;
                return true;
            }
            catch (Exception e)
            {
                throw new RepositoryException(e.Message);
            }
        }
    }
}
