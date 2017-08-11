
using CharEmCore.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class OrganizationCounty 
    {
        [Key]
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }

        [Key]
        public int CountyId { get; set; }
        public County County { get; set; }

    }
}
