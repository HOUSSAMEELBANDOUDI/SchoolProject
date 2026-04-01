using SchoolProject.Context;
using SchoolProject.Models;
using StudentModel = SchoolProject.Models.Student;

namespace SchoolProject.Repository.Student
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _context;

        public StudentRepository(MyDbContext context)
        {
            _context = context;
        }

        public List<StudentModel> GetAllStudents()
        {
            try
            {
                return _context.Students.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<StudentModel>();
            }
        }

        public void Creat(StudentModel student)
        {
            try
            {
                _context.Students.Add(student);    // INSERT INTO Students
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
                var student = _context.Students.Find(id);   // Find student by ID
                if (student != null)
                {
                    _context.Students.Remove(student);       // DELETE FROM Students WHERE Id = @id
                    _context.SaveChanges();                  
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

   
        public void register(int studentId, int courseId)
        {
            try
            {
                var studentCourse = new StudentCourse
                {
                    StudentId = studentId,
                    CourseId = courseId
                };

                _context.StudentCourses.Add(studentCourse);   // INSERT INTO StudentCourses
                _context.SaveChanges();                        
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
