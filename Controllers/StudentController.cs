using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository.Student;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _StudentRepository;

        // Constructor — DI injects StudentRepository here
        public StudentController(IStudentRepository studentRepository)
        {
            _StudentRepository = studentRepository;
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

        // GET: /Student/Delete/5 — Delete student
        public IActionResult Delete(int id)
        {
            _StudentRepository.Delete(id);
            return RedirectToAction("Index");
        }

        // GET: /Student/Register?studentId=1&courseId=3
        public IActionResult Register(int studentId, int courseId)
        {
            _StudentRepository.register(studentId, courseId);
            return RedirectToAction("Index");
        }
    }
}
