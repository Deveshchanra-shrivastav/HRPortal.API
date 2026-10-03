using HRPortal.Entities.Leave;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Entities.Leave;
using HRPortal.Entities.Master;

namespace HRPortal.DataAccessLayer.Configurations.Leave
{
    public class LeaveConfiguration : IEntityTypeConfiguration<HRPortal.Entities.Leave.Leave>
    {
        public void Configure(EntityTypeBuilder<HRPortal.Entities.Leave.Leave> entity)
        {
            entity.ToTable("Leaves");

            entity.HasKey(l => l.LeaveId);

            entity.Property(l => l.LeaveId)
                .UseIdentityColumn(1, 1);

            entity.Property(l => l.Reason)
                .IsRequired()
                .HasColumnType("nvarchar(500)");

            entity.Property(l => l.Status)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            entity.HasOne<HRPortal.Entities.Master.Employee>()
                .WithMany()
                .HasForeignKey(l => l.EmployeeMasterId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne<LeaveType>()
                .WithMany()
                .HasForeignKey(l => l.LeaveTypeMasterId)
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

             entity.HasOne<LeaveType>()
               .WithMany()
               .HasForeignKey(e => e.LeaveTypeMasterId)
               .OnDelete(DeleteBehavior.Restrict);

            

        }
    }
}
