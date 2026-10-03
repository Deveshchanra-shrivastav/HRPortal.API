using HRPortal.Entities.Master;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.DataAccessLayer.Authentication.Interface
{
    public interface ISignupRepository
    {
        

        Task<bool> EmployeeCodeExistsAsync(
            int organizationMasterId,
            string employeeCode);
        Task<bool> OrganizationExistsAsync(string organizationCode);

        Task<bool> EmployeeEmailExistsAsync(string email);

        Task<int> GetOrganizationAdminRoleIdAsync();

        Task CreateOrganizationAsync(OrganizationMaster organization);

        Task CreateEmployeeAsync(Employee employee);

        Task SaveChangesAsync();
        Task<bool> CreateOrganizationWithAdminAsync(OrganizationMaster organization,Employee employee);
        Task<IDbContextTransaction> BeginTransactionAsync();
    }

}
