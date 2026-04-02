using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolProject.Context;
using SchoolProject.Models;
using SchoolProject.Repository.Course;

namespace SchoolProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _CourseRepository;
        private readonly MyDbContext _context;

        public CourseController(ICourseRepository courseRepository, MyDbContext context)
        {
            _CourseRepository = courseRepository;
            _context = context;
        }

        // GET: /Course — Show all courses
        public IActionResult Index()
        {
            var courses = _CourseRepository.GetAllCourses();
            return View(courses);
        }

        // GET: /Course/Create — Show create form with teacher dropdown
        public IActionResult Create()
        {
            ViewBag.Teachers = new SelectList(_context.Teachers.ToList(), "TeacherId", "TeacherName");
            return View();
        }

        // POST: /Course/Create — Save new course
        [HttpPost]
        public IActionResult Create(Course course)
        {
            _CourseRepository.Create(course);
            return RedirectToAction("Index");
        }

        // POST: /Course/Delete/5 — Delete course with confirmation
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _CourseRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
