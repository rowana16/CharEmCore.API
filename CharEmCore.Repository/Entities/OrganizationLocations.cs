using CharEmCore.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class OrganizationLocations
    {
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }

    }
}
