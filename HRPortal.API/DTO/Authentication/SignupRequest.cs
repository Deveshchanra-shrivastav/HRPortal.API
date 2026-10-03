namespace HRPortal.API.DTO.Authentication
{
    public class SignupRequest
    {
        // Organization details
        public string OrganizationName { get; set; } = string.Empty;

        public string OrganizationCode { get; set; } = string.Empty;

        public string? OrganizationEmail { get; set; }

        public string? OrganizationMobileNumber { get; set; }

        // First admin employee details
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string MobileNumber { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
