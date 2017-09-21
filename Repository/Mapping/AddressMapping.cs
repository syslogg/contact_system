using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Mapping
{
    public class AddressMapping : EntityTypeConfiguration<Address>
    {

        public AddressMapping()
        {
            #region Key

            HasKey(x => x.Id);

            #endregion

            #region Properties

            Property(x => x.City);
            Property(x => x.Complement);
            Property(x => x.Neighborhood);
            Property(x => x.Number);
            Property(x => x.State);
            Property(x => x.AddressName);
            Property(x => x.AddressType);

            #endregion

            #region References

            HasRequired(x => x.Person).WithMany(x => x.Address).HasForeignKey(x => x.PersonId).WillCascadeOnDelete(true);

            #endregion
        }

    }
}
