
using CharEmCore.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository
{
    public interface IRepositoryCRUD
    {       
        Task<bool> Save();
        void Delete<T> (T input) where T: class;
        void Add<T>(T input) where T : class;
        void Update<T>(T input) where T : class;

        IEnumerable<Service> ServicesAll();
        Service ServiceById(int id);

        IEnumerable<ServiceType> ServiceTypesAll();
        IEnumerable<Location> LocationsByServiceType(int serviceTypeId);
        IEnumerable<Service> ServicesByLocation(int locationId);
        IEnumerable<Organization> Organizations();
    }
}
