using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCoreproject.Migrations
{
    public partial class WebApiprojectModelsEmpContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Emp_lastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Emp_Id", "Emp_Contact", "Emp_Email", "Emp_FirstName", "Emp_dob", "Emp_lastName" },
                values: new object[] { 1, "745676574", "Jhon@gmail.com", "Jhon", new DateTime(2002, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Son" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Emp_Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Emp_lastName",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
