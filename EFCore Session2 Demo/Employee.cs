using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EFCore_Session2_Demo
{
    // 3. Fluent API (Set of Methods) --> [DbContext] Class
    // 4. Configuration Class --> Organize The 3rd Way

    internal class Employee
    {
        [Required]
        public int Code { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }

        [ForeignKey(nameof(Department))]
        public int? DepartmentId { get; set; }  // Foreign Key column for Departments Table.
        // Navigation Property [One]
        [InverseProperty(nameof(Department.Employees))]
        public Department? Department { get; set; } = null;

        // Navigation Property [One]
        [InverseProperty(nameof(Department.Manager))]
        public Department? ManageDepartment { get; set; }




    }
}
