using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        [Required]
        public string UserName { get; set; }  
        [Required]
        public string City { get; set; } 
        [Required]
        public string Address { get; set; }   
        [Required]
        public int AccountNumber { get; set;}  
        [Required]
        public string AccountType { get; set; }  
        [Required]
        public int Amount { get; set; } 



       

    }
}
