using CharEmCore.API.Entities;
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

        IEnumerable<Service> GetAllServices();
        Service GetService(int id);
    }
}
