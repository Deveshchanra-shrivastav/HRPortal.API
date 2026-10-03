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
    public class RoleMasterConfiguration: IEntityTypeConfiguration<RoleMaster>
    {
        public void Configure(EntityTypeBuilder<RoleMaster> entity) {

            entity.ToTable("RoleMaster");

            entity.HasKey(b => b.RoleMasterId);

            entity.Property(b => b.RoleMasterId).UseIdentityColumn(1, 1);

            entity.Property(b => b.RoleName).IsRequired().HasColumnType("nvarchar(150)");

            entity.Property(b => b.Description).IsRequired().HasColumnType("nvarchar(max)");

            entity.HasOne<OrganizationMaster>()
                .WithMany()
                .HasForeignKey(e => e.OrganizationMasterId)
                .OnDelete(DeleteBehavior.Restrict);

            


        }
    }
}
