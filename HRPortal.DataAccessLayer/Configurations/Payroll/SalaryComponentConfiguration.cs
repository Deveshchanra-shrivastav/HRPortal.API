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
    public class SalaryComponentConfiguration : IEntityTypeConfiguration<SalaryComponent>
    {
        public void Configure(EntityTypeBuilder<SalaryComponent> entity)
        {
            entity.ToTable("SalaryComponents");

            entity.HasKey(s => s.SalaryComponentMasterId);

            entity.Property(s => s.SalaryComponentMasterId)
                .UseIdentityColumn(1, 1);

            entity.Property(s => s.ComponentCode)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(s => s.ComponentName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(s => s.Description)
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

          

        }
    }
}
