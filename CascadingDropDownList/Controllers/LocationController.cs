using Microsoft.AspNetCore.Mvc;

namespace CascadingDropDownList.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
