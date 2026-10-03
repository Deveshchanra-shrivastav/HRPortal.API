using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Entities.Authentication
{
    public class SignupRequest
    {
        public string OrganizationName { get; set; } = string.Empty;
        public string OrganizationCode { get; set; } = string.Empty;
        public string? OrganizationEmail { get; set; }
        public string? OrganizationMobileNumber { get; set; }
        public string EmployeeCode { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string MobileNumber { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
