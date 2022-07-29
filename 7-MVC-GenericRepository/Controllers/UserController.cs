using _7_MVC_GenericRepository.Entities.Concrete;
using _7_MVC_GenericRepository.Models;
using _7_MVC_GenericRepository.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_MVC_GenericRepository.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;

        UserVM userVM = new UserVM();
 

        public UserController(IUserRepository userRepository, IStudentRepository studentRepository, IRepository<School> schoolRepo, IRepository<Lesson> lessonRepo)
        {
            this.userRepository = userRepository;
        }

        public IActionResult Index()
        {
            userVM.Name = Request.Cookies["Name"];
            return View("Index", userVM);
        }

        [HttpPost]
        public IActionResult Index(UserVM userVM)
        {
            User user = userRepository.CheckLogin(userVM.Name, userVM.Password);
            if (user != null)
            {
                string name = userVM.Name;

                HttpContext.Session.SetString("Name", name);
                HttpContext.Session.SetString("Role", user.UserType.ToString());
 
                if (userVM.RememberMe)
                {
                    CookieOptions options = new CookieOptions();
                    options.Expires = DateTime.Now.AddYears(10);
                    Response.Cookies.Append("Name", name, options);    
                }
                else if (!userVM.RememberMe)
                {
                    Response.Cookies.Delete("name");
                }
                return RedirectToAction("MainPage"); //
            }

            ViewBag.Message = "Giriş bilgileriniz doğru değil! Lütfen tekrar kontrol edin!";
            return View(userVM);
        }

        public IActionResult MainPage()
        {
            return View();
        }
 

        //LogOut
        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("Name");
            HttpContext.Session.Remove("Password");
            return RedirectToAction("Index");
        }
    }
}
