using DTOModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Infrastructure
{
   public class Repository<T> : IRepository<T>  where T :class 
        
    {

        public DBContextt _contextt;
        public Repository( DBContextt contextt)
        {
            _contextt  = contextt;
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _contextt.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _contextt.Set<T>().FindAsync(id);
        }

        public async Task<bool> Add(T entity)
        {
            await _contextt.AddAsync(entity);
            await _contextt.SaveChangesAsync();
            return true;
        }
        public async Task Update(T entity)
        {
            _contextt.Entry(entity).State = EntityState.Modified;
            _contextt.Set<T>().Update(entity);
            await _contextt.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _contextt.Set<T>().Remove(entity);
            await _contextt.SaveChangesAsync();
        }
    }
}
