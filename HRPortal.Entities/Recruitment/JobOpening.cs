using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Recruitment
{
    public class JobOpening : AuditEntity
    {
        public int JobOpeningId { get; set; }

        public string JobTitle { get; set; } = string.Empty;

        public int OrganizationMasterId { get; set; }

        public int DepartmentMasterId { get; set; }

        public int DesignationMasterId { get; set; }

        public string? JobDescription { get; set; }

        public int NumberOfPositions { get; set; }

        public DateTime OpeningDate { get; set; }

        public DateTime? ClosingDate { get; set; }

        public string Status { get; set; } = "Open";
    }
}
