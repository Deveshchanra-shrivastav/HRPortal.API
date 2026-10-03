using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Master
{
    public class Designation : AuditEntity
    {
        public int DesignationMasterId { get; set; }

        public string DesignationName { get; set; } = string.Empty;

        public string? Description { get; set; }
        public int OrganizationMasterId { get; set; }
    }
}
