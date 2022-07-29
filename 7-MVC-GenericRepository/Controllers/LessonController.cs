using _7_MVC_GenericRepository.Entities.Concrete;
using _7_MVC_GenericRepository.Models;
using _7_MVC_GenericRepository.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _7_MVC_GenericRepository.Controllers
{
    public class LessonController : Controller
    {
        private readonly IRepository<Lesson> lessonRepo;
        Lesson lesson = new Lesson();
        LessonVM lessonVM = new LessonVM();
        public LessonController(IRepository<Lesson> lessonRepo)
        {
            this.lessonRepo = lessonRepo;
        }

        public IActionResult LessonList()
        {
            List<Lesson> lessons = lessonRepo.GetAll().ToList();

            var role = HttpContext.Session.GetString("Role");

            if (role == "Admin") return View("AdminLessonList", lessons);
            else return View("LessonList", lessons);

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(LessonVM lessonVM)
        {
            if (!ModelState.IsValid)
            {
                return View(lessonVM);
            }
            else
            {
                lesson.Name = lessonVM.Name;
                lessonRepo.Add(lesson);
                return RedirectToAction("LessonList");
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
                lesson = lessonRepo.GetById(id);
                lessonVM.Name = lesson.Name;
                lessonVM.Id = lesson.Id;
                return View(lessonVM);
            }
        }

        [HttpPost]
        public IActionResult Update(LessonVM lessonVM)
        {
            if (!ModelState.IsValid)
            {
                return View(lessonVM);
            }
            else
            {
                lesson.Name = lessonVM.Name;
                lesson.Id = (int)lessonVM.Id;
                lessonRepo.Update(lesson);
                return RedirectToAction("LessonList");
            }
        }


        public IActionResult Delete(int id)
        {
            lesson = lessonRepo.GetById(id);
            if (!ModelState.IsValid)
            {

                return RedirectToAction("LessonList");
            }
            else
            {
                lessonRepo.Delete(lesson);
                return RedirectToAction("LessonList");
            }
        }
    }
}
