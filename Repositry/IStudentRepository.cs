using SchoolProject.Models;

namespace SchoolProject.Repositry
{
    public interface IStudentRepository
    {
        public List<Student> GetAllStudents();
        public void Creat(Student student);
        public void Delete(int id);
        public void register(int studentId, int courseIs);
    }
}
