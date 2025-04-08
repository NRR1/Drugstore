using Microsoft.AspNetCore.Mvc;

namespace Drugstore_Task.Controllers
{
    // Контроллер страницы About
    public class ContactController : Controller  
    {
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Check(ContactController contact) // Ситраница контакты
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Contact");
        }
    }
}

