using SchoolProject.Models;
using RoomModel = SchoolProject.Models.Room;

namespace SchoolProject.Repository.Room
{
    public interface IRoomRepository
    {
        public List<RoomModel> GetAllRooms();
        public void Create(RoomModel room);
        public void Delete(int id);
    }
}
