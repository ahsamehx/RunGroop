using Microsoft.AspNetCore.Mvc;
using RunGroop.ViewModels;

namespace RunGroop.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login (LoginViewModel login)
        {

        }
    }
}
