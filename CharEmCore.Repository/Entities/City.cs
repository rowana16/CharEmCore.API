using CharEmCore.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class City : DomainEntityBase
    {
        public City()
        {
            this.Locations = new HashSet<Location>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }

        public int? CountyId { get; set; }
        public virtual County County { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
