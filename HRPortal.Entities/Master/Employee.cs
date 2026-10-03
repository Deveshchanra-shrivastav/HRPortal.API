using HRPortal.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Master
{
    public class Employee : AuditEntity
    {
        public int EmployeeMasterId { get; set; }

        public string? EmployeeCode { get; set; }
        public string? PasswordHash { get; set; }

        public string? UserName { get; set; } 

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string MobileNumber { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int OrganizationMasterId { get; set; }

        public int DesignationMasterId { get; set; }

        public int RoleMasterId { get; set; }

        public int BranchMasterId { get; set; }

        public string? Gender { get; set; }

        public string? Address { get; set; }
    }
}
