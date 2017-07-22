using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.API.Entities
{
    public class Location
    {
        public class Location
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool? IsSchool { get; set; }
            public int CountyId { get; set; }
            public County County { get; set; }
            public int CityId { get; set; }
            public City City { get; set; }

            public virtual ICollection<Organization> Organizations { get; set; }
            public virtual ICollection<Service> Services { get; set; }
        }
    }
}
