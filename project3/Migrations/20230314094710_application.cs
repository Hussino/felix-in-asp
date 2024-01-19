using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project3.Migrations
{
    public partial class application : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_jobs",
                table: "jobs");

            migrationBuilder.RenameTable(
                name: "jobs",
                newName: "Jobs");

            migrationBuilder.AlterColumn<int>(
                name: "company_id",
                table: "Jobs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "job_id",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_of_app",
                table: "Applications",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "company_id",
                table: "Applications",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_company_id",
                table: "Jobs",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_company_id",
                table: "Applications",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_job_id",
                table: "Applications",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_user_id",
                table: "Applications",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Companies_company_id",
                table: "Applications",
                column: "company_id",
                principalTable: "Companies",
                principalColumn: "company_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Jobs_job_id",
                table: "Applications",
                column: "job_id",
                principalTable: "Jobs",
                principalColumn: "job_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Users_user_id",
                table: "Applications",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Companies_company_id",
                table: "Jobs",
                column: "company_id",
                principalTable: "Companies",
                principalColumn: "company_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Companies_company_id",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Jobs_job_id",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Users_user_id",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Companies_company_id",
                table: "Jobs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_company_id",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Applications_company_id",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_job_id",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_user_id",
                table: "Applications");

            migrationBuilder.RenameTable(
                name: "Jobs",
                newName: "jobs");

            migrationBuilder.AlterColumn<int>(
                name: "company_id",
                table: "jobs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "job_id",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date_of_app",
                table: "Applications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "company_id",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobs",
                table: "jobs",
                column: "job_id");
        }
    }
}
