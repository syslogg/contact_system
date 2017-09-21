using Domain.Entities.Base;
using Domain.Entities.Enum;

namespace Domain.Entities
{
    public class Address : Entity
    {

        public string AddressName { get; set; }

        public AddressType AddressType { get; set; }

        public string Number { get; set; }

        public string Complement { get; set; }

        public string Neighborhood{ get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }

    }
}
