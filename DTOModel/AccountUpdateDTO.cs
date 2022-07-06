using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
   public class AccountUpdateDTO
    { 
       public int AccountNo { get; set; } 
       public string BankName { get; set; }  
        public string AccountType { get; set; }
    }
}
