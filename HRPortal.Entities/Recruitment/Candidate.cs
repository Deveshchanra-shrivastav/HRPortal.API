using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Recruitment
{
    public class Candidate : AuditEntity
    {
        public int CandidateId { get; set; }

        public int OrganizationMasterId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string? LastName { get; set; }

        public string Email { get; set; } = string.Empty;

        public string MobileNumber { get; set; } = string.Empty;

        public int JobOpeningId { get; set; }

        public string? ResumePath { get; set; }

        public string Status { get; set; } = "Applied";
    }
}
