using SchoolProject.Models;
using CourseModel = SchoolProject.Models.Course;

namespace SchoolProject.Repository.Course
{
    public interface ICourseRepository
    {
        public List<CourseModel> GetAllCourses();
        public void Create(CourseModel course);
        public void Delete(int id);
    }
}
