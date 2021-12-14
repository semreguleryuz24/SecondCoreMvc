using Microsoft.EntityFrameworkCore;
using SecondCoreMvc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCoreMvc.Models
{
    public class SchoolContext:DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {
                
        }
       public  DbSet<Student> Students { get; set; }
    }
}
