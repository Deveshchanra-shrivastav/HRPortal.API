using HRPortal.DataAccessLayer.Authentication.Interface;
using HRPortal.DataAccessLayer.Data;
using HRPortal.Entities.Master;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.DataAccessLayer.Authentication.ClassFiles
{
    public class SignupRepository : ISignupRepository
    {
        private readonly AppDbContext _context;


        public SignupRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> EmployeeCodeExistsAsync(int organizationMasterId,string employeeCode)
        {
            return await _context.Employees
                .AnyAsync(x =>
                    (x.OrganizationMasterId == organizationMasterId) && (x.EmployeeCode == employeeCode) && !Convert.ToBoolean(x.IsDeleted));
        }

        public async Task<bool> OrganizationExistsAsync(
            string organizationCode)
        {
            return await _context.OrganizationMasters.AnyAsync(x => x.OrganizationCode == organizationCode);
        }

        public async Task<bool> EmployeeEmailExistsAsync(
            string email)
        {
            return await _context.Employees
                .AnyAsync(x => x.Email == email);
        }

        public async Task<int> GetOrganizationAdminRoleIdAsync()
        {
            var role = await _context.RoleMasters
                .FirstOrDefaultAsync(x =>
                    x.RoleName == "OrganizationAdmin");

            return role?.RoleMasterId ?? 0;
        }

        public async Task CreateOrganizationAsync(
            OrganizationMaster organization)
        {
            await _context.OrganizationMasters.AddAsync(organization);
        }

        public async Task CreateEmployeeAsync(
            Employee employee)
        {
            await _context.Employees.AddAsync(employee);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database
                .BeginTransactionAsync();
        }
        public async Task<bool> CreateOrganizationWithAdminAsync(
    OrganizationMaster organization,
    Employee employee)
        {
            await using var transaction =
                await _context.Database.BeginTransactionAsync();

            try
            {
                // 1. Add organization
                await _context.OrganizationMasters.AddAsync(organization);

                // Generate OrganizationMasterId
                await _context.SaveChangesAsync();

                // 2. Check employee code after organization exists
                var employeeCodeExists =
                    await EmployeeCodeExistsAsync(
                        organization.OrganizationMasterId,
                        employee.EmployeeCode);

                if (employeeCodeExists)
                {
                    await transaction.RollbackAsync();
                    return false;
                }

                // 3. Set newly created organization ID
                employee.OrganizationMasterId =
                    organization.OrganizationMasterId;

                // 4. Add first employee
                await _context.Employees.AddAsync(employee);

                // 5. Save employee
                await _context.SaveChangesAsync();

                // 6. Commit transaction
                await transaction.CommitAsync();

                return true;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }
}
