using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRPortal.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddForeigOrg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsLatest",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_OrganizationMasterId",
                table: "Salaries",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMaster_OrganizationMasterId",
                table: "RoleMaster",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Payslips_OrganizationMasterId",
                table: "Payslips",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PayslipComponents_OrganizationMasterId",
                table: "PayslipComponents",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_PayrollDeductionRules_OrganizationMasterId",
                table: "PayrollDeductionRules",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveTypes_OrganizationMasterId",
                table: "LeaveTypes",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_OrganizationMasterId",
                table: "Leaves",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpenings_OrganizationMasterId",
                table: "JobOpenings",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_OrganizationMasterId",
                table: "Interviews",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidays_OrganizationMasterId",
                table: "Holidays",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalaryComponents_OrganizationMasterId",
                table: "EmployeeSalaryComponents",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BranchMasterId",
                table: "Employees",
                column: "BranchMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DesignationMasterId",
                table: "Employees",
                column: "DesignationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_OrganizationMasterId",
                table: "Employees",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleMasterId",
                table: "Employees",
                column: "RoleMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDepartments_OrganizationMasterId",
                table: "EmployeeDepartments",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_OrganizationMasterId",
                table: "Departments",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_OrganizationMasterId",
                table: "Candidates",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_OrganizationMasterId",
                table: "Branches",
                column: "OrganizationMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_OrganizationMaster_OrganizationMasterId",
                table: "Branches",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_OrganizationMaster_OrganizationMasterId",
                table: "Candidates",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_OrganizationMaster_OrganizationMasterId",
                table: "Departments",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDepartments_OrganizationMaster_OrganizationMasterId",
                table: "EmployeeDepartments",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Branches_BranchMasterId",
                table: "Employees",
                column: "BranchMasterId",
                principalTable: "Branches",
                principalColumn: "BranchMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Designations_DesignationMasterId",
                table: "Employees",
                column: "DesignationMasterId",
                principalTable: "Designations",
                principalColumn: "DesignationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_OrganizationMaster_OrganizationMasterId",
                table: "Employees",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_RoleMaster_RoleMasterId",
                table: "Employees",
                column: "RoleMasterId",
                principalTable: "RoleMaster",
                principalColumn: "RoleMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSalaryComponents_OrganizationMaster_OrganizationMasterId",
                table: "EmployeeSalaryComponents",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holidays_OrganizationMaster_OrganizationMasterId",
                table: "Holidays",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_OrganizationMaster_OrganizationMasterId",
                table: "Interviews",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobOpenings_OrganizationMaster_OrganizationMasterId",
                table: "JobOpenings",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Leaves_OrganizationMaster_OrganizationMasterId",
                table: "Leaves",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveTypes_OrganizationMaster_OrganizationMasterId",
                table: "LeaveTypes",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayrollDeductionRules_OrganizationMaster_OrganizationMasterId",
                table: "PayrollDeductionRules",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PayslipComponents_OrganizationMaster_OrganizationMasterId",
                table: "PayslipComponents",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payslips_OrganizationMaster_OrganizationMasterId",
                table: "Payslips",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleMaster_OrganizationMaster_OrganizationMasterId",
                table: "RoleMaster",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_OrganizationMaster_OrganizationMasterId",
                table: "Salaries",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_OrganizationMaster_OrganizationMasterId",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_OrganizationMaster_OrganizationMasterId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_OrganizationMaster_OrganizationMasterId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDepartments_OrganizationMaster_OrganizationMasterId",
                table: "EmployeeDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Branches_BranchMasterId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Designations_DesignationMasterId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_OrganizationMaster_OrganizationMasterId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_RoleMaster_RoleMasterId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSalaryComponents_OrganizationMaster_OrganizationMasterId",
                table: "EmployeeSalaryComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Holidays_OrganizationMaster_OrganizationMasterId",
                table: "Holidays");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_OrganizationMaster_OrganizationMasterId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_JobOpenings_OrganizationMaster_OrganizationMasterId",
                table: "JobOpenings");

            migrationBuilder.DropForeignKey(
                name: "FK_Leaves_OrganizationMaster_OrganizationMasterId",
                table: "Leaves");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveTypes_OrganizationMaster_OrganizationMasterId",
                table: "LeaveTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_PayrollDeductionRules_OrganizationMaster_OrganizationMasterId",
                table: "PayrollDeductionRules");

            migrationBuilder.DropForeignKey(
                name: "FK_PayslipComponents_OrganizationMaster_OrganizationMasterId",
                table: "PayslipComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_Payslips_OrganizationMaster_OrganizationMasterId",
                table: "Payslips");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleMaster_OrganizationMaster_OrganizationMasterId",
                table: "RoleMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_OrganizationMaster_OrganizationMasterId",
                table: "Salaries");

            migrationBuilder.DropIndex(
                name: "IX_Salaries_OrganizationMasterId",
                table: "Salaries");

            migrationBuilder.DropIndex(
                name: "IX_RoleMaster_OrganizationMasterId",
                table: "RoleMaster");

            migrationBuilder.DropIndex(
                name: "IX_Payslips_OrganizationMasterId",
                table: "Payslips");

            migrationBuilder.DropIndex(
                name: "IX_PayslipComponents_OrganizationMasterId",
                table: "PayslipComponents");

            migrationBuilder.DropIndex(
                name: "IX_PayrollDeductionRules_OrganizationMasterId",
                table: "PayrollDeductionRules");

            migrationBuilder.DropIndex(
                name: "IX_LeaveTypes_OrganizationMasterId",
                table: "LeaveTypes");

            migrationBuilder.DropIndex(
                name: "IX_Leaves_OrganizationMasterId",
                table: "Leaves");

            migrationBuilder.DropIndex(
                name: "IX_JobOpenings_OrganizationMasterId",
                table: "JobOpenings");

            migrationBuilder.DropIndex(
                name: "IX_Interviews_OrganizationMasterId",
                table: "Interviews");

            migrationBuilder.DropIndex(
                name: "IX_Holidays_OrganizationMasterId",
                table: "Holidays");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeSalaryComponents_OrganizationMasterId",
                table: "EmployeeSalaryComponents");

            migrationBuilder.DropIndex(
                name: "IX_Employees_BranchMasterId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DesignationMasterId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_OrganizationMasterId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_RoleMasterId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDepartments_OrganizationMasterId",
                table: "EmployeeDepartments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_OrganizationMasterId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_OrganizationMasterId",
                table: "Candidates");

            migrationBuilder.DropIndex(
                name: "IX_Branches_OrganizationMasterId",
                table: "Branches");

            migrationBuilder.AlterColumn<bool>(
                name: "IsLatest",
                table: "Employees",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);
        }
    }
}
