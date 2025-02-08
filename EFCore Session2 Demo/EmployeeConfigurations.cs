using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Session2_Demo
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .Property("Address") 
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired()
                .HasAnnotation("MaxLength", 50);
        }
    }
}
