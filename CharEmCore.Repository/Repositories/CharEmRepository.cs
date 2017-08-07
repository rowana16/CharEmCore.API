using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using CharEmCore.API.Entities;

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

        public IEnumerable<Service> GetAllServices()
        {
            return _context.Services.ToList();
        }

        public Service GetService(int id)
        {
            return _context.Services
                .Where(s => s.Id == id)
                .FirstOrDefault();
        }
    }
}
