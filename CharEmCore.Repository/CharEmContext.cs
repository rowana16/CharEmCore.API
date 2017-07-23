using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CharEmCore.API.Entities;
using CharEmCore.Repository.Entities;

namespace CharEmCore.Repository
{
    public class CharEmContext : DbContext
    {
        private IConfigurationRoot _config;

        public CharEmContext(IConfigurationRoot config, DbContextOptions options)
            : base(options)
        {
            _config = config;
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizationLocations>().HasKey(s => new { s.OrganizationId, s.LocationId});
            modelBuilder.Entity<ServiceLocations>().HasKey(s => new { s.ServiceId, s.LocationId});
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:CharEmConnection"]);
            base.OnConfiguring(optionsBuilder);
            
        }

    }
}
