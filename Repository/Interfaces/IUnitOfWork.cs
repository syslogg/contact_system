using Repository.Interfaces.Repositories;
using System;

namespace Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository PersonRepository { get; }
        IAddressRepository AddressRepository { get; }
        IContactRepository ContactRepository { get; }

        void Commit();
        Task CommitAsync();
    }
}
