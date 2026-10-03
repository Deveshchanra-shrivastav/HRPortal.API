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
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> entity)
        {
            entity.ToTable("Branches");

            entity.HasKey(b => b.BranchMasterId);

            entity.Property(b => b.BranchMasterId)
                .UseIdentityColumn(1, 1);

            entity.Property(b => b.BranchName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(b => b.Address)
                .HasColumnType("nvarchar(max)");

            entity.Property(b => b.City)
                .HasColumnType("nvarchar(max)");

            entity.Property(b => b.State)
                .HasColumnType("nvarchar(max)");

            entity.Property(b => b.Pincode)
                .HasColumnType("nvarchar(20)");
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
