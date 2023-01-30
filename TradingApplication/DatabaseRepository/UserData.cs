using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TradingApplication.DatabaseRepository
{
    [Table("TradingUserDetails")]
    public class UserData
    {
        [Key] 
        public int UserId { get; set; }

      
        public string Name { get; set; }

        
        public string Email { get; set; }


     
        public string Pwd { get; set; }


      

        public string Photo { get; set; }

        public int IsValidate { get; set; }

      
    }

}
