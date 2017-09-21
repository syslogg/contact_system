using Domain.Entities;
using Repository.Mapping;
using System.Data.Entity;

namespace Repository
{
    public class DbContactSystemContext : DbContext
    {

        public DbContactSystemContext() 
            : base("DbContextConn")
        {

        }

        public virtual IDbSet<Person> Person { get; set; }

        public virtual IDbSet<Contact> Contact { get; set; }

        public virtual IDbSet<Address> Address { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Mapping
            modelBuilder.Configurations.Add(new ContactMapping());
            modelBuilder.Configurations.Add(new PersonMapping());
            modelBuilder.Configurations.Add(new AddressMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
