using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository.Room;

namespace SchoolProject.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomRepository _RoomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _RoomRepository = roomRepository;
        }

        // GET: /Room — Show all rooms
        public IActionResult Index()
        {
            var rooms = _RoomRepository.GetAllRooms();
            return View(rooms);
        }

        // GET: /Room/Create — Show create form
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Room/Create — Save new room
        [HttpPost]
        public IActionResult Create(Room room)
        {
            _RoomRepository.Create(room);
            return RedirectToAction("Index");
        }

        // POST: /Room/Delete/5 — Delete room with confirmation
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _RoomRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
