﻿using CharEmCore.Repository.Entities;
using CharEmCore.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class Location : DomainEntityBase
    {
        public Location()
        {            
            ServiceLocations = new HashSet<ServiceLocations>();
        }
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsSchool { get; set; }
        public int CountyId { get; set; }
        public County County { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        //public virtual ICollection<Organization> Organizations { get; set; }
        //public virtual ICollection<OrganizationLocations> OrganizationLocations { get; set; }
        //public virtual ICollection<Service> Services { get; set; }       
        public virtual ICollection<ServiceLocations> ServiceLocations { get; set; }
    }
}
