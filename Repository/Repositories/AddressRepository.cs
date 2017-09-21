using Domain.Entities;
using Repository.Base;
using Repository.Interfaces.Repositories;

namespace Repository.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(DbContactSystemContext dbContext)
            : base(dbContext)
        {
        }
    }
}
