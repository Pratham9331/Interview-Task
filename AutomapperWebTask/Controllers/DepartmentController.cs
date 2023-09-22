using Microsoft.AspNetCore.Mvc;

using AutoMapperDAL;
using AutoMapper;
using AutomapperWebTask.Models;
using AutoMapperDAL.Entities;

namespace AutomapperWebTask.Controllers
{
    public class DepartmentController : Controller
    {
        AppDbContext _db;
        IMapper _mapper;
        public DepartmentController(AppDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public IActionResult Index()
        {
            var depts = _db.Departments.Select(e => e).ToList();
            var models = _mapper.Map<IEnumerable<DepartmentViewModel>>(depts);
            return View(models);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentViewModel model)
        {
            ModelState.Remove("DepartmentId");
            if (ModelState.IsValid)
            {
                Department department = _mapper.Map<Department>(model);
                _db.Departments.Add(department);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            DepartmentViewModel model = null;
            Department data = _db.Departments.Find(id);
            if (data != null)
            {
                model = _mapper.Map<DepartmentViewModel>(data);
            }
            return View("Create", model);
        }

        [HttpPost]
        public IActionResult Edit(DepartmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                Department department = _mapper.Map<Department>(model);

                _db.Departments.Update(department);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
