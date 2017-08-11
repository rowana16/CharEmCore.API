using CharEmCore.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class County : DomainEntityBase
    {
        public County()
        {
            this.Cities = new HashSet<City>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<OrganizationCounty> OrganizationLocations { get; set; }
    }
}
