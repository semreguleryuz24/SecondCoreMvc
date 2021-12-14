using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SecondCoreMvc.Entities;

namespace SecondCoreMvc.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper:TagHelper
    {
        private List<Employee> _employees;
        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Sırrı Emre",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=2,FirstName="Emir Taha",LastName="GÜLERYÜZ",CityId=6},
                new Employee{Id=3,FirstName="Çınar",LastName="AYAZ",CityId=5},
                new Employee{Id=4,FirstName="Defne",LastName="AYAZ",CityId=5}

            };
        }
        private const string ListCountAttributeName = "count";
        [HtmlAttributeName(ListCountAttributeName)]
        public int ListCount { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var query = _employees.Take(ListCount);

            StringBuilder stringBuilder = new StringBuilder();
            foreach(var employee in query)
            {
                stringBuilder.AppendFormat("<h2> <a href='/employee/detail/{0}'>{1} </a></h2>",employee.Id,employee.FirstName);
            }
            output.Content.SetHtmlContent(stringBuilder.ToString());
            base.Process(context, output);
        }

    }
}
