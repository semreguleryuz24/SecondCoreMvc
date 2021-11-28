using Microsoft.AspNetCore.Mvc;
using SecondCoreMvc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCoreMvc.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "HELLO!! First From Project";
        }
        public ViewResult Index2()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Sırrı Emre",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=2,FirstName="Emir Taha",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=3,FirstName="Çınar",LastName="AYAZ",CityId=5},
                new Employee{Id=4,FirstName="Defne",LastName="AYAZ",CityId=5}
            };
            List<string> cities = new List<string> { "İstanbul", "Ankara" };

            var model = new EmployeeListViewModel
            {
                Employee = employees,
                Cities = cities
            };


            return View(model);
        }
        public StatusCodeResult Index4()
        {
            return Ok();
        }
        public StatusCodeResult Index5()
        {
            return NotFound();
        }
        public RedirectResult Index6()
        {
            return Redirect("/Home/Index2");
        }
        public IActionResult Index7()
        {
            return RedirectToRoute("default");
        }
        public JsonResult Index8()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Sırrı Emre",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=2,FirstName="Emir Taha",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=3,FirstName="Çınar",LastName="AYAZ",CityId=5},
                new Employee{Id=4,FirstName="Defne",LastName="AYAZ",CityId=5}
            };
            return Json(employees);
        }
        public IActionResult RazorDemo()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Sırrı Emre",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=2,FirstName="Emir Taha",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=3,FirstName="Çınar",LastName="AYAZ",CityId=5},
                new Employee{Id=4,FirstName="Defne",LastName="AYAZ",CityId=5}
            };
            List<string> cities = new List<string> { "İstanbul", "Ankara" };

            var model = new EmployeeListViewModel
            {
                Employee = employees,
                Cities = cities
            };


            return View(model);

        }
        public JsonResult Index9(string key)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Sırrı Emre",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=2,FirstName="Emir Taha",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=3,FirstName="Çınar",LastName="AYAZ",CityId=5},
                new Employee{Id=4,FirstName="Defne",LastName="AYAZ",CityId=5}
            };

            if(string.IsNullOrEmpty(key))
            {
                return Json(employees);
            }
            var result = employees.Where(e => e.FirstName.ToLower().Contains(key)); 
            return Json(result);
        }
        public ViewResult EmployeeForm()
        {
            return View();
        }
        public  string RouteData(int id)
        {
            return id.ToString();
        }

    }
}
//http://engindemirog.com/home/index
//HomeController h=new Controller();
//h.Index();

