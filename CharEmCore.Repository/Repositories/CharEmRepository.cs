using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CharEmCore.Repository.Entities;

namespace CharEmCore.Repository.Repositories
{
    public class CharEmRepository : IRepositoryCRUD
    {
        private CharEmContext _context;
        public CharEmRepository(CharEmContext context)
        {
            _context = context;
        }    

        public void Add<T>(T input) where T : class
        {
            _context.Add(input);
            var success = Save();            
        }

        public void Update<T>(T input) where T : class
        {
            _context.Entry(input).State = EntityState.Modified;
            var success = Save();
        }

        public void Delete<T>(T input) where T : class
        {
            _context.Remove(input);
            var success = Save();
        }

        public bool Save()
        {
            return (_context.SaveChanges()) > 0;
        }

        public IEnumerable<Service> ServicesAll()
        {
            return _context.Services.ToList();
        }

        public Service ServiceById(int id)
        {
            return _context.Services
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<ServiceType> ServiceTypesAll()
        {
            return _context.ServiceTypes.ToList();
        }

        public IEnumerable<Organization> Organizations()
        {
            var organizations = _context.Organizations.ToList();
            return organizations;
        }

        public IEnumerable<Location> LocationsByServiceType(int serviceTypeId)
        {
            var servicesByServiceType = _context.Services
                .Where(s => s.ServiceTypeId == serviceTypeId)                
                .Distinct();


            var organizationCountiesbyService = _context.OrganizationCounty                
                .Join(servicesByServiceType,
                        oc => oc.OrganizationId,
                        o => o.OrganizationId,
                        (OrganizationCounty, Service) => OrganizationCounty)
                .Distinct();

            var locations = _context.Locations
                .Join(organizationCountiesbyService,
                        l => l.CountyId,
                        oc => oc.CountyId,
                        (LocationResult, organizationCounties) => LocationResult)
                .Where(l=>l.IsSchool == true)
                .OrderBy(l=>l.Name)
                .Distinct();
                
                

            //var organizationIdsForSelectedServices = _context.Organizations
            //    .Where(o => )
            //    .Select(o=>o.Id);

            //var countyIdsForSelectedOrganizations = _context.OrganizationCounty
            //    .Where(oc => organizationIdsForSelectedServices.Contains(oc.OrganizationId))
            //    .Select(oc => oc.CountyId);

            //var locations = _context.Locations
            //    .Where(l => countyIdsForSelectedOrganizations.Contains(l.CountyId))
            //    .Where(l => l.IsSchool == true)
            //    .Distinct()
            //    .OrderBy(l => l.Name)
            //    .ToList();
            return locations.ToList();
                
        }

        public IEnumerable<Service> ServicesByLocation(int locationId)
        {
            throw new NotImplementedException();
        }

        //Get
        public IEnumerable<Address> Addresses()
        {            
            return _context.Addresses.ToList();
        }

        public IEnumerable<City> Cities()
        {
            return _context.Cities.ToList();
        }

        public IEnumerable<County> Counties()
        {
            return _context.Counties.ToList();
        }

        public IEnumerable<Contact> Contacts()
        {
            return _context.Contacts.ToList();
        }

        public IEnumerable<Location> Locations()
        {
            return _context.Locations.ToList();
        }

        public IEnumerable<ServiceType> ServiceTypes()
        {
            return _context.ServiceTypes.ToList();
        }


// Get One
        public Address Addresses(int id)
        {
            return _context.Addresses.Where(x => x.Id == id).FirstOrDefault();
        }

        public City Cities(int id)
        {
            return _context.Cities.Where(x => x.Id == id).FirstOrDefault();
        }

        public County Counties(int id)
        {
            return _context.Counties.Where(x => x.Id == id).FirstOrDefault();
        }

        public Contact Contacts(int id)
        {
            return _context.Contacts.Where(x => x.Id == id).FirstOrDefault();
        }

        public Location Locations(int id)
        {
            return _context.Locations.Where(x => x.Id == id).FirstOrDefault();
        }

        public Organization Organizations(int id)
        {
            return _context.Organizations.Where(x => x.Id == id).FirstOrDefault();
        }

        public Service ServicesAll(int id)
        {
            return _context.Services.Where(x => x.Id == id).FirstOrDefault();
        }

        public ServiceType ServiceTypes(int id)
        {
            return _context.ServiceTypes.Where(x => x.Id == id).FirstOrDefault();
        }


        


        //public County Counties(int id)
        //{
        //    return _context.Counties.Where(x => x.Id == id).FirstOrDefault();
        //}


    }
}
