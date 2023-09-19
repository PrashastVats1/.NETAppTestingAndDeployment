using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class EmployeesController : Controller
    {
        public static List<Employee> empList = new List<Employee>()
        {
            new Employee(){Id=1,FName="Raj",LName="Dicosta",Salary=98000.98,Designation="Manager"},
            new Employee(){Id=2,FName="Sam",LName="Kumar",Salary=69000.69,Designation="Developer"},
            new Employee(){Id=3,FName="Ravi",LName="Black",Salary=88000.80,Designation="Tester"},
            new Employee(){Id=4,FName="Rohit",LName="Dam",Salary=79450.79,Designation="HR"},
            new Employee(){Id=5,FName="Vikas",LName="Kunwar",Salary=98990.99,Designation="Developer"},
            new Employee(){Id=6,FName="AArushi",LName="Kumari",Salary=87000.87,Designation="Tester"},
        };
        public IActionResult Index()
        {
            return View(empList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                empList.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
