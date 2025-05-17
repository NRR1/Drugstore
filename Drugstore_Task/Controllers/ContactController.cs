using Microsoft.AspNetCore.Mvc;

namespace Drugstore_Task.Controllers
{
    // Контроллер страницы Contact
    public class ContactController : Controller  
    {

        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Creators() => RedirectToAction("Creators", "Home");
        public IActionResult Check(ContactController contact) // Ситраница контакты
        {
            if (ModelState.IsValid)
            {
                return Redirect("/"); //Возвращение на главную
            }
            return View();
        }
    }
}
