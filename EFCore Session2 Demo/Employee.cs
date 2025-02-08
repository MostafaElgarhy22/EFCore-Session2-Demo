using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Session2_Demo
{
    // 3. Fluent API (Set of Methods) --> [DbContext] Class
    // 4. Configuration Class --> Organize The 3rd Way

    internal class Employee
    {
        public int Code { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }
    }
}
