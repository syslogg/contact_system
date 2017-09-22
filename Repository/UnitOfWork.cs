using System;
using Repository.Interfaces;
using Repository.Interfaces.Repositories;
using System.Threading.Tasks;
using Repository.Repositories;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private IPersonRepository _personRepository = null;

        public IPersonRepository PersonRepository
        {
            get
            {
                if (this._personRepository == null)
                {
                    this._personRepository = new PersonRepository(this._dbContext);
                }
                return _personRepository;
            }
        }

        private IContactRepository _contactRepository = null;

        public IContactRepository ContactRepository
        {
            get
            {
                if (this._contactRepository == null)
                {
                    this._contactRepository = new ContactRepository(this._dbContext);
                }
                return _contactRepository;
            }
        }

        private IAddressRepository _addressRepository = null;

        public IAddressRepository AddressRepository
        {
            get
            {
                if (this._addressRepository == null)
                {
                    this._addressRepository = new AddressRepository(this._dbContext);
                }
                return _addressRepository;
            }
        }
        
        private DbContactSystemContext _dbContext;

        public UnitOfWork()
        {
            CreateDbContext();
        }

        public UnitOfWork(DbContactSystemContext dbContext)
        {
            this._dbContext = dbContext;
        }
        private void CreateDbContext()
        {
            this._dbContext = new DbContactSystemContext();
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
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool p)
        {
            throw new NotImplementedException();
        }

    }
}
