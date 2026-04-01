using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository.Course;

namespace SchoolProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _CourseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _CourseRepository = courseRepository;
        }

        // GET: /Course — Show all courses
        public IActionResult Index()
        {
            var courses = _CourseRepository.GetAllCourses();
            return View(courses);
        }

        // GET: /Course/Create — Show create form
        public IActionResult Create()
        {
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
