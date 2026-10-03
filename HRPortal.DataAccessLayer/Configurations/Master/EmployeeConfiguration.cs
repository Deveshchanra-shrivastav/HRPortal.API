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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.ToTable("Employees");

            entity.HasKey(e => e.EmployeeMasterId);

            entity.Property(e => e.EmployeeMasterId)
                .UseIdentityColumn(1, 1);

            entity.Property(e => e.EmployeeCode)
                .IsRequired()
                .HasColumnType("nvarchar(150)");

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasColumnType("nvarchar(150)");

            entity.HasIndex(e => e.UserName)
                .IsUnique();

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(e => e.MiddleName)
                .HasColumnType("nvarchar(max)");

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasColumnType("nvarchar(150)");

            entity.Property(e => e.MobileNumber)
                .IsRequired()
                .HasColumnType("nvarchar(20)");

            entity.Property(e => e.Gender)
                .HasColumnType("nvarchar(20)");

            entity.Property(e => e.Address)
                .HasColumnType("nvarchar(max)");
            entity.Property(e => e.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);
            entity.Property(e => e.IsLatest)
                .IsRequired()
                .HasDefaultValue(true);

            entity.HasOne<OrganizationMaster>()
                .WithMany()
                .HasForeignKey(e => e.OrganizationMasterId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne<RoleMaster>()
                .WithMany()
                .HasForeignKey(e => e.RoleMasterId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasOne<Designation>()
                .WithMany()
                .HasForeignKey(e => e.DesignationMasterId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne<Branch>()
                .WithMany()
                .HasForeignKey(e => e.BranchMasterId)
                .OnDelete(DeleteBehavior.Restrict);

        }


    }
}
