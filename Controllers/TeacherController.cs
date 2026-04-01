using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository.Teacher;

namespace SchoolProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _TeacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            _TeacherRepository = teacherRepository;
        }

        // GET: /Teacher — Show all teachers
        public IActionResult Index()
        {
            var teachers = _TeacherRepository.GetAllTeachers();
            return View(teachers);
        }

        // GET: /Teacher/Create — Show create form
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Teacher/Create — Save new teacher
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            _TeacherRepository.Create(teacher);
            return RedirectToAction("Index");
        }

        // GET: /Teacher/Delete/5 — Delete teacher
        public IActionResult Delete(int id)
        {
            _TeacherRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
