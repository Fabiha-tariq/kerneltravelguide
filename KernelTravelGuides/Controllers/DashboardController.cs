using Microsoft.AspNetCore.Mvc;

namespace KernelTravelGuides.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
