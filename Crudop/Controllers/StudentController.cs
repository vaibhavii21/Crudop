using Crudop.Data;
using Microsoft.AspNetCore.Mvc;
using Crudop.Models;

namespace Crudop.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StudentController(ApplicationDbContext db)
        {
            _db=db;
        }
        public IActionResult Index()
        {
            List<Student>objStudentList=_db.StudentTable.ToList();
            return View(objStudentList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student obj)
        {
            _db.StudentTable.Add(obj);
            _db.SaveChanges();
            TempData["Success"] = "Student Created Successfully";
            return RedirectToAction("Index","Home");
        }

        public IActionResult Edit(int? id) 
        { 
            if(id==null || id == 0)
            {
                return NotFound();
            }
            Student? Studentfromdb = _db.StudentTable.Find(id);
          //  Student? Studentfromdb1 = _db.StudentTable.FirstOrDefault(u=>u.Id==id);
          //  Student? Studentfromdb2 = _db.StudentTable.Where(u=>u.Id==id).FirstOrDefault();
            if (Studentfromdb==null)
            {
                return NotFound();
            }
            return View(Studentfromdb);
        }

        [HttpPost]
        public IActionResult Edit(Student obj)
        {
            _db.StudentTable.Update(obj);
            _db.SaveChanges();
            TempData["Success"] = "Student Updated Successfully";
            return RedirectToAction("Index", "Student");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Student? Studentfromdb = _db.StudentTable.Find(id);
            
            if (Studentfromdb == null)
            {
                return NotFound();
            }
            return View(Studentfromdb);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Student? obj =_db.StudentTable.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.StudentTable.Remove(obj);
            _db.SaveChanges();
            TempData["Success"] = "Student Deleted Successfully";
            return RedirectToAction("Index", "Home");
        }
    }
}
