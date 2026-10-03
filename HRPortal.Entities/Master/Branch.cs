using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Master
{
    public class Branch : AuditEntity
    {
        public int BranchMasterId { get; set; }

        public string BranchName { get; set; } = string.Empty;

        public int OrganizationMasterId { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Pincode { get; set; }
    }
}
