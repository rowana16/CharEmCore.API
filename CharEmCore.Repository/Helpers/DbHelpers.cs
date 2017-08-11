using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmCore.Repository.Helpers
{
    public static class DbHelpers
    {
        public static async Task AddOrUpdateAsync<T>(this DbSet<T> dbSet, IEnumerable<T> records)
        where T : DomainEntityBase
        {
            List<Task> saveTasks = new List<Task>();

            foreach (var data in records)
            {
                var exists = dbSet.AsNoTracking().Any(x => x.Id == data.Id);
                if (exists)
                {
                    saveTasks.Add(Task.Run(() => dbSet.Update(data)));
                    return;
                }
                saveTasks.Add(Task.Run(() => dbSet.Add(data)));
            }

            await Task.WhenAll(saveTasks);
            return;
        }

        public static void AddOrUpdate<T>(this DbSet<T> dbSet, IEnumerable<T> records)
        where T : DomainEntityBase
        {            
            foreach (var data in records)
            {
                //var exists = dbSet.AsNoTracking().Any(x => x.Id == data.Id);
                var exists = dbSet.Where(d => d.Id == data.Id).Count() > 0 ? true : false;
                if (exists)
                {
                    dbSet.Update(data);
                    return;
                }               
                dbSet.Add(data);
            }
            
            return;
        }
    }

    public class DomainEntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
