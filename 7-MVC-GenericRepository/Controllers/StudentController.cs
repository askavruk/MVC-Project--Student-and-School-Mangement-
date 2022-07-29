using _7_MVC_GenericRepository.Entities.Concrete;
using _7_MVC_GenericRepository.Models;
using _7_MVC_GenericRepository.Repositories.Abstract;
using _7_MVC_GenericRepository.Repositories.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _7_MVC_GenericRepository.Controllers
{
    public class StudentController : Controller
    {

        private readonly IStudentRepository studentRepository;
        private readonly IRepository<School> schoolRepository;
        StudentsWithSchoolsWM studentsWithSchoolsWM = new StudentsWithSchoolsWM();

        public StudentController(IStudentRepository studentRepository, IRepository<School> schoolRepository)
        {
            this.studentRepository = studentRepository;
            this.schoolRepository = schoolRepository;
        }


        public IActionResult StudentList()
        {
            List<Student> students = studentRepository.GetAllIncludeSchools().ToList();

            var role = HttpContext.Session.GetString("Role");


            if (role == "Admin") return View("AdminStudentList", students);
            else return View("StudentsList", students);

        }

        [HttpPost]
        public IActionResult StudentList(Student student)
        {
            return View();
        }

        public IActionResult Creation()
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                studentsWithSchoolsWM.Schools = schoolRepository.GetAll();
                return View(studentsWithSchoolsWM);
            }             
        }

        [HttpPost]
        public IActionResult Creation(StudentsWithSchoolsWM studentsWithSchoolsWM)
        {
            studentsWithSchoolsWM.Schools = schoolRepository.GetAll();

            if (!ModelState.IsValid)
            {
                return View(studentsWithSchoolsWM);
            }
            else
            {
                studentRepository.Add(studentsWithSchoolsWM.Student);
                return RedirectToAction("StudentList");
            }

        }

        public IActionResult Update(int id)
        {
            studentsWithSchoolsWM.Schools = schoolRepository.GetAll();

            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                
                studentsWithSchoolsWM.Student = studentRepository.GetByIncludeSchool(id);
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
                studentRepository.Update(studentsWithSchoolsWM.Student);
                return RedirectToAction("StudentList");
            }
        }

        public IActionResult Delete(int id)
        {
            Student student = studentRepository.GetById(id);
            if (!ModelState.IsValid)
            {
                return RedirectToAction("StudentList");
            }
            else
            {
                studentRepository.Delete(student);
                return RedirectToAction("StudentList");
            }
        }
    }
}
