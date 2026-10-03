using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRPortal.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeletedDefaults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SalaryComponents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "SalaryComponents",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "SalaryComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Salaries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Salaries",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Salaries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Payslips",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Payslips",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Payslips",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PayslipComponents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "PayslipComponents",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "PayslipComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PayrollDeductionRules",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "PayrollDeductionRules",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "PayrollDeductionRules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LeaveTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "LeaveTypes",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "LeaveTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Leaves",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Leaves",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Leaves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "JobOpenings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "JobOpenings",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "JobOpenings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Interviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Interviews",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Interviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Holidays",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Holidays",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Holidays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmployeeSalaryComponents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "EmployeeSalaryComponents",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "EmployeeSalaryComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Employees",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "EmployeeDepartments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "EmployeeDepartments",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "EmployeeDepartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Designations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Designations",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Designations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Candidates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Candidates",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Candidates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Branches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Branches",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Attendances",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "Attendances",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationMasterId",
                table: "Attendances",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SalaryComponents");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "SalaryComponents");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "SalaryComponents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Salaries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Payslips");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Payslips");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Payslips");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PayslipComponents");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "PayslipComponents");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "PayslipComponents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PayrollDeductionRules");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "PayrollDeductionRules");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "PayrollDeductionRules");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "JobOpenings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Interviews");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Holidays");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmployeeSalaryComponents");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "EmployeeSalaryComponents");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "EmployeeSalaryComponents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "EmployeeDepartments");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "EmployeeDepartments");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "EmployeeDepartments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Designations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "OrganizationMasterId",
                table: "Attendances");
        }
    }
}
