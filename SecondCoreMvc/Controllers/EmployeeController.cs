using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SecondCoreMvc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondCoreMvc.Models;

namespace SecondCoreMvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            var EmployeeAddViewModel = new EmployeeAddViewModel
            {
                Employee = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Ankara", Value = "6" },
                    new SelectListItem { Text = "İstanbul", Value = "34" },
                    new SelectListItem { Text = "Erzincan", Value = "24" }

                }
            };
            return View(EmployeeAddViewModel);
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {

            return View();
        }

    }
}
