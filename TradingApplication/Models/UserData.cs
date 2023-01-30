using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TradingApplication.BusinessLogic;

namespace TradingApplication.Models
{
    
    public class UserData
    {
       
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email  is required")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password  is required")]
        public string Pwd { get; set; }


        [Required(ErrorMessage = "Please Upload your Passport Size Photo.")]
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".png" ,".jpeg"})]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Confirm Password  is required")]
        public string ConfirmPassword { get; set; }

        public string LoginErrorMessage { get; set; }

        public string SendMailSuccess { get; set; }
        public int IsValidate { get; set; }

        public bool success { get; set; }


        
    }

}
