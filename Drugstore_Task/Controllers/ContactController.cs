using Microsoft.AspNetCore.Mvc;

namespace Drugstore_Task.Controllers
{
    // Контроллер страницы Contact
    public class ContactController : Controller  
    {
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Check(ContactController Contact) // Ситраница контакты
        {
            if (ModelState.IsValid)
            {
                return Redirect("/"); //Возвращение на главную
            }
            return View("Contact");
        }
    }
}

