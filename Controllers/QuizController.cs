using Microsoft.AspNetCore.Mvc;

namespace ArefQadiyatak.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
