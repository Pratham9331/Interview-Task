using AutoMapper;
using AutoMapperDAL;
using AutomapperWebTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomapperWebTask.Controllers
{
    public class EmployeeController : Controller
    {
        IMapper _mapper;
        AppDbContext _db;
        public EmployeeController(IMapper mapper, AppDbContext db)
        {
            _db = db;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var depts = _db.Employees.Include(e => e.Department)
                .Select(p => p).ToList();

            var model= _mapper.Map<IEnumerable<EmployeeViewModel>>(depts);  
            return View(model);
        }
    }
}
