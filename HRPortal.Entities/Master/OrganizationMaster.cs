using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Master
{
    public class OrganizationMaster : AuditEntity
    {
        public int OrganizationMasterId { get; set; }

        public string OrganizationCode { get; set; } = string.Empty;

        public string OrganizationName { get; set; } = string.Empty;

        public string? Email { get; set; }

        public string? MobileNumber { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Pincode { get; set; }
    }
}
