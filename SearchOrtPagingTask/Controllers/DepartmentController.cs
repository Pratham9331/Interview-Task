using Microsoft.AspNetCore.Mvc;
using SearchOrtPagingTask.Models;
using SearchSortPagingTaskDAL;

namespace SearchOrtPagingTask.Controllers
{
    public class DepartmentController : Controller
    {
        AppDbContext _db;
        public DepartmentController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var departments = _db.Departments.ToList().
                Select(d => new DepartmentViewModel()
                { Name=d.Name});
            return View(departments);
        }
    }
}
