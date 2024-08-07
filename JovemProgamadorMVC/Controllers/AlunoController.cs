using Microsoft.AspNetCore.Mvc;

namespace JovemProgamadorMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
