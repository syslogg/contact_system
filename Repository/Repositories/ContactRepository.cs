﻿using Domain.Entities;
using Repository.Base;
using Repository.Interfaces.Repositories;

namespace Repository.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(DbContactSystemContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
