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

        public async Task<bool> Save()
        {
            return (await _context.SaveChangesAsync()) > 0;
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

        public IEnumerable<Location> LocationsByServiceType(int serviceTypeId)
        {
            var servicesByType = _context.Services.Where(s => s.ServiceTypeId == serviceTypeId).Select(s => s.Id) ;
            var locations = _context.Locations.ToList();
            return locations;
                
        }

        public IEnumerable<Service> ServicesByLocation(int locationId)
        {
            throw new NotImplementedException();
        }
    }
}
