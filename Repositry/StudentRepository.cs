using SchoolProject.Context;
using SchoolProject.Models;

namespace SchoolProject.Repositry
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _context;

        public StudentRepository(MyDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                return _context.Students.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Student>();
            }
        }

        public void Creat(Student student)
        {
            
        }

        public void Delete(int id)
        {
           
        }

   
        public void register(int studentId, int courseIs)
        {
          
        }
    }
}
