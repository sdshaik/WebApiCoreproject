using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCoreproject.Migrations
{
    public partial class WebAoiCoewprojectModelsEmpContextseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Emp_Id", "Emp_Contact", "Emp_Email", "Emp_FirstName", "Emp_dob", "Emp_lastName" },
                values: new object[] { 2, "824534554", "sam@gmail.com", "sam", new DateTime(1999, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "T" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Emp_Id",
                keyValue: 2);
        }
    }
}
