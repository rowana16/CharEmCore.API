
using CharEmCore.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class ServiceType : DomainEntityBase
    {
        public ServiceType()
        {
            this.Services = new HashSet<Service>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
