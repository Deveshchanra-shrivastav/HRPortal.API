using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Leave
{
    public class LeaveType : AuditEntity
    {
        public int LeaveTypeMasterId { get; set; }

        public string LeaveTypeName { get; set; } = string.Empty;

        public int OrganizationMasterId { get; set; }

        public int AllowedDays { get; set; }

        public string? Description { get; set; }
    }
}
