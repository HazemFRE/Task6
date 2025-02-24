using Microsoft.AspNetCore.Mvc;
using Task6.Models;

namespace Task6.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly MyDbContext _context;

        public DepartmentController()
        {

            _context = new MyDbContext();
        }


        public ActionResult Index()
        {
            var Departments = _context.Departments.ToList();
            return View(Departments);
        }
        public ActionResult Create()
        {
            Department newDepartment = new Department();
            return View(newDepartment);
        }



        //[HttpPost]
        //public ActionResult Create(Department newDepartment)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Departments.Add(newDepartment);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(newDepartment);
        //}
        [HttpPost]
        public ActionResult Create(Department newDepartment)
        {

            _context.Departments.Add(newDepartment);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult Details(int id)
        {
            var department = _context.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            var department = _context.Departments.Find(Id);
            if (department == null)
            {
                return NotFound();
            }

            _context.Departments.Remove(department);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
       
    }
}
