using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session2_Demo
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string? Name { get; set; }
        public DateOnly? CreationDate { get; set; }

        // Navigation Property [Many]
        [InverseProperty(nameof(Employee.Department))]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

        [ForeignKey(nameof(Manager))]
        public int? ManagerId { get; set; }  // Foreign Key column for Employees Table.

        // Navigation Property [One]
        [InverseProperty(nameof(Employee.ManageDepartment))]
        [ForeignKey(nameof(Department.ManagerId))]
        public Employee? Manager { get; set; }
    }
}
