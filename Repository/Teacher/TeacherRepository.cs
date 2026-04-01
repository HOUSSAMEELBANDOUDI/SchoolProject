using SchoolProject.Context;
using SchoolProject.Models;
using TeacherModel = SchoolProject.Models.Teacher;

namespace SchoolProject.Repository.Teacher
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly MyDbContext _context;

        public TeacherRepository(MyDbContext context)
        {
            _context = context;
        }

        public List<TeacherModel> GetAllTeachers()
        {
            try
            {
                return _context.Teachers.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<TeacherModel>();
            }
        }

        public void Create(TeacherModel teacher)
        {
            try
            {
                _context.Teachers.Add(teacher);
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
                var teacher = _context.Teachers.Find(id);
                if (teacher != null)
                {
                    _context.Teachers.Remove(teacher);
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
