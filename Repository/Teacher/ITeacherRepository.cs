using SchoolProject.Models;
using TeacherModel = SchoolProject.Models.Teacher;

namespace SchoolProject.Repository.Teacher
{
    public interface ITeacherRepository
    {
        public List<TeacherModel> GetAllTeachers();
        public void Create(TeacherModel teacher);
        public void Delete(int id);
    }
}
