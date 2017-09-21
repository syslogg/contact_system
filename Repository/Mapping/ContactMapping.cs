using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Mapping
{
    public class ContactMapping : EntityTypeConfiguration<Contact>
    {

        public ContactMapping()
        {
            #region Key

            HasKey(x => x.Id);

            #endregion

            #region Properties

            Property(x => x.ContactType);
            Property(x => x.Value);

            #endregion

            #region References
            
            HasRequired(x => x.Person).WithMany(x => x.Contact).HasForeignKey(x => x.PersonId).WillCascadeOnDelete(true);

            #endregion
        }

    }
}
