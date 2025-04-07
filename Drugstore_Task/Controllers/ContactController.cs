using Microsoft.AspNetCore.Mvc;

namespace Drugstore_Task.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Check(Contact contact) // Ситраница контакты
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Contact");
        }
    }
}

