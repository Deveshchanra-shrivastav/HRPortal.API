using HRPortal.Entities.Master;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.DataAccessLayer.Configurations.Master
{
    public class EmployeeDepartmentConfiguration : IEntityTypeConfiguration<EmployeeDepartment>
    {
        public void Configure(EntityTypeBuilder<EmployeeDepartment> entity)
        {
            entity.ToTable("EmployeeDepartments");

            entity.HasKey(e => e.EmployeeDepartmentId);

            entity.Property(e => e.EmployeeDepartmentId)
                .UseIdentityColumn(1, 1);

            entity.HasOne<Employee>()
                .WithMany()
                .HasForeignKey(e => e.EmployeeMasterId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne<Department>()
                .WithMany()
                .HasForeignKey(e => e.DepartmentMasterId)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasOne<OrganizationMaster>()
                .WithMany()
                .HasForeignKey(e => e.OrganizationMasterId)
                .OnDelete(DeleteBehavior.Restrict);

            

            entity.HasIndex(e => new
            {
                e.EmployeeMasterId,
                e.DepartmentMasterId
            })
            .IsUnique();
            entity.Property(e => e.IsDeleted)
               .IsRequired()
               .HasDefaultValue(false);
            entity.Property(e => e.IsLatest)
                .IsRequired()
                .HasDefaultValue(true);
        }
    }
}
