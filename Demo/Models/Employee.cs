using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Demo.Data.Models;

namespace Demo.Models
{
    internal class Employee
    {
     
        
            [Key]
            public int Id { get; set; }
            [Column(TypeName = "varchar(50)")]
            [MaxLength(50)]
            public string FName { get; set; }
            [Column(TypeName = "varchar(50)")]

            [MaxLength(50)]
            public string LName { get; set; }

            [Column(TypeName = "varchar(100)")]
            [MaxLength(50)]
            public string Address { get; set; }
            public int Age { get; set; }
        public int? DepartmentId { get; set; } // Foreign Key Column for Departments Table

        // Navigational Property [ONE]
        public Department? Department { get; set; } = null!;

        // Navigational Property [ONE]
        public Department? ManagedDepartment { get; set; }

    }
}