using Domain.Entities;
using Repository.Interfaces.Repositories;

namespace Repository.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
    }
}
