﻿using CharEmCore.Repository.Entities;
using CharEmCore.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class Organization : DomainEntityBase
    {
        public Organization()
        {
            OrganizationCounty = new HashSet<OrganizationCounty>();
            Services = new HashSet<Service>();

        }
        //public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(5000)]
        public string Details { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(500)]
        public string Email { get; set; }

        public int? AddressId { get; set; }
        public virtual Address Address { get; set; }

        //public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<OrganizationCounty> OrganizationCounty { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
