using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolProject.Context;
using SchoolProject.Models;
using SchoolProject.Repository.Student;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _StudentRepository;
        private readonly MyDbContext _context;

        // Constructor — DI injects StudentRepository and DbContext here
        public StudentController(IStudentRepository studentRepository, MyDbContext context)
        {
            _StudentRepository = studentRepository;
            _context = context;
        }

        // GET: /Student — Show all students
        public IActionResult Index()
        {
            var students = _StudentRepository.GetAllStudents();
            return View(students);
        }

        // GET: /Student/Create — Show create form
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Student/Create — Save new student
        [HttpPost]
        public IActionResult Create(Student student)
        {
            _StudentRepository.Creat(student);
            return RedirectToAction("Index");
        }

        // POST: /Student/Delete/5 — Delete student with confirmation
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _StudentRepository.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: /Student/Register — Show register form (select student + course)
        public IActionResult Register()
        {
            ViewBag.Students = new SelectList(_context.Students.ToList(), "StudentId", "StudentName");
            ViewBag.Courses = new SelectList(_context.Courses.ToList(), "CourseId", "CourseName");
            return View();
        }

        // POST: /Student/Register — Save the registration
        [HttpPost]
        public IActionResult Register(int studentId, int courseId)
        {
            _StudentRepository.register(studentId, courseId);
            return RedirectToAction("Index");
        }
    }
}
