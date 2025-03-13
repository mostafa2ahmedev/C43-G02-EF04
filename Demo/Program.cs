using Demo.Data.Models;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDBContext companyDBContext = new CompanyDBContext(); ;
            #region Explict-Loading
            #region Example 1 - Department
            //var emp = (from e in companyDBContext.Employees
            //           where e.Id == 3
            //           select e).FirstOrDefault();

            //companyDBContext.Entry(emp).Reference(nameof(Employee.Department)).Load();

            //if (emp is not null)
            //{
            //    Console.WriteLine($"Employee: {emp.FName}, Department: {emp.Department?.Name}");
            //}

            #endregion

            #region Example 02 - Department


            //var dept = (from d in companyDBContext.Departments
            //            where d.DeptId == 1
            //            select d).FirstOrDefault();

            //companyDBContext.Entry(dept).Collection(nameof(Department.Employees)).Load();

            //if (dept is not null)
            //{
            //    Console.WriteLine($"Department: {dept.DeptId}, Department Name: {dept?.Name}");

            //    foreach (var employee in dept.Employees)
            //    {
            //        Console.WriteLine($"---------- Employee: {employee.FName}");
            //    }
            //}
            #endregion

            #endregion



            #region Eager Loading
            // var emp = (from e in companyDBContext.Employees
            //.Include(e => e.Department)
            //            where e.Id == 3
            //            select e).FirstOrDefault();

            // if (emp is not null)
            // {
            //     Console.WriteLine($"Employee: {emp.FName}, Department: {emp.Department?.Name ?? "No Department"}");
            // }



            //var dept = (from d in companyDBContext.Departments
            //.Include(d => d.Employees)
            //            select d).FirstOrDefault();

            //if (dept is not null)
            //{
            //    Console.WriteLine($"Department: {dept.DeptId}, Department Name: {dept?.Name}");

            //    foreach (var employee in dept.Employees)
            //    {
            //        Console.WriteLine($"--------- Employee: {employee.FName}");
            //    }
            //}

            #endregion

            #region Lazy Loagin
            //var emp = (from e in companyDBContext.Employees
            //           where e.Id == 3
            //           select e).FirstOrDefault();

            //companyDBContext.Entry(emp).Reference(nameof(Employee.Department)).Load();

            //if (emp is not null)
            //{
            //    Console.WriteLine($"Employee: {emp.FName}, Department: {emp.Department?.Name}");
            //}
            #endregion


            #region Join
            //var res = from d in companyDBContext.Departments
            //          join e in companyDBContext.Employees
            //          on d.DeptId equals e.DepartmentId
            //          select new
            //          {
            //              EmployeeId = e.Id,
            //              EmployeeName = e.FName,
            //              DepartmentId = d.DeptId,
            //              DepartmentName = d.Name
            //          };
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Employee: {item.EmployeeName}, Department: {item.DepartmentName}");
            //}
            //        res = companyDBContext.Departments
            //.Join(companyDBContext.Employees,
            //      d => d.DeptId,
            //      e => e.DepartmentId,
            //      (d, e) => new
            //      {
            //          EmployeeId = e.Id,
            //          EmployeeName = e.FName,
            //          DepartmentId = d.DeptId,
            //          DepartmentName = d.Name
            //      });


            //        var groupJoinRes = companyDBContext.Departments
            //.GroupJoin(companyDBContext.Employees,
            //    d => d.DeptId,  // Outer key selector (Departments)
            //    e => e.DepartmentId,  // Inner key selector (Employees)
            //    (department, employees) => new // Result selector
            //    {
            //        department,
            //        employees
            //    });


            //var groupJoinRes = from d in companyDBContext.Departments
            //                   join e in companyDBContext.Employees
            //                   on d.DeptId equals e.DepartmentId into empGroup
            //                   select new
            //                   {
            //                       department = d,
            //                       employees = empGroup
            //                   };

            //foreach (var item in groupJoinRes)
            //{
            //    Console.WriteLine($"Department: {item.department.Name}");

            //    foreach (var emp in item.employees)
            //    {
            //        Console.WriteLine($"  Employee: {emp.FName}");
            //    }
            //}


            #endregion
        }
    }
}
