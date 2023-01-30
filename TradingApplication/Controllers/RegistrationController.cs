using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using TradingApplication.BusinessLogic;
using TradingApplication.DatabaseRepository;


namespace TradingApplication.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public object _Db { get; private set; }

        public RegistrationController(DatabaseContext context , IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult UserLogin()
        {
            Models.UserData model = new Models.UserData();
            model.success = false;
            return View(model);
           
        }

   
        public IActionResult SendMail(string name, string Email , Models.UserData model)
        {
            Email Mail = new Email();
           Mail.SendMail(name="user", Email);
          return Content("Mail Send Successfully.");
          
        }

            [HttpPost]
        public IActionResult UserLogin(Models.UserData model)
        {

            using (DatabaseContext db = new DatabaseContext())
            {

                var UpdateUser = _context.UserDataClass.Where(a => a.Email == model.Email && a.Pwd == model.Pwd).FirstOrDefault();



                if (UpdateUser == null)
                {
                    model.LoginErrorMessage = "Please check UserName or Password";
                    return View(model);
                }
                else
                {

                    if (UpdateUser.IsValidate == 1)
                    {
                        return RedirectToAction("Trading");
                    }
                    else
                    {
                        model.success = true;

                    }


                }
            }

            return View(model);
        }



        public IActionResult UserRegistration()
        {
            Models.UserData model = new Models.UserData();
            model.success = false;
            return View(model);
        }

        [HttpPost]
        public ActionResult UserRegistration(Models.UserData model)
        {
            if (ModelState.IsValid)
            {
                var UpdateUser = _context.UserDataClass.Where(a => a.Email == model.Email).FirstOrDefault();


                DatabaseRepository.UserData User = new DatabaseRepository.UserData();
                if (model.Pwd == model.ConfirmPassword)
                {
                    if (UpdateUser == null)
                    {
                        string s = string.Empty; ;
                        using (var ms = new MemoryStream())
                        {
                            model.Image.CopyTo(ms);

                            var fileBytes = ms.ToArray();
                            s = Convert.ToBase64String(fileBytes);

                            // act on the Base64 data
                        }

                        User.Name = model.Name;
                        User.Email = model.Email;
                        User.Pwd = model.Pwd;
                        User.IsValidate = 0;
                        User.Photo = s;


                        _context.UserDataClass.Add(User);
                        _context.SaveChanges();
                        model.success = true;

                        Email Mail = new Email();
                        Mail.SendMail(model.Name, model.Email);
                       
                    }
                    else
                    {
                        model.LoginErrorMessage = "Email Id alredy Exists.Please log-In with another mail-Id.";
                    }
                }
                else
                {
                    model.LoginErrorMessage = "Password And Confirm Password not matched.";

                    return View("UserRegistration", model);
                }


            }
            return View(model);
        }

            public IActionResult Trading()
        {
            return View();
        }

     
     

        public IActionResult ValidateEmail(string EmailId)
        {
            var UpdateUser = _context.UserDataClass.Where(a => a.Email == EmailId).FirstOrDefault();

            if (UpdateUser.Email == EmailId)
            {
                UpdateUser.IsValidate = 1;
               
                _context.UserDataClass.Update(UpdateUser);
                _context.SaveChanges();

                Models.UserData model = new Models.UserData();
                model.LoginErrorMessage = "Account Email Address Confirmed.Congratulations! Your account address  has been successfully confirmed.";
                return View(model);
            }
            else
            {
                Models.UserData model = new Models.UserData();
                model.LoginErrorMessage = "User Not valid.";
                return View(model);
            }
            return View();
        }


      

    }
}
