using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Mapping
{
    public class PersonMapping : EntityTypeConfiguration<Person>
    {

        public PersonMapping()
        {
            #region Key

            HasKey(x => x.Id);

            #endregion

            #region Properties

            Property(x => x.Name);
            Property(x => x.PersonMarker);

            #endregion

            #region References
            
            HasMany(x => x.Address).WithRequired(x => x.Person).HasForeignKey(x => x.PersonId).WillCascadeOnDelete(true);
            HasMany(x => x.Contact).WithRequired(x => x.Person).HasForeignKey(x => x.PersonId).WillCascadeOnDelete(true);

            #endregion
        }

    }
}
