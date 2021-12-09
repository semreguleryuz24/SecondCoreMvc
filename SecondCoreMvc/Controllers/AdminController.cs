using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCoreMvc.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("Save")]
        [Route("~/Save")]
        public string Save()
        {
            return "Saved";
        }
        [Route("delete/{id?}")]
        public string Delete(int id=0)
        {
            return string.Format("Deleted {0}", id);
        }
        [Route("update")]
        public string Update()
        {
            return "Updated";
        }
    }
}
