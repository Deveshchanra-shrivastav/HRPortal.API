using HRPortal.Entities.Payroll;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Entities.Master;

namespace HRPortal.DataAccessLayer.Configurations.Payroll
{
    public class PayslipConfiguration : IEntityTypeConfiguration<Payslip>
    {
        public void Configure(EntityTypeBuilder<Payslip> entity)
        {
            entity.ToTable("Payslips");

            entity.HasKey(p => p.PayslipId);

            entity.Property(p => p.PayslipId)
                .UseIdentityColumn(1, 1);

            entity.Property(p => p.TotalEarnings)
                .HasColumnType("decimal(18,2)");

            entity.Property(p => p.TotalDeductions)
                .HasColumnType("decimal(18,2)");

            entity.Property(p => p.NetSalary)
                .HasColumnType("decimal(18,2)");

            entity.HasOne<HRPortal.Entities.Master.Employee>()
                .WithMany()
                .HasForeignKey(p => p.EmployeeMasterId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne<Salary>()
                .WithMany()
                .HasForeignKey(p => p.SalaryId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasIndex(p => new
            {
                p.EmployeeMasterId,
                p.Month,
                p.Year
            })
            .IsUnique();
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

            

        }

    }
}
