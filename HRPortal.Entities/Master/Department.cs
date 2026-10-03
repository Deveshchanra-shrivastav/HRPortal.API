using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Master
{
    public class Department : AuditEntity
    {
        public int DepartmentMasterId { get; set; }

        public string DepartmentName { get; set; } = string.Empty;

        public string? Description { get; set; }
        public int OrganizationMasterId { get; set; }
    }
}
