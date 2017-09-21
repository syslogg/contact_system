using Domain.Entities.Base;
using Domain.Entities.Enum;

namespace Domain.Entities
{
    public class Contact : Entity
    {
        public string Value { get; set; }

        public ContactType ContactType { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}
