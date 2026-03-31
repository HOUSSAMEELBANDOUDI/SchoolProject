using Microsoft.AspNetCore.Mvc;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
