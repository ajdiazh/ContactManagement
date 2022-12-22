using Microsoft.AspNetCore.Mvc;

namespace ContactManagement.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            ViewBag.postId = id;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
