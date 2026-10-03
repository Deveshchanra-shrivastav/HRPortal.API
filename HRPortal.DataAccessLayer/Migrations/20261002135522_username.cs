using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRPortal.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class username : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeCode",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Employees",
                type: "nvarchar(150)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalaryComponents_OrganizationMasterId",
                table: "SalaryComponents",
                column: "OrganizationMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserName",
                table: "Employees",
                column: "UserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryComponents_OrganizationMaster_OrganizationMasterId",
                table: "SalaryComponents",
                column: "OrganizationMasterId",
                principalTable: "OrganizationMaster",
                principalColumn: "OrganizationMasterId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryComponents_OrganizationMaster_OrganizationMasterId",
                table: "SalaryComponents");

            migrationBuilder.DropIndex(
                name: "IX_SalaryComponents_OrganizationMasterId",
                table: "SalaryComponents");

            migrationBuilder.DropIndex(
                name: "IX_Employees_UserName",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeCode",
                table: "Employees",
                column: "EmployeeCode",
                unique: true);
        }
    }
}
