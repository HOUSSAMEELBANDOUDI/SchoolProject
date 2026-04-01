using SchoolProject.Context;
using SchoolProject.Models;
using RoomModel = SchoolProject.Models.Room;

namespace SchoolProject.Repository.Room
{
    public class RoomRepository : IRoomRepository
    {
        private readonly MyDbContext _context;

        public RoomRepository(MyDbContext context)
        {
            _context = context;
        }

        public List<RoomModel> GetAllRooms()
        {
            try
            {
                return _context.Rooms.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<RoomModel>();
            }
        }

        public void Create(RoomModel room)
        {
            try
            {
                _context.Rooms.Add(room);
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
                var room = _context.Rooms.Find(id);
                if (room != null)
                {
                    _context.Rooms.Remove(room);
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
