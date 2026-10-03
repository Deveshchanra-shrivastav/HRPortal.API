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
    public class HolidayConfiguration : IEntityTypeConfiguration<Holiday>
    {
        public void Configure(EntityTypeBuilder<Holiday> entity)
        {
            entity.ToTable("Holidays");

            entity.HasKey(h => h.HolidayMasterId);

            entity.Property(h => h.HolidayMasterId)
                .UseIdentityColumn(1, 1);

            entity.Property(h => h.HolidayName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(h => h.Description)
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
