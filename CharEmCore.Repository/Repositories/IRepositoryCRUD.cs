
using CharEmCore.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository
{
    public interface IRepositoryCRUD
    {       
        bool Save();
        void Delete<T> (T input) where T: class;
        void Add<T>(T input) where T : class;
        void Update<T>(T input) where T : class;

        
        Service ServiceById(int id);

        IEnumerable<ServiceType> ServiceTypesAll();
        IEnumerable<Location> LocationsByServiceType(int serviceTypeId);
        IEnumerable<Service> ServicesByLocation(int locationId);
        
        //Get
        IEnumerable<Address> Addresses();
        IEnumerable<City> Cities();
        IEnumerable<County> Counties();
        IEnumerable<Contact> Contacts();
        IEnumerable<Location> Locations();
        IEnumerable<Organization> Organizations();
        IEnumerable<Service> ServicesAll();
        IEnumerable<ServiceType> ServiceTypes();

        //Get One
        Address Addresses(int id);
        City Cities(int id);
        County Counties(int id);
        Contact Contacts(int id);
        Location Locations(int id);
        Organization Organizations(int id);
        Service ServicesAll(int id);
        ServiceType ServiceTypes(int id);
    }
}
