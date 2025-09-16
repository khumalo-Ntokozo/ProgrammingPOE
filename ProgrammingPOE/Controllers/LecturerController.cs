using Microsoft.AspNetCore.Mvc;

namespace ProgrammingPOE.Controllers
{
    public class LecturerController : Controller
    {
        public IActionResult SubmitClaim()
        {
            return View();
        }

        public IActionResult TrackClaims()
        {
            return View();
        }
    }
}
