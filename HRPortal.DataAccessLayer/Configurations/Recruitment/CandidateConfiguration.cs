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
    public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> entity)
        {
            entity.ToTable("Candidates");

            entity.HasKey(c => c.CandidateId);

            entity.Property(c => c.CandidateId)
                .UseIdentityColumn(1, 1);

            entity.Property(c => c.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(c => c.LastName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(c => c.MobileNumber)
                .HasColumnType("nvarchar(max)");

            entity.Property(c => c.ResumePath)
                .HasColumnType("nvarchar(max)");

            entity.Property(c => c.Status)
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
