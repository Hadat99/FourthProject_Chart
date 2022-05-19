using Microsoft.AspNetCore.Mvc;

namespace FourthProject_Chart.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Feature()
        {
            int a = 1 + 2;
            return View();
        }
    }
}
