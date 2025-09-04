using Microsoft.AspNetCore.Mvc;

namespace MemoApi.Controllers
{
    public class CompteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
