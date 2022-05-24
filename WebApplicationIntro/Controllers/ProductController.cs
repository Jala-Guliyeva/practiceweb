using Microsoft.AspNetCore.Mvc;

namespace WebApplicationIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
