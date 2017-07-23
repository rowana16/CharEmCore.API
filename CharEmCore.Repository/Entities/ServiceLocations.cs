using CharEmCore.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class ServiceLocations
    {
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
