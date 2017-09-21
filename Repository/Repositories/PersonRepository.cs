using Domain.Entities;
using Repository.Base;
using Repository.Interfaces.Repositories;

namespace Repository.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(DbContactSystemContext dbContext)
            : base(dbContext)
        {
        }
    }
}
