﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.API.Entities
{
    public class County
    {
        public County()
        {
            this.Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}