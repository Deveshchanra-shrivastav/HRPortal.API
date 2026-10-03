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
    public class PayslipComponentConfiguration
        : IEntityTypeConfiguration<PayslipComponent>
    {
        public void Configure(EntityTypeBuilder<PayslipComponent> entity)
        {
            entity.ToTable("PayslipComponents");

            entity.HasKey(p => p.PayslipComponentId);

            entity.Property(p => p.PayslipComponentId)
                .UseIdentityColumn(1, 1);

            entity.Property(p => p.ComponentCode)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            entity.Property(p => p.ComponentName)
                .IsRequired()
                .HasColumnType("nvarchar(100)");

            entity.Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");

            entity.Property(p => p.Percentage)
                .HasColumnType("decimal(5,2)");

            entity.HasOne<Payslip>()
                .WithMany()
                .HasForeignKey(p => p.PayslipId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne<SalaryComponent>()
                .WithMany()
                .HasForeignKey(p => p.SalaryComponentMasterId)
                .OnDelete(DeleteBehavior.Restrict);
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
