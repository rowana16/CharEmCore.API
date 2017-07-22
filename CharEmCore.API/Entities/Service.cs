﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.API.Entities
{
    public class Service
    {
        public Service()
        {
            this.Locations = new HashSet<Location>();
            this.OtherContacts = new HashSet<Contact>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Details { get; set; }

        public int ServiceTypeId { get; set; }
        public int OrganizationId { get; set; }
        public int LeadContactId { get; set; }

        public virtual ServiceType ServiceType { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Contact LeadContact { get; set; }

        public virtual ICollection<Contact> OtherContacts { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
