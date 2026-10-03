using HRPortal.Entities.Leave;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Entities.Master;

namespace HRPortal.DataAccessLayer.Configurations.Leave
{
    public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> entity)
        {
            entity.ToTable("LeaveTypes");

            entity.HasKey(e => e.LeaveTypeMasterId);

            entity.Property(e => e.LeaveTypeMasterId)
                .UseIdentityColumn(1, 1);

            entity.Property(e => e.LeaveTypeName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(e => e.AllowedDays)
                .IsRequired();

            entity.Property(e => e.Description)
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
