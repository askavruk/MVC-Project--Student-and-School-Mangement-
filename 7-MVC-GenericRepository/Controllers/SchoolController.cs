using _7_MVC_GenericRepository.Entities.Concrete;
using _7_MVC_GenericRepository.Models;
using _7_MVC_GenericRepository.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _7_MVC_GenericRepository.Controllers
{
    public class SchoolController : Controller
    {
        private readonly IRepository<School> schoolRepo;
        School school = new School();
        StudentsWithSchoolsWM studentsWithSchoolsWM = new StudentsWithSchoolsWM();

        public SchoolController(IRepository<School> schoolRepo)
        {
            this.schoolRepo = schoolRepo;
        }


        public IActionResult SchoolList()
        {
            List<School> schools = schoolRepo.GetAll().ToList();

            var role = HttpContext.Session.GetString("Role");


            if (role == "Admin") return View("AdminSchoolList", schools);
            else return View("SchoolList", schools);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SchoolWM schoolVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                school.Name = schoolVM.Name;
                schoolRepo.Add(school);
                return RedirectToAction("SchoolList");
            }
 
        }

        public IActionResult Update(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                studentsWithSchoolsWM.School = schoolRepo.GetById(id);
                return View(studentsWithSchoolsWM);
            }           
        }

        [HttpPost]
        public IActionResult Update(StudentsWithSchoolsWM studentsWithSchoolsWM)
        {

            if (!ModelState.IsValid)
            {
                return View(studentsWithSchoolsWM);
            }
            else
            {
                schoolRepo.Update(studentsWithSchoolsWM.School);
                return RedirectToAction("SchoolList");
            }
        }

        public IActionResult Delete(int id)
        {
            School school = schoolRepo.GetById(id);

            if (!ModelState.IsValid)
            {
                return RedirectToAction("SchoolList");
            }
            else
            {
                schoolRepo.Delete(school);
                return RedirectToAction("SchoolList");
            }
        }
    }
}
