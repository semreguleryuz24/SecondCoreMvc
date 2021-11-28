using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SecondCoreMvc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCoreMvc.Controllers
{
    public class EmployeeController : Controller
    {
       public IActionResult Add()
        {
            var employeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities=new List<SelectListItem>
                {
                    new SelectListItem{Text="Ankara",Value="06" },
                    new SelectListItem{Text="İstanbul",Value="34" },
                    new SelectListItem{Text="Erzincan",Value="24" }
                }
             
            };
            return View(employeeAddViewModel);
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View();
        }
      
    }
}
