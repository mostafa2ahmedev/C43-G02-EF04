using Demo.Data.Models;
using Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class CompanyDBContext : DbContext
    {


      public  DbSet<Department> Departments { get; set; }
      public  DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company;Trusted_Connection=True;Encrypt=False;").UseLazyLoadingProxies();

        }
    }
}
