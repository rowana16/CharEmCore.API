using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Entities
{
    public class Contact
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string DisplayName { get; set; }

        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }

        public int? AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
