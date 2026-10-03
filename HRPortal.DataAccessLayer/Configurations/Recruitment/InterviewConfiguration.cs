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
    public class InterviewConfiguration : IEntityTypeConfiguration<Interview>
    {
        public void Configure(EntityTypeBuilder<Interview> entity)
        {
            entity.ToTable("Interviews");

            entity.HasKey(i => i.InterviewId);

            entity.Property(i => i.InterviewId)
                .UseIdentityColumn(1, 1);

            entity.Property(i => i.RoundName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(i => i.InterviewMode)
                .HasColumnType("nvarchar(max)");

            entity.Property(i => i.InterviewerName)
                .HasColumnType("nvarchar(max)");

            entity.Property(i => i.Status)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(i => i.Feedback)
                .HasColumnType("nvarchar(max)");

            entity.Property(i => i.Remarks)
                .HasColumnType("nvarchar(max)");

            // One Candidate can have many Interview rounds
            entity.HasOne<Candidate>()
                .WithMany()
                .HasForeignKey(i => i.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasIndex(i => new
            {
                i.CandidateId,
                i.RoundNumber
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
