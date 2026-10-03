using HRPortal.Entities.Attendance;
using HRPortal.Entities.Leave;
using HRPortal.Entities.Master;
using HRPortal.Entities.Payroll;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.DataAccessLayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(AppDbContext).Assembly
            );
        }

        
        // Master
        public DbSet<OrganizationMaster> OrganizationMasters { get; set; }
        public DbSet<RoleMaster> RoleMasters { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Holiday> Holidays { get; set; }

        // Attendance
        public DbSet<Attendance> Attendances { get; set; }

        // Leave
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }

        // Payroll
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<SalaryComponent> SalaryComponents { get; set; }
        public DbSet<EmployeeSalaryComponent> EmployeeSalaryComponents { get; set; }
        public DbSet<PayrollDeductionRule> PayrollDeductionRules { get; set; }
        public DbSet<Payslip> Payslips { get; set; }
        public DbSet<PayslipComponent> PayslipComponents { get; set; }
    }
}
