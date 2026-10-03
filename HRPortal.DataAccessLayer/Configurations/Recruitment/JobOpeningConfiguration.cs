using HRPortal.Entities.Recruitment;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Entities.Master;

namespace HRPortal.DataAccessLayer.Configurations.Recruitment
{
    public class JobOpeningConfiguration : IEntityTypeConfiguration<JobOpening>
    {
        public void Configure(EntityTypeBuilder<JobOpening> entity)
        {
            entity.ToTable("JobOpenings");

            entity.HasKey(j => j.JobOpeningId);

            entity.Property(j => j.JobOpeningId)
                .UseIdentityColumn(1, 1);

            entity.Property(j => j.JobTitle)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(j => j.JobDescription)
                .HasColumnType("nvarchar(max)");

            entity.Property(j => j.Status)
                .IsRequired()
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
