using Demo.Data.Models;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo
{
    internal static class CompanyDbContextSeed
    {
        public static void Seed(CompanyDBContext dbContext)
        {
            if (!dbContext.Departments.Any())
            {
                var employeesData = File.ReadAllText("departments.json");
                var employees = JsonSerializer.Deserialize<List<Department>>(employeesData);

                if (employees?.Count > 0)
                {
                    foreach (var emp in employees)
                    {
                        dbContext.Departments.Add(emp);
                    }

                    dbContext.SaveChanges();
                }
            }
            if (!dbContext.Employees.Any())
            {
                var employeesData = File.ReadAllText("employees.json");
                var employees = JsonSerializer.Deserialize<List<Employee>>(employeesData);

                if (employees?.Count > 0)
                {
                    foreach (var emp in employees)
                    {
                        dbContext.Employees.Add(emp);
                    }

                    dbContext.SaveChanges();
                }
            }


        }
    }
}