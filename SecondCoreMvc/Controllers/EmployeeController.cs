using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SecondCoreMvc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondCoreMvc.Models;
using SecondCoreMvc.Services;

namespace SecondCoreMvc.Controllers
{
    public class EmployeeController : Controller
    {

        private ICalculator _calculator;
        public EmployeeController(ICalculator calculator)
        {
            _calculator = calculator;
        }
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
        public string Calculate()
        {
            return _calculator.Calculate(100).ToString();
        }

    }
}
