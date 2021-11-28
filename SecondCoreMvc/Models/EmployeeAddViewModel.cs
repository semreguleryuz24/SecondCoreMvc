using Microsoft.AspNetCore.Mvc.Rendering;
using SecondCoreMvc.Entities;
using System.Collections.Generic;

namespace SecondCoreMvc
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectListItem> Cities { get;  set; }
    }
}