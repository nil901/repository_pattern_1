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



        [Display(Name = "Account_model")]
         public virtual int AccountNo { get; set; }

        [ForeignKey("AccountNo")]
        public virtual Account Account { get; set; } 

    }
}
