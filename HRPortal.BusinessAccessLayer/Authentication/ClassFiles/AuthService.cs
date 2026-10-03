using HRPortal.BusinessAccessLayer.Authentication.Interfaces;
using HRPortal.DataAccessLayer.Authentication.Interface;
using HRPortal.Entities.Authentication;
using HRPortal.Entities.Master;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.BusinessAccessLayer.Authentication.ClassFiles
{
    public class AuthService : IAuthService
    {
        private readonly ISignupRepository _signupRepository;
        private readonly IPasswordHasher _passwordHasher;

        public AuthService(
            ISignupRepository signupRepository,
            IPasswordHasher passwordHasher)
        {
            _signupRepository = signupRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<SignupResponse> SignupAsync(
            SignupRequest request)
        {
            // 1. Validate password
            if (request.Password != request.ConfirmPassword)
            {
                return new SignupResponse(false, "Password and Confirm Password do not match.");
            }

            // 2. Check Organization Code
            var organizationExists =
                await _signupRepository.OrganizationExistsAsync(
                    request.OrganizationCode);

            if (organizationExists)
            {
                return new SignupResponse(false, "Organization Code is already in use.");
            }

            // 3. Check Email
            var emailExists =
                await _signupRepository.EmployeeEmailExistsAsync(
                    request.Email);

            if (emailExists)
            {
                return new SignupResponse(false, "Email is already in use.");
            }

            // 4. Get Organization Admin Role
            var roleId =
                await _signupRepository.GetOrganizationAdminRoleIdAsync();

            if (roleId == 0)
            {
                return new SignupResponse(false, "Organization Admin role was not found.");
            }

            // 5. Create Organization
            var organization = new OrganizationMaster
            {
                OrganizationName = request.OrganizationName,
                OrganizationCode = request.OrganizationCode,
                Email = request.OrganizationEmail,
                MobileNumber = request.OrganizationMobileNumber
            };

            // 6. Create Employee
            var employee = new Employee
            {
                OrganizationMasterId =
                    organization.OrganizationMasterId,

                RoleMasterId = roleId,

                EmployeeCode = request.EmployeeCode,

                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                MobileNumber = request.MobileNumber,

                PasswordHash =
                    _passwordHasher.HashPassword(request.Password)
            };

            // 7. Send both objects to DAL
            var result =
                await _signupRepository.CreateOrganizationWithAdminAsync(
                    organization,
                    employee);

            if (!result)
            {
                return new SignupResponse(false, "Employee Code is already in use.");
            }

            // 8. Success response
            return new SignupResponse(true, "Signup successful.");
        }
    }
}
