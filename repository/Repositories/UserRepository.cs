using DTOModel;
using Model;
using repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Repositories
{

    public interface IUserRepository : IRepository<User> 
    {

    }
   
      public  class UserRepository : Repository<User>  , IUserRepository 
    {   
         
        public UserRepository(DBContextt _DBContextt) : base (_DBContextt)   
        { 

        }

       

    }
}
