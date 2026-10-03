using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Entities.Attendance;

namespace HRPortal.DataAccessLayer.Configurations.Attendance
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<HRPortal.Entities.Attendance.Attendance>
    {
        public void Configure(EntityTypeBuilder<HRPortal.Entities.Attendance.Attendance> entity)
        {
            entity.ToTable("Attendances");

            entity.HasKey(a => a.AttendanceId);

            entity.Property(a => a.AttendanceId)
                .UseIdentityColumn(1, 1);

            entity.Property(a => a.Status)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            entity.Property(a => a.Remarks)
                .HasColumnType("nvarchar(500)");

            entity.HasOne<HRPortal.Entities.Master.Employee>()
                .WithMany()
                .HasForeignKey(a => a.EmployeeMasterId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasIndex(a => new
            {
                a.EmployeeMasterId,
                a.AttendanceDate
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
