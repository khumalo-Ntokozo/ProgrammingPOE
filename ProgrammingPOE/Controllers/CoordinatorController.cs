using Microsoft.AspNetCore.Mvc;

namespace ProgrammingPOE.Controllers
{
    public class CoordinatorController : Controller
    {
        public IActionResult ReviewClaims()
        {
            return View();
        }
    }
}
