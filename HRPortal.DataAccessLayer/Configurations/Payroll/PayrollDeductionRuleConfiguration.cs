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
    public class PayrollDeductionRuleConfiguration
        : IEntityTypeConfiguration<PayrollDeductionRule>
    {
        public void Configure(EntityTypeBuilder<PayrollDeductionRule> entity)
        {
            entity.ToTable("PayrollDeductionRules");

            entity.HasKey(p => p.PayrollDeductionRuleId);

            entity.Property(p => p.PayrollDeductionRuleId)
                .UseIdentityColumn(1, 1);

            entity.Property(p => p.RuleName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(p => p.Percentage)
                .HasColumnType("decimal(5,2)");

            entity.Property(p => p.FixedAmount)
                .HasColumnType("decimal(18,2)");

            entity.Property(p => p.MinimumLimit)
                .HasColumnType("decimal(18,2)");

            entity.Property(p => p.MaximumLimit)
                .HasColumnType("decimal(18,2)");

            entity.Property(p => p.Formula)
                .HasColumnType("nvarchar(max)");

            entity.Property(p => p.Description)
                .HasColumnType("nvarchar(max)");

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
