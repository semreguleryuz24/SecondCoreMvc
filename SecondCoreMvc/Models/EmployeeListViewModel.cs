using SecondCoreMvc.Entities;
using System.Collections.Generic;

namespace SecondCoreMvc
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employee { get; set; }
        public List<string> Cities { get; set; }
    }
}