using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Recruitment
{
    public class Interview : AuditEntity
    {
        public int InterviewId { get; set; }

        public int OrganizationMasterId { get; set; }

        public int CandidateId { get; set; }

        public int RoundNumber { get; set; }

        public string RoundName { get; set; } = string.Empty;

        public DateTime InterviewDate { get; set; }

        public string? InterviewMode { get; set; }

        public string? InterviewerName { get; set; }

        public string Status { get; set; } = "Scheduled";

        public string? Feedback { get; set; }

        public string? Remarks { get; set; }
    }
}
