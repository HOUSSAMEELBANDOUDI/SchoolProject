using SchoolProject.Models;
using StudentModel = SchoolProject.Models.Student;

namespace SchoolProject.Repository.Student
{
    public interface IStudentRepository
    {
        public List<StudentModel> GetAllStudents();
        public void Creat(StudentModel student);
        public void Delete(int id);
        public void register(int studentId, int courseIs);
    }
}
