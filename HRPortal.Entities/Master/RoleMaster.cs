using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Master
{
    public class RoleMaster : AuditEntity
    {
        public int RoleMasterId { get; set; }

        public int OrganizationMasterId { get; set; }

        public string RoleName { get; set; } = string.Empty;

        public string? Description { get; set; }
    }
}
