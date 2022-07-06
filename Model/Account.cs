using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class Account
    {  
      [Key]
      public   int AccountNo { get; set; }
      [Required]
      public string BankName { get; set; } 
      [Required]
      public  string AccountType { get; set; }    
      

      
      


    }
}
