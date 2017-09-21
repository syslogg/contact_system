using System;
using Repository.Interfaces;
using Repository.Interfaces.Repositories;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPersonRepository PersonRepository { get; private set; }

        public IAddressRepository AddressRepository { get; private set; }

        public IContactRepository ContactRepository { get; private set; }

        private DbContactSystemContext _dbContext;

        public UnitOfWork()
        {
            CreateDbContext();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        private void CreateDbContext()
        {
            _dbContext = new DbContactSystemContext();
        }

    }
}
