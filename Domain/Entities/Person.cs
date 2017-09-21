using Domain.Entities.Base;
using Domain.Entities.Enum;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Person : Entity
    {
        public string Name { get; set; }

        public IList<Contact> Contact { get; private set; }

        public IList<Address> Address { get; private set; }

        public PersonMarker PersonMarker { get; set; }

        public Person()
        {
            this.Contact = new List<Contact>();
            this.Address = new List<Address>();
        }

        public void AddContact(Contact item)
        {
            this.Contact.Add(item);
        }

        public void AddAddress(Address item)
        {
            this.Address.Add(item);
        }

    }
}
