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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.ToTable("Departments");

            entity.HasKey(d => d.DepartmentMasterId);

            entity.Property(d => d.DepartmentMasterId)
                .UseIdentityColumn(1, 1);

            entity.Property(d => d.DepartmentName)
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

            entity.HasOne<OrganizationMaster>()
               .WithMany()
               .HasForeignKey(e => e.OrganizationMasterId)
               .OnDelete(DeleteBehavior.Restrict);

           

        }
    }
}
