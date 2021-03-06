using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Infrastructure
{
 public interface IRepository<T> where  T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);

       public Task<bool> Add(T entity);

        Task Update(T entity);
        Task Delete(T entity);

    }
}
