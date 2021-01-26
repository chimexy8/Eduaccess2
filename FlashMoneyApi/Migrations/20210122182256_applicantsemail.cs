using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationAccessApi.Migrations
{
    public partial class applicantsemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScholarshipApplications_User_UserId",
                table: "ScholarshipApplications");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ScholarshipApplications",
                newName: "ApplicantsEmail");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "ScholarshipApplications",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_ScholarshipApplications_User_UserId",
                table: "ScholarshipApplications",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScholarshipApplications_User_UserId",
                table: "ScholarshipApplications");

            migrationBuilder.RenameColumn(
                name: "ApplicantsEmail",
                table: "ScholarshipApplications",
                newName: "Name");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "ScholarshipApplications",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ScholarshipApplications_User_UserId",
                table: "ScholarshipApplications",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
