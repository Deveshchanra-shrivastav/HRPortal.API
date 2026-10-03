using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Attendance
{
    public class Attendance : AuditEntity
    {
        public int AttendanceId { get; set; }

        public int EmployeeMasterId { get; set; }
        public int OrganizationMasterId { get; set; }

        public DateTime AttendanceDate { get; set; }

        public DateTime? CheckInTime { get; set; }

        public DateTime? CheckOutTime { get; set; }

        public string Status { get; set; } = string.Empty;

        public string? Remarks { get; set; }
    }
}
