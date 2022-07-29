using _7_MVC_GenericRepository.Entities.Concrete;
using _7_MVC_GenericRepository.Models;
using _7_MVC_GenericRepository.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _7_MVC_GenericRepository.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<School> schoolRepository;
        private readonly IStudentRepository studentRepository;

        

        public HomeController(ILogger<HomeController> logger, IRepository<School> schoolRepository, IStudentRepository studentRepository)
        {
            _logger = logger;
            this.schoolRepository = schoolRepository;
            this.studentRepository= studentRepository;
        }

        public IActionResult Index()
        {
            List<School> schools = schoolRepository.GetAll().ToList();
            return View(schools);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
