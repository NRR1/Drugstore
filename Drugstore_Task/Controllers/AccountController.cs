using Drugstore_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace Drugstore_Task.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register() => View();


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                bool user = true;
                if(user != true)
                {
                    ModelState.AddModelError(string.Empty, "пользователя нету");
                    return NotFound();
                }
                if(user != null)
                {
                    return RedirectToAction("Index", "Medicine");
                }
            }
            return View(vm);
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel vm = new LoginViewModel();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                if(vm.Login == null && vm.Password == null)
                {
                    ModelState.AddModelError(string.Empty, "Пользователя нету");
                    return NotFound();
                }
                else
                {
                    return RedirectToAction("Index", "Medicine");
                }
            }
            return View(vm);
        }
    }
}
