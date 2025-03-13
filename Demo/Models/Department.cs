using Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly CreationDate { get; set; }

        // Navigational Property [Many]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        // Navigational Property [ONE]
        public Employee Manager { get; set; } = null!;



    }
}
