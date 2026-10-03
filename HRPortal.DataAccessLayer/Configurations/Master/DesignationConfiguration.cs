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
    public class DesignationConfiguration : IEntityTypeConfiguration<Designation>
    {
        public void Configure(EntityTypeBuilder<Designation> entity)
        {
            entity.ToTable("Designations");

            entity.HasKey(d => d.DesignationMasterId);

            entity.Property(d => d.DesignationMasterId)
                .UseIdentityColumn(1, 1);

            entity.Property(d => d.DesignationName)
                .IsRequired()
                .HasColumnType("nvarchar(max)");

            entity.Property(d => d.Description)
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
