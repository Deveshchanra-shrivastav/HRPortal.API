using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Leave
{
    public class Leave : AuditEntity
    {
        public int LeaveId { get; set; }

        public int EmployeeMasterId { get; set; }

        public int LeaveTypeMasterId { get; set; }
        public int OrganizationMasterId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int NumberOfDays { get; set; }

        public string Reason { get; set; } = string.Empty;

        public string Status { get; set; } = "Pending";

        public int? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }
    }
}
