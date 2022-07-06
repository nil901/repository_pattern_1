using DTOModel;
using Microsoft.EntityFrameworkCore;
using Model;
using repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {

    }


    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        //public CatrgoryRepository(Contex contex) : base(contex)
        //{

        //} 

       public AccountRepository(DBContextt _DBContextt) : base(_DBContextt)
        {

        } 


    } 
}
