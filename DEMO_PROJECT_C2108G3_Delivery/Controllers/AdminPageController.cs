using Microsoft.AspNetCore.Mvc;

namespace DEMO_PROJECT_C2108G3_Delivery.Controllers
{
    public class AdminPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
