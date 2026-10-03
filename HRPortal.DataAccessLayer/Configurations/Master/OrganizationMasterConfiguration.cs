using HRPortal.Entities.Master;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.DataAccessLayer.Configurations.Master
{
    public class OrganizationMasterConfiguration: IEntityTypeConfiguration<OrganizationMaster>
    {
        public void Configure(EntityTypeBuilder<OrganizationMaster> entity)
        {
            entity.ToTable("OrganizationMaster");
            entity.HasKey(b => b.OrganizationMasterId);

            entity.Property(b => b.OrganizationMasterId)
                .UseIdentityColumn(1, 1);

            entity.Property(b => b.OrganizationCode)
                .IsRequired()
                .HasColumnType("nvarchar(max)");
            entity.Property(b => b.OrganizationName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(b => b.State)
                .IsRequired()
                .HasColumnType("nvarchar(max)");
            entity.Property(b => b.Email)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(b => b.MobileNumber)
                .IsRequired()
                .HasColumnType("nvarchar(max)");
            entity.Property(b => b.Address)
               .IsRequired()
               .HasColumnType("nvarchar(max)");
            entity.Property(b => b.City)
               .IsRequired()
               .HasColumnType("nvarchar(max)");
            entity.Property(b => b.Pincode)
               .IsRequired()
               .HasColumnType("nvarchar(max)");
            entity.Property(e => e.IsDeleted)
              .IsRequired()
              .HasDefaultValue(false);
            entity.Property(e => e.IsLatest)
                .IsRequired()
                .HasDefaultValue(true);
        }
    }
}
