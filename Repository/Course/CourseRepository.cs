using SchoolProject.Context;
using SchoolProject.Models;
using CourseModel = SchoolProject.Models.Course;

namespace SchoolProject.Repository.Course
{
    public class CourseRepository : ICourseRepository
    {
        private readonly MyDbContext _context;

        public CourseRepository(MyDbContext context)
        {
            _context = context;
        }

        public List<CourseModel> GetAllCourses()
        {
            try
            {
                return _context.Courses.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<CourseModel>();
            }
        }

        public void Create(CourseModel course)
        {
            try
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var course = _context.Courses.Find(id);
                if (course != null)
                {
                    _context.Courses.Remove(course);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
