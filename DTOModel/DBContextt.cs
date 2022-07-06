using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
   public class DBContextt : DbContext 

    { 
        public DBContextt(DbContextOptions options) : base (options)
        {

        }  

       public DbSet<Account> Account { get; set; } 
      
     public  DbSet<User> User { get; set; }  

    }
}
