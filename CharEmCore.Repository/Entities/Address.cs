using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class Address
    {
        public Address()
        {
            this.Contacts = new HashSet<Contact>();
            this.Organizations = new HashSet<Organization>();
        }

        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }

        public virtual County County { get; set; }
        public virtual City City { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
    }
}
