using CascadingDropdownListDAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasxadingDropdownListWeb.Controllers
{
    public class LocationController : Controller
    {
        CascadingDropdownListContext _db;
        public LocationController(CascadingDropdownListContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Country()
        {
            var co = _db.Countries.ToList();
            return new JsonResult(co);
        }
        public JsonResult City(int id)
        {
            var ci = _db.Cities.Where(e => e.CountryId==id).ToList();

            return new JsonResult(ci);
        }
    }
}
